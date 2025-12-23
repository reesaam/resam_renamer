using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;
using ResamRenamer.Resources;
using ResamRenamer.Services;

namespace ResamRenamer.Forms
{
    public partial class FormAbout : MaterialForm
    {
        public FormAbout()
        {
            InitializeComponent();

            //RoundedRectangleForm
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            static extern IntPtr CreateRoundRectRgn(
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //MaterialSkinmanager Variable
            MaterialSkinManager materialskinmanager = Classes.UserInterface.ClassMaterialSkin.setMaterialSkinManager(this);
            FormInitialization();
        }
        private void FormInitialization()
        {
            lblPhone.Text = AppInfo.AboutMobile;
            lblEmail.Text = AppInfo.AboutEmail;
            lblWebsite.Text = AppInfo.AboutWebsite;
            lblLinkedin.Text = AppInfo.AboutLinkedIn;

            lblCurrentVersion.Text = AppInfo.currentVersion;
            lblAvailableVersion.Text = "";
        }
        private void BtnInfoCopy_Click(object sender, EventArgs e)
        {
            MaterialButton obj = (MaterialButton)sender;
            string textcopy = "";

            switch (obj.Name)
            {
                case "btnPhoneCopy": textcopy = lblPhone.Text; break;
                case "btnEmailCopy": textcopy = lblEmail.Text; break;
                case "btnLinkedinCopy": textcopy = lblLinkedin.Text; break;
                case "btnWebsiteCopy": textcopy = lblWebsite.Text; break;
                default: break;
            }

            if (textcopy != "")
            {
                Clipboard.SetText(textcopy);
                MessageBox.Show("Information has been Copied to the Clipboard");
            }
        }
        private void BtnInfoAction_Click(object sender, EventArgs e)
        {
            MaterialButton obj = (MaterialButton)sender;
            string url = "";

            switch (obj.Name)
            {
                case "btnEmailSend": url = "emailto:resam.taghipour@ymail.com"; break;
                case "btnLinkedinOpen": url = "https://www.resam-t.ir"; break;
                case "btnWebsiteOpen": url = "https://www.linkedin.com/in/resam/"; break;
                default: break;
            }

            if (url != "")
            {
                try
                {
                    System.Diagnostics.Process.Start(url);
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }
        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            var update = new AppUpdate();
            string checkupdateversion = update.CheckVersion();
            lblAvailableVersion.Text = checkupdateversion;

            var btn = (MaterialButton)sender;
            if (btn.Text == "Install Update")
                update.DownloadUpdateAsync();

            if (AppInfo.currentVersion != checkupdateversion)
                btnCheckUpdate.Text = "Install Update";
           
            btnCheckUpdate.Text = "Check for Update";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
