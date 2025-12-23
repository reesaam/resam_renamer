using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ResamRenamer.Resources;

namespace ResamRenamer.Services
{
    public class AppUpdate
    {
        string urlUpdateCheckConfigFile = AppInfo.BaseUrl + "/config.txt";
        string urlUpdateDownload = AppInfo.AppSource + "/ResamRenamer.exe";
        string urlUpdatePackageDownload = AppInfo.AppSource + "/ResamRenamer.exe";
        string urlUpdateInstallerDownload = AppInfo.AppSource + "/Installer/Install.exe";

        public async void CheckUpdate()
        {
            string version = "";
            string error = "";

            if(System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(20);
                var response = client.GetAsync(urlUpdateCheckConfigFile);
                version = await response.Result.Content.ReadAsStringAsync();
            }
            else
            {
                error = "Connection Error!";
            }

            if (error == "")
            {
                
                if (AppInfo.currentVersion != version)
                {
                    DialogResult result = MessageBox.Show("There is a Update Available\nDo you wnat to Download and Install?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        DownloadUpdateAsync();
                }
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        public string CheckVersion()
        {
            string version = "0.0.0";
            string error = "";

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                var client = new HttpClient();
                var response = client.GetAsync(urlUpdateCheckConfigFile);
                var config = response.Result.Content.ReadAsStringAsync();
                version = config.Result;
            }
            else
            {
                error = "Connection Error!";
            }

            if (error != "")
            {
                MessageBox.Show(error);
            }

            return version;
        }

        //Download Update File
        //public void DownloadUpdate()
        //{
        //    FolderBrowserDialog browsedialog = new FolderBrowserDialog();
        //    browsedialog.ShowNewFolderButton = true;
        //    browsedialog.RootFolder = Environment.SpecialFolder.Desktop;
        //    browsedialog.ShowDialog();
        //    string path = browsedialog.SelectedPath;

        //    if (path != "" || path != null)
        //    {
        //        DirectoryInfo dir = new DirectoryInfo(path);

        //        if (dir.Exists)
        //        {
        //            FileInfo[] files = dir.GetFiles();
        //            string fullpath = Path.Combine(path, AppName);
        //            FileInfo file = new FileInfo(fullpath);

        //            foreach (FileInfo fi in files)
        //            {
        //                if (fi.FullName == fullpath)
        //                {
        //                    var client = new WebClient();
        //                    client.DownloadFile(urlupdatedownload, path);

        //                    DialogResult result = MessageBox.Show("Download Update has been Done Successfully.\nThe Application will be Closed and You Can Reopen it to Apply Updates." , "Update", MessageBoxButtons.OK);
        //                    if (result == DialogResult.OK)
        //                        Application.Exit();
        //                }
        //            }

        //            //MessageBox.Show("Download and Install Update has been Done Successfully.\nThe Application will be Closed and You Can Reopen it to Apply Updates.");

        //            Application.Exit();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Resam Renamer.exe could not be Found!\nThe Application does not Exist in this Path.\nPlease Enter the Correct Path.", "Update Error");
        //            DownloadUpdate();
        //        }
        //    }
        //}

        //Download Installer
        public void DownloadUpdateAsync()
        {
            FolderBrowserDialog browsedialog = new FolderBrowserDialog();
            browsedialog.ShowNewFolderButton = true;
            browsedialog.RootFolder = Environment.SpecialFolder.Desktop;
            browsedialog.ShowDialog();
            string path = browsedialog.SelectedPath;

            var client = new WebClient();
            try
            {
                client.DownloadFile(urlUpdateInstallerDownload, path);
            }
            catch (Exception)
            {
                _ = MessageBox.Show("DownloadError!\nCheck your Connection to Internet.", "Update Error");
                throw;
            }
            
            string pathInstaller = Path.Combine(path, "Installer.exe");

            FileInfo file = new FileInfo(pathInstaller);
            if (file.Exists)
            {
                file.Open(FileMode.Open);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Installer File not Found!", "Install Update Error");
            }
        }
    }
}
