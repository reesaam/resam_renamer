using System.Net;
using ResamRenamer.Resources;

namespace ResamRenamer.Services
{
    public class AppUpdate
    {
        private const string UrlUpdateCheckConfigFile = AppInfo.BaseUrl + "/config.txt";
        private const string UrlUpdateDownload = AppInfo.AppSource + "/ResamRenamer.exe";
        private const string UrlUpdatePackageDownload = AppInfo.AppSource + "/ResamRenamer.exe";
        private const string UrlUpdateInstallerDownload = AppInfo.AppSource + "/Installer/Install.exe";

        public static async void CheckUpdate()
        {
            string version = AppStrings.Empty;
            string error = AppStrings.Empty;

            if(System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                HttpClient client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(AppConstants.DefaultTimeOut);
                Task<HttpResponseMessage> response = client.GetAsync(UrlUpdateCheckConfigFile);
                version = await response.Result.Content.ReadAsStringAsync();
            }
            else
            {
                error = AppStrings.ErrorConnection;
            }

            if (error == AppStrings.Empty)
            {
                
                if (AppInfo.CurrentVersion != version)
                {
                    DialogResult result = MessageBox.Show(AppStrings.MessageUpdateAvailable, AppStrings.Empty, MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        DownloadUpdateAsync();
                }
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        public static string CheckVersion()
        {
            string version = "0.0.0";
            string error = AppStrings.Empty;

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                HttpClient client = new HttpClient();
                Task<HttpResponseMessage> response = client.GetAsync(UrlUpdateCheckConfigFile);
                Task<string> config = response.Result.Content.ReadAsStringAsync();
                version = config.Result;
            }
            else
            {
                error = AppStrings.ErrorConnection;
            }

            if (error != AppStrings.Empty)
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
        public static void DownloadUpdateAsync()
        {
            FolderBrowserDialog browseDialog = new FolderBrowserDialog();
            browseDialog.ShowNewFolderButton = true;
            browseDialog.RootFolder = Environment.SpecialFolder.Desktop;
            browseDialog.ShowDialog();
            string path = browseDialog.SelectedPath;

            WebClient client = new WebClient();
            try
            {
                client.DownloadFile(UrlUpdateInstallerDownload, path);
            }
            catch (Exception)
            {
                _ = MessageBox.Show(AppStrings.ErrorDownload, AppStrings.ErrorUpdateTitle);
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
                MessageBox.Show(AppStrings.ErrorInstaller, AppStrings.ErrorUpdateInstallTitle);
            }
        }
    }
}
