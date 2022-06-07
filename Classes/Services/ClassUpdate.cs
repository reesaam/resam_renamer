using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ResamRenamer.Classes
{
    public class ClassUpdate
    {
        string urlUpdateCheckConfigFile = "http://resamrenamer.resam-t.ir/config.txt";
        string urlUpdateDownload = "http://resamrenamer.resam-t.ir/AppSources/ResamRenamer.exe";
        string urlUpdatePackageDownload = "http://resamrenamer.resam-t.ir/AppSources/ResamRenamer.exe";
        string urlUpdateInstallerDownload = "http://resamrenamer.resam-t.ir/AppSources/Installer/Install.exe";

        string AppName = "Resam Renamer.exe";

        public void CheckUpdate()
        {
            string version = "0.0.0";
            string error = "";

            if(System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
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

            if (error == "")
            {
                
                if (AppInfo.version != version)
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
