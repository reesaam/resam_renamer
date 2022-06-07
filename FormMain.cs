using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//using System.Windows.Forms.VisualStyles;

namespace ResamRenamer
{
    public partial class FormMain : MaterialForm
    {
        string[] SupportedFormatsVideo = { ".mkv", ".avi", ".mp4" };
        string[] SupportedFormatsSubtitle = { ".srt" };

        public FormMain()
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

            //VisualStyleRenderer renderer =
            //new VisualStyleRenderer(System.Windows.Forms.VisualStyles.VisualStyleElement.Window.CloseButton.Normal);

            //MaterialSkinmanager Variable
            MaterialSkinManager materialskinmanager = Classes.UserInterface.ClassMaterialSkin.setMaterialSkinManager(this);
            FormInitialization();

            new Classes.ClassUpdate().CheckUpdate();
        }

        private void FormInitialization()
        {
            //Initializations
            boxRename.Enabled = false;
            boxSubtitle.Enabled = false;
            boxTools.Enabled = false;
            lblFooterVersion.Text = Classes.AppInfo.version;
            lblFooterStatus.Text = "Idle";

            //Rename Combo PredefinedFilters List
            String[] listPredefinedFilters = {"iMovie", "P30download", "Soft98", "SoftGozar"};
            comboRenamePredefinedFilters.Items.AddRange(listPredefinedFilters);

            //Temp Settings
            checkRenamePowerShell.Enabled = false;
            btnHelp.Enabled = false;

            //TextBoxes Drag&Drop
            //Allow Drop
            txtRenameAddress.AllowDrop = true;
            txtRenameCustomFilterOriginalText.AllowDrop = true;
            txtRenameCustomFilterReplaceText.AllowDrop = true;
            txtSubtitleDestination.AllowDrop = true;
            txtSubtitleSource.AllowDrop = true;
            txtSubtitleSubtitle.AllowDrop = true;
            txtToolsDestination.AllowDrop = true;
            txtToolsSFP1.AllowDrop = false;

            //DragDrop Function
            txtRenameAddress.DragDrop += ControlDragDrop!;
            txtRenameCustomFilterOriginalText.DragDrop += ControlDragDrop!;
            txtRenameCustomFilterReplaceText.DragDrop += ControlDragDrop!;
            txtSubtitleDestination.DragDrop += ControlDragDrop!;
            txtSubtitleSource.DragDrop += ControlDragDrop!;
            txtSubtitleSubtitle.DragDrop += ControlDragDrop!;
            txtToolsDestination.DragDrop += ControlDragDrop!;

            //Tooltips
            SetTooltips();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            lblFooterStatus.Text = "Working...";

            string messageLabel = "Message";
            string message = CheckErrors();
            if (message == "")
            {
                lblFooterStatus.Text = "Processing...";
                //Number of Changed Files
                int counter = 0;

                if (radioRename.Checked)
                    counter = RunRename();
                if (radioSubtitles.Checked)
                    counter = RunSubtitles();
                if (radioTools.Checked)
                    counter = RunTools();

                lblFooterStatus.Text = "Successfull Performance";
                message = "Proccess has been Done Successfully.\n" + counter.ToString() + " Files has been Created or Modified.";
                lblFooterStatus.Text = "Idle";
            }
            else
            {
                messageLabel = "Error";
            }

            lblFooterStatus.Text = "Error";
            MessageBox.Show(message, messageLabel, MessageBoxButtons.OK);
            lblFooterStatus.Text = "Idle";
            //Activate();
            //Enabled = true;
        }
        private string CheckErrors()
        {
            lblFooterStatus.Text = "Check for Errors";

            string errormsg = "";

            if (radioRename.Checked)
            {
                //Check Address Field
                if (txtRenameAddress.Text == null || txtRenameAddress.Text == "")
                {
                    errormsg = "Address field is Empty!";
                }

                //Check PredefinedFilters
                else if (radioRenamePredefinedFilter.Checked)
                {
                    if (comboRenamePredefinedFilters.SelectedIndex == -1)
                        errormsg = "Pick a Filter!";
                }

                //Check CustmFilters
                else if (radioRenameCustomFilter.Checked)
                {
                    if (txtRenameCustomFilterOriginalText.Text == "Original Text")
                        errormsg = "Fill Original Text Field!";
                    else if (!checkRenameCustomFilterRemove.Checked && txtRenameCustomFilterReplaceText.Text == "Replace Text")
                    {
                        errormsg = "Fill Replace Text Field for Replacement\nOR Check Remove to Remove the Text!";
                    }
                }

                //Check Address Existance
                else
                {
                    DirectoryInfo dirinfo = new DirectoryInfo(txtRenameAddress.Text);
                    if (!dirinfo.Exists)
                    {
                        DialogResult result = MessageBox.Show("The Destination Folder does not Exists.\nDo you want to Create this Folder?", "", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            Directory.CreateDirectory(dirinfo.FullName);
                        else
                            errormsg = "Choose an Available Folder Path!";
                    }
                }
            }
            else if (radioSubtitles.Checked)
            {
                if (!radioSubtitleMovie.Checked && !radioSubtitleSeries.Checked)
                {
                    errormsg = "Select Movie or Series and Fill Fields";
                }
                else
                {
                    if (txtSubtitleDestination.Text == null || txtSubtitleDestination.Text == "")
                        errormsg = "Destination Address is Empty";
                    else if (txtSubtitleSource.Text == null || txtSubtitleSource.Text == "")
                        errormsg = "Source Address is Empty";
                    else if (txtSubtitleSubtitle.Text == null || txtSubtitleSubtitle.Text == "")
                        errormsg = "Subtitle Address is Empty";
                    else
                    {
                        DirectoryInfo dirinfoDestination = new DirectoryInfo(txtSubtitleDestination.Text);
                        if (!dirinfoDestination.Exists)
                        {
                            DialogResult result = MessageBox.Show("The Destination Folder does not Exists.\nDo you want to Create this Folder?", "", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                                Directory.CreateDirectory(dirinfoDestination.FullName);
                            else
                                errormsg = "Choose an Available Folder Path for Destination!";
                        }

                        if (radioSubtitleMovie.Checked)
                        {
                            FileInfo fileSource = new FileInfo(txtSubtitleSource.Text);
                            FileInfo fileSubtitle = new FileInfo(txtSubtitleSubtitle.Text);

                            if (!fileSource.Exists)
                                errormsg = "Source File does not Exists.";
                            else if (!fileSubtitle.Exists)
                                errormsg = "Subtitle File does not Exists.";
                        }
                        else
                        {
                            DirectoryInfo dirinfoSource = new DirectoryInfo(txtSubtitleSource.Text);
                            DirectoryInfo dirinfoSubtitle = new DirectoryInfo(txtSubtitleSubtitle.Text);

                            if (!dirinfoSource.Exists)
                                errormsg = "Source Address does not Exists.";
                            else if (!dirinfoSubtitle.Exists)
                                errormsg = "Subtitle Address does not Exists.";
                        }
                    }

                    if (errormsg == "")
                    {
                        if (radioSubtitleMovie.Checked)
                        {
                            FileInfo fileSource = new FileInfo(txtSubtitleSource.Text!);
                            FileInfo fileSubtitle = new FileInfo(txtSubtitleSubtitle.Text!);

                            if (!SupportedFormatsVideo.Contains(fileSource.Extension.ToString()))
                            {
                                errormsg = "SourceFile Fomrat is not Supported";
                            }
                            if (!SupportedFormatsSubtitle.Contains(fileSubtitle.Extension.ToString()))
                            {
                                errormsg = "SubtitleFile Fomrat is not Supported";
                            }
                        }
                        else
                        {
                            DirectoryInfo dirinfoSource = new DirectoryInfo(txtSubtitleSource.Text!);
                            DirectoryInfo dirinfoSubtitle = new DirectoryInfo(txtSubtitleSubtitle.Text!);

                            FileInfo[] fileinfoSourceList = dirinfoSource.GetFiles();
                            FileInfo[] fileinfoSubtitleList = dirinfoSubtitle.GetFiles();

                            int videofilescounter = 0;
                            int subtitlefilescounter = 0;

                            foreach (var file in fileinfoSourceList)
                                if (SupportedFormatsVideo.Contains(file.Extension.ToString()))
                                    videofilescounter++;

                            foreach (var file in fileinfoSubtitleList)
                                if (SupportedFormatsSubtitle.Contains(file.Extension.ToString()))
                                    subtitlefilescounter++;

                            if (videofilescounter != subtitlefilescounter)
                                errormsg = "Number of VideoFiles and SubtitlesFiles are not Even!";
                        }
                    }
                }
            }
            else if (radioTools.Checked)
            {
                var destination = txtToolsDestination.Text;
                if (destination == null || destination == "")
                    errormsg = "Destination Address is Empty";
                else if (radioToolsCSF.Checked)
                {
                    if (txtToolsCSFSeasonNumber.Text == "0")
                        errormsg = "Choose a Number for Series Folder";
                }
                else if (radioToolsSFP.Checked)
                {

                }
                else
                {
                    DirectoryInfo dirinfoDestination = new DirectoryInfo(destination);
                    if (!dirinfoDestination.Exists)
                    {
                        errormsg = "The Destination Folder does not Exists.";
                    }
                    else
                    {
                        var dirs = dirinfoDestination.GetDirectories();
                        foreach (var dir in dirs)
                        {
                            if (dir.Name.Contains("Season"))
                                errormsg = "Destination Folder is Not Empty or Includes Some Similar Folders!\nTask is Unable to Perform";
                        }
                    }
                }
            }
            else
            {
                errormsg = "Choose an Action!!!";
            }

            lblFooterStatus.Text = "Idle";

            return errormsg;
        }
        private int RunRename()
        {
            int counter = 0;
            DirectoryInfo dirinfo = new DirectoryInfo(txtRenameAddress.Text);
            FileInfo[] fileinfolist = dirinfo.GetFiles();

            void RenameExecute(string text, string newtext)
            {
                List<DirectoryInfo> dirlist = new List<DirectoryInfo>();
                dirlist.Add(dirinfo);
                if (checkRenameSubfolders.Checked && dirinfo.GetDirectories().Count() > 0)
                { 
                    for (int i = 0; i < dirlist.Count; i++)
                        if (dirlist[i].GetDirectories().Count() > 0)
                            dirlist.AddRange(dirlist[i].GetDirectories());
                }
                foreach (DirectoryInfo folder in dirlist)
                    foreach (FileInfo file in folder.GetFiles())
                        if (file.Name.Contains(text) &&
                            (SupportedFormatsVideo.Contains(file.Extension) || checkRenameAllFormats.Checked))
                        {
                            File.Move(file.FullName, file.FullName.Replace(text, newtext));
                            counter++;
                        }
            }

            //Predefined Filters
            if (radioRenamePredefinedFilter.Checked)
            {
                //Filters : "iMovie", "P30download", "Soft98", "SoftGozar"

                string replacetext = "";
                if (checkRenameFullArrange.Checked)
                {
                    //Not Implemented
                }
                else
                {
                    List<string> stringlist = new List<string>();
                    if (comboRenamePredefinedFilters.Text == "iMovie")
                    {
                        stringlist.Add("_iMovie-DL-Exclusive");
                        stringlist.Add("_iMovie-DL");
                        stringlist.Add("-iMovie-DL");
                    }
                    if (comboRenamePredefinedFilters.Text == "P30download")
                    {
                        stringlist.Add("_www.p30download.com");
                        stringlist.Add("www.p30download.com");
                        stringlist.Add("_p30download.com");
                        stringlist.Add("p30download.com");
                    }
                    if (comboRenamePredefinedFilters.Text == "Soft98")
                    {
                        stringlist.Add("_www.soft98.ir");
                        stringlist.Add("www.soft98.ir");
                        stringlist.Add("_soft98.ir");
                        stringlist.Add("soft98.ir");
                    }
                    if (comboRenamePredefinedFilters.Text == "SoftGozar")
                    {
                        stringlist.Add("_www.softgozar.com");
                        stringlist.Add("www.softgozar.com");
                        stringlist.Add("_softgozar.com");
                        stringlist.Add("softgozar.com");
                    }

                    foreach (var str in stringlist)
                        RenameExecute(str, replacetext);
                }
            }

            //Custom Filter
            if (radioRenameCustomFilter.Checked)
            {
                string oldtext = txtRenameCustomFilterOriginalText.Text;
                string replacetext = txtRenameCustomFilterReplaceText.Text;
                if (checkRenameCustomFilterRemove.Checked)
                    replacetext = "";

                RenameExecute(oldtext, replacetext);
            }

            return counter;
        }
        private int RunSubtitles()
        {
            int counter = 0;

            if (radioSubtitleMovie.Checked)
            {
                FileInfo fileSource = new FileInfo(txtSubtitleSource.Text);
                FileInfo fileSubtitle = new FileInfo(txtSubtitleSubtitle.Text);

                string FolderName = "";
                string FolderNameYear = "";

                //Detect MovieName
                foreach (char ch in fileSource.Name)
                {
                    if (ch != '_' && ch != '-')
                        FolderName += ch;
                    else
                        break;
                }

                //Detect Movie Year
                string str = fileSource.Name;
                for (int i = 0; i < str.Length - 4; i++)
                {
                    int y = 0;
                    bool check = Int32.TryParse(str.Substring(i, 4), out y);
                    if (check && y > 1900 && y < 2100)
                        FolderNameYear = " (" + y.ToString() + ")";
                }

                string NewFolderAddress = Path.Combine(txtSubtitleDestination.Text, FolderName + FolderNameYear);
                Directory.CreateDirectory(NewFolderAddress);

                string NameMovie = Path.Combine(NewFolderAddress, fileSource.Name);
                fileSource.MoveTo(NameMovie);

                string NameSubtitle = Path.Combine(NewFolderAddress, fileSource.Name);
                NameSubtitle = NameSubtitle.Replace(fileSource.Extension, fileSubtitle.Extension);
                fileSubtitle.MoveTo(NameSubtitle);

                counter++;
            }
            else
            {
                DirectoryInfo dirinfoSource = new DirectoryInfo(txtSubtitleSource.Text);
                DirectoryInfo dirinfoSubtitle = new DirectoryInfo(txtSubtitleSubtitle.Text);
                FileInfo[] tempfileinfoSourceList = dirinfoSource.GetFiles();
                FileInfo[] tempfileinfoSubtitleList = dirinfoSubtitle.GetFiles();
                List<FileInfo> fileinfoSourceList = new List<FileInfo>();
                List<FileInfo> fileinfoSubtitleList = new List<FileInfo>();

                for (int z = 0; z < tempfileinfoSourceList.Count(); z++)
                    if (SupportedFormatsVideo.Contains(tempfileinfoSourceList[z].Extension))
                        fileinfoSourceList.Add(tempfileinfoSourceList[z]);

                for (int z = 0; z < tempfileinfoSubtitleList.Count(); z++)
                    if (SupportedFormatsSubtitle.Contains(tempfileinfoSubtitleList[z].Extension))
                        fileinfoSubtitleList.Add(tempfileinfoSubtitleList[z]);

                int i = 0;
                foreach (FileInfo file in fileinfoSourceList)
                {
                    string sourcename = file.Name;
                    file.MoveTo(Path.Combine(txtSubtitleDestination.Text, sourcename));

                    string subtitlename = Path.Combine(txtSubtitleDestination.Text, sourcename);
                    subtitlename = subtitlename.Replace(file.Extension, fileinfoSubtitleList[i].Extension);
                    fileinfoSubtitleList[i++].MoveTo(subtitlename);

                    counter++;
                }
            }

            return counter;
        }
        private int RunTools()
        {
            int counter = 0;
            int seasonsnumber = int.Parse(txtToolsCSFSeasonNumber.Text);
            DirectoryInfo dirinfo = new DirectoryInfo(txtToolsDestination.Text);

            if (radioToolsCSF.Checked)
            {
                for (int i = 1; i <= seasonsnumber; i++)
                {
                    string folderAddressSeasons = Path.Combine(txtToolsDestination.Text, "Season " + i.ToString().PadLeft(2, '0'));
                    Directory.CreateDirectory(folderAddressSeasons);
                    counter++;
                }
                string folderAddressSubtitle = Path.Combine(txtToolsDestination.Text, "Subtitles");
                Directory.CreateDirectory(folderAddressSubtitle);
                counter++;
            }

            else
            {
                var folders = dirinfo.GetDirectories();
                int foldercounter = 1;
                foreach (var folder in folders)
                {
                    var files = folder.GetFiles();
                    int filecounter = 1;
                    foreach (var file in files)
                    {
                        if (SupportedFormatsVideo.Contains(file.Extension))
                        {
                            var oldfilename = file.Name;
                            string seprator1;
                            string seprator2;
                            seprator1 = txtToolsSFP1.Text == null || txtToolsSFP1.Text == "" ? "" : "-";
                            seprator2 = txtToolsSFP2.Text == null || txtToolsSFP2.Text == "" ? "" : "-";
                            var newfilename = $"{txtToolsSFP1.Text}{seprator1}" +
                                $"S{foldercounter.ToString().PadLeft(2, '0')}" +
                                $"E{filecounter.ToString().PadLeft(2, '0')}" +
                                $"{seprator2}{txtToolsSFP2.Text}" +
                                $"{file.Extension}";
                            File.Move(file.FullName, file.FullName.Replace(oldfilename, newfilename));
                            filecounter++;
                            counter++;
                        }
                    }
                    var foldername = "Season " + foldercounter++.ToString().PadLeft(2, '0');
                    if (foldername != folder.Name)
                        Directory.Move(folder.FullName, folder.FullName.Replace(folder.Name, foldername));
                }
            }

            return counter;
        }
        private void RadioBox_CheckedChanged(object sender, EventArgs e)
        {
            boxRename.Enabled = radioRename.Checked;
            if (radioRename.Checked)
            {
                comboRenamePredefinedFilters.Enabled = !radioRename.Checked;
                checkRenameFullArrange.Enabled = !radioRename.Checked;
                txtRenameCustomFilterOriginalText.Enabled = !radioRename.Checked;
                txtRenameCustomFilterReplaceText.Enabled = !radioRename.Checked;
                checkRenameCustomFilterRemove.Enabled = !radioRename.Checked;
                RadioRename_CheckedChanged(sender, e);
            }
            else
            {
                radioRenamePredefinedFilter.Checked = radioRename.Checked;
                radioRenameCustomFilter.Checked = radioRename.Checked;
            }

            boxSubtitle.Enabled = radioSubtitles.Checked;
            if (radioSubtitles.Checked)
            {
                boxSubtitleInner.Enabled = radioSubtitleMovie.Checked || radioSubtitleSeries.Checked;
                checkSameFolder.Enabled = radioSubtitleMovie.Checked || radioSubtitleSeries.Checked;
            }
            else
            {
                radioSubtitleMovie.Checked = radioSubtitles.Checked;
                radioSubtitleSeries.Checked = radioSubtitles.Checked;
            }

            boxTools.Enabled = radioTools.Checked;
            if (radioTools.Checked)
            {
                radioToolsCSF.Enabled = radioTools.Checked;
                radioToolsSFP.Enabled = radioTools.Checked;

                lblToolsCSFSeasonsNumber.Enabled = !radioTools.Checked;
                txtToolsCSFSeasonNumber.Enabled = !radioTools.Checked;
                btnToolsCSFSeasonNumberInc.Enabled = !radioTools.Checked;
                btnToolsCSFSeasonNumberDec.Enabled = !radioTools.Checked;
                txtToolsSFP1.Enabled = !radioTools.Checked;
            }
            else
            {
                radioToolsCSF.Checked = radioTools.Checked;
                radioToolsSFP.Checked = radioTools.Checked;
            }
        }
        private void RadioRename_CheckedChanged(object sender, EventArgs e)
        {
            comboRenamePredefinedFilters.Enabled = radioRenamePredefinedFilter.Checked;
            checkRenameFullArrange.Enabled = radioRenamePredefinedFilter.Checked;

            txtRenameCustomFilterOriginalText.Enabled = radioRenameCustomFilter.Checked;
            txtRenameCustomFilterReplaceText.Enabled = radioRenameCustomFilter.Checked;
            checkRenameCustomFilterRemove.Enabled = radioRenameCustomFilter.Checked;
            if (radioRenamePredefinedFilter.Checked)
                comboRenamePredefinedFilters.Hint = "Choose a Filter";
            else
                comboRenamePredefinedFilters.Hint = "";
            if (radioRenameCustomFilter.Checked)
            {
                txtRenameCustomFilterOriginalText.Hint = "Original Text";
                txtRenameCustomFilterReplaceText.Hint = "Replace Text";
            }
            else
            {
                txtRenameCustomFilterOriginalText.Hint = "";
                txtRenameCustomFilterReplaceText.Hint = "";
            }
        }
        private void RadioSubtitleBox_CheckedChanged(object sender, EventArgs e)
        {
            boxSubtitleInner.Enabled = radioSubtitleMovie.Checked || radioSubtitleSeries.Checked;
            txtSubtitleSource.Text = "";
            txtSubtitleSubtitle.Text = "";
            checkSameFolder.Enabled = radioSubtitleSeries.Checked;
        }
        private void RadioToolsBox_CheckedChanged(object sender, EventArgs e)
        {
            lblToolsCSFSeasonsNumber.Enabled = radioToolsCSF.Checked;
            txtToolsCSFSeasonNumber.Enabled = radioToolsCSF.Checked;
            btnToolsCSFSeasonNumberInc.Enabled = radioToolsCSF.Checked;
            btnToolsCSFSeasonNumberDec.Enabled = radioToolsCSF.Checked;

            txtToolsSFP1.Enabled = radioToolsSFP.Checked;
            txtToolsCSFSeasonNumber.Text = 0.ToString();
        }
        private void checkRenameCustomFilterRemove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRenameCustomFilterRemove.Checked)
                txtRenameCustomFilterReplaceText.Hint = "";
            else
                txtRenameCustomFilterReplaceText.Hint = "Replace Text";
            txtRenameCustomFilterReplaceText.Enabled = !checkRenameCustomFilterRemove.Checked;
        }
        private void checkSameFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSameFolder.Checked)
            {
                txtSubtitleSource.Text = txtSubtitleDestination.Text;
                txtSubtitleSubtitle.Text = txtSubtitleDestination.Text;
                txtSubtitleSource.Enabled = false;
                txtSubtitleSubtitle.Enabled = false;
            }
            else
            {
                txtSubtitleSource.Enabled = true;
                txtSubtitleSubtitle.Enabled = true;
            }
        }
        private void txtSubtitleDestination_TextChanged(object sender, EventArgs e)
        {
            if (checkSameFolder.Checked)
            {
                txtSubtitleSource.Text = txtSubtitleDestination.Text;
                txtSubtitleSubtitle.Text = txtSubtitleDestination.Text;
            }
        }
        private void txtToolsCSFSeasonNumber_TextChanged(object sender, EventArgs e)
        {
            var seasonnumber = int.Parse(txtToolsCSFSeasonNumber.Text);
        }
        private void btnToolsCSFSeasonNumberInc_Click(object sender, EventArgs e)
        {
            int seasonnumber = int.Parse(txtToolsCSFSeasonNumber.Text);
            if (seasonnumber < 100)
            {
                txtToolsCSFSeasonNumber.Text = (++seasonnumber).ToString();
            }
        }
        private void btnToolsCSFSeasonNumberDec_Click(object sender, EventArgs e)
        {
            int seasonnumber = int.Parse(txtToolsCSFSeasonNumber.Text);
            if (seasonnumber > 0)
            {
                txtToolsCSFSeasonNumber.Text = (--seasonnumber).ToString();
            }

        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string BrowseFolder()
            {
                //Broswer Dialog
                FolderBrowserDialog browsefolderdialog = new FolderBrowserDialog();
                browsefolderdialog.ShowNewFolderButton = true;
                browsefolderdialog.RootFolder = Environment.SpecialFolder.Desktop;

                //Show Dialog
                browsefolderdialog.ShowDialog();

                return browsefolderdialog.SelectedPath;
            }

            string BrowseFile()
            {
                //Browse File Dialog
                OpenFileDialog browsefiledialog = new OpenFileDialog();
                browsefiledialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                browsefiledialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                browsefiledialog.FilterIndex = 1;
                browsefiledialog.CheckFileExists = true;
                browsefiledialog.CheckPathExists = true;
                browsefiledialog.Multiselect = false;

                //Show Dialog
                browsefiledialog.ShowDialog();

                return browsefiledialog.FileName;
            }

            //Get ButtonName
            var buttonname = (sender as MaterialButton)!.Name;
            var index = buttonname.IndexOf("Browse");
            var textboxname = buttonname.Substring(0, index);
            textboxname = textboxname.Replace("btn", "txt");
            var form = this.FindForm();
            var textbox = form.Controls.Find(textboxname, true)[0];

            string path = "";
            //FolderorFile Switch - True is Folder
            bool folderorfile = true;

            //File Browse Situations
            if (radioSubtitleMovie.Checked)
            {
                if (textbox.Name == "txtSubtitleSource")
                    folderorfile = false;
                if (textbox.Name == "txtSubtitleSubtitle")
                    folderorfile = false;
            }

            //BrowseDialog
            if (folderorfile)
                path = BrowseFolder();
            else
                path = BrowseFile();

            textbox.Text = path;
        }
        private void ControlDragDrop(object sender, EventArgs e)
        {
            string[] filepath = (string[])((DragEventArgs)e).Data.GetData(DataFormats.FileDrop, false);
            FileInfo file = new FileInfo(filepath[0]);
            var extension = file.Extension;

            //Get ButtonName
            var textbox = (MaterialTextBox)sender;

            //Folder or File Switch - True is Folder
            bool folderorfile = true;
            if (radioSubtitleMovie.Checked)
            {
                switch (textbox.Name)
                {
                    case "txtSubtitleSource": folderorfile = false; break;
                    case "txtSubtitleSubtitle": folderorfile = false; break;
                    default: break;
                }
            }

            if (folderorfile)
            {
                if (extension != "")
                    //File Dropped
                    MessageBox.Show("This is a File, Drag a Folder to specifiy a Location.");
                else
                    textbox.Text = filepath[0];
            }
            else
            {
                if (extension == "")
                    //Folder Dropped
                    MessageBox.Show("This is a Folder, Drag a Supported Movie or Subtitle File.");
                else
                    textbox.Text = filepath[0];
            }
        }
        private void SetTooltips()
        {
            var tt = new ToolTip();
            tt.UseFading = false;
            tt.UseAnimation = false;
            tt.Active = true;
            tt.ShowAlways = true;

            tt.SetToolTip(radioRename, "Rename Files by following Specifications.");
            tt.SetToolTip(checkRenameFullArrange, "Organize the Folder by Known Predefined Pattern.");
            tt.SetToolTip(checkRenameCustomFilterRemove, "Remove the specified string instead of replacing it.");
            tt.SetToolTip(checkRenameAllFormats, "This app would influence Video Files by default,\nBut you can use it for any format of files by checking this.");
            tt.SetToolTip(checkRenameSubfolders, "Apply all Settings to all Subfolders of specified Address.");
            tt.SetToolTip(radioRenamePredefinedFilter, "You can Choose a Predefined Filter.");
            tt.SetToolTip(comboRenamePredefinedFilters, "You can Choose a Predefined Filter.");
            tt.SetToolTip(checkRenamePowerShell, "Perform needed actions using PowerShell.");
            tt.SetToolTip(radioSubtitles, "Organize Subtitles for Movies and Series Folders.");
            tt.SetToolTip(checkSameFolder, "It's Enabled only for Series,\nYou can address Destination, Source and Subtitles when All are in one Folder.");
            tt.SetToolTip(radioTools, "Some Tools to Organize Folders and Rename Series Automaticlly.");
            tt.SetToolTip(radioToolsCSF, "Creating Seasons Folder, plus a Subtitle Folder, to be more easily Organized.");
            tt.SetToolTip(radioToolsSFP, "Rename All Folders and Episodes of a Series Automatically by a constant defined pattern,\nYou can only address the Main Folder of Series.");
            
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            var formabout = Application.OpenForms["FormAbout"];

            if (formabout == null)
            {
                Forms.FormAbout formAbout = new Forms.FormAbout();
                formAbout.Show();
            }
            else
            {
                formabout.BringToFront();
            }
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            var formhelp = Application.OpenForms["FormHelp"];

            if (formhelp == null)
            {
                Forms.FormHelp formHelp = new Forms.FormHelp();
                formHelp.Show();
            }
            else
            {
                formhelp.BringToFront();
            }
        }
        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                btnRun_Click(sender, e);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            lblFooterStatus.Text = "Exiting...";
            this.Close();          
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Exit", buttons: MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}