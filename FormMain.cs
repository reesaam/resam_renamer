using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ResamRenamer.Resources;
using ResamRenamer.Services;
//using System.Windows.Forms.VisualStyles;

namespace ResamRenamer
{
    public partial class FormMain : MaterialForm
    {
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
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //VisualStyleRenderer renderer =
            //new VisualStyleRenderer(System.Windows.Forms.VisualStyles.VisualStyleElement.Window.CloseButton.Normal);

            //MaterialSkinmanager Variable
            MaterialSkinManager materialskinmanager = Classes.UserInterface.ClassMaterialSkin.setMaterialSkinManager(this);
            FormInitialization();

            //new AppUpdate().CheckUpdate();
        }

        private void FormInitialization()
        {
            //Initializations
            boxNotSelected.Enabled = boxNotSelected.Visible = true;
            boxRename.Enabled = boxRename.Visible = false;
            boxSubtitle.Enabled = boxSubtitle.Visible = false;
            boxTools.Enabled = boxTools.Visible = false;
            lblFooterVersion.Text = AppInfo.currentVersion;
            lblFooterStatus.Text = AppStatus.idle.GetMessage();

            //Rename Combo PredefinedFilters List
            comboRenamePredefinedFilters.Items.AddRange(AppConstants.listPredefinedFilters);

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

        private async void FormMain_Shown(object sender, EventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 20;

            lblNotSelected.Visible = false;
            panelLoading.Visible = true;
            
            await Task.Delay(2000);
            new AppUpdate().CheckUpdate();
            await Task.Delay(4000);
            panelLoading.Visible = false;
            lblNotSelected.Visible = true;

            progressBar.Enabled = false;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblFooterStatus.Text = AppStrings.statusBusy;

            string messageLabel = "Message";
            string message = CheckErrors();
            if (message == "")
            {
                lblFooterStatus.Text = AppStrings.statusProcess;
                //Number of Changed Files
                int counter = 0;

                if (radioRename.Checked)
                    counter = RunRename();
                if (radioSubtitles.Checked)
                    counter = RunSubtitles();
                if (radioTools.Checked)
                    counter = RunTools();

                lblFooterStatus.Text = AppStrings.statusSuccessfull;
                message = AppStrings.MessageSuccessfull(counter);
                lblFooterStatus.Text = AppStrings.statusIdle;
            }
            else
            {
                messageLabel = AppStrings.statusError;
            }

            MessageBox.Show(message, messageLabel, MessageBoxButtons.OK);
            lblFooterStatus.Text = "Idle";
            //Activate();
            //Enabled = true;
        }
        private string CheckErrors()
        {
            lblFooterStatus.Text = AppStrings.statusCheckError;

            string errormsg = "";

            if (radioRename.Checked)
            {
                //Check Address Field
                if (txtRenameAddress.Text == null || txtRenameAddress.Text == "")
                {
                    errormsg = AppStrings.errorAddressEmpty;
                }

                //Check PredefinedFilters
                else if (radioRenamePredefinedFilter.Checked)
                {
                    if (comboRenamePredefinedFilters.SelectedIndex == -1)
                        errormsg = AppStrings.errorPickFilter;
                }

                //Check CustmFilters
                else if (radioRenameCustomFilter.Checked)
                {
                    if (txtRenameCustomFilterOriginalText.Text == AppStrings.textOriginalText)
                        errormsg = AppStrings.errorFillOriginal;
                    else if (!checkRenameCustomFilterRemove.Checked && txtRenameCustomFilterReplaceText.Text == "Replace Text")
                    {
                        errormsg = AppStrings.errorFillReplace;
                    }
                }

                //Check Address Existance
                else
                {
                    DirectoryInfo dirinfo = new DirectoryInfo(txtRenameAddress.Text);
                    if (!dirinfo.Exists)
                    {
                        DialogResult result = MessageBox.Show(AppStrings.MessageFolderNotExist(AppStrings.destination), AppStrings.empty, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            Directory.CreateDirectory(dirinfo.FullName);
                        else
                            errormsg = AppStrings.messageChooseFolderPath;
                    }
                }
            }
            else if (radioSubtitles.Checked)
            {
                if (!radioSubtitleMovie.Checked && !radioSubtitleSeries.Checked)
                {
                    errormsg = AppStrings.messageSelectAndFill;
                }
                else
                {
                    if (txtSubtitleDestination.Text == null || txtSubtitleDestination.Text == AppStrings.empty)
                        errormsg = AppStrings.MessageAddressEmpty(AppStrings.destination);
                    else if (txtSubtitleSource.Text == null || txtSubtitleSource.Text == AppStrings.empty)
                        errormsg = AppStrings.MessageAddressEmpty(AppStrings.source);
                    else if (txtSubtitleSubtitle.Text == null || txtSubtitleSubtitle.Text == AppStrings.empty)
                        errormsg = AppStrings.MessageAddressEmpty(AppStrings.subtitle);
                    else
                    {
                        DirectoryInfo dirinfoDestination = new DirectoryInfo(txtSubtitleDestination.Text);
                        if (!dirinfoDestination.Exists)
                        {
                            DialogResult result = MessageBox.Show(AppStrings.MessageFolderNotExist(AppStrings.destination), AppStrings.empty, MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                                Directory.CreateDirectory(dirinfoDestination.FullName);
                            else
                                errormsg = AppStrings.messageDestinationNotAvailable;
                        }

                        if (radioSubtitleMovie.Checked)
                        {
                            FileInfo fileSource = new FileInfo(txtSubtitleSource.Text);
                            FileInfo fileSubtitle = new FileInfo(txtSubtitleSubtitle.Text);

                            if (!fileSource.Exists)
                                errormsg = AppStrings.MessageFileNotExist(AppStrings.source);
                            else if (!fileSubtitle.Exists)
                                errormsg = AppStrings.MessageFileNotExist(AppStrings.subtitle);
                        }
                        else
                        {
                            DirectoryInfo dirinfoSource = new DirectoryInfo(txtSubtitleSource.Text);
                            DirectoryInfo dirinfoSubtitle = new DirectoryInfo(txtSubtitleSubtitle.Text);

                            if (!dirinfoSource.Exists)
                                errormsg = AppStrings.MessageAddressNotExist(AppStrings.source);
                            else if (!dirinfoSubtitle.Exists)
                                errormsg = AppStrings.MessageAddressNotExist(AppStrings.subtitle);
                        }
                    }

                    if (errormsg == AppStrings.empty)
                    {
                        if (radioSubtitleMovie.Checked)
                        {
                            FileInfo fileSource = new FileInfo(txtSubtitleSource.Text!);
                            FileInfo fileSubtitle = new FileInfo(txtSubtitleSubtitle.Text!);

                            if (!AppConstants.SupportedFormatsVideo.Contains(fileSource.Extension.ToString()))
                            {
                                errormsg = AppStrings.MessageFormatNotSupported(AppStrings.source);
                            }
                            if (!AppConstants.SupportedFormatsSubtitle.Contains(fileSubtitle.Extension.ToString()))
                            {
                                errormsg = AppStrings.MessageFormatNotSupported(AppStrings.subtitle);
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
                                if (AppConstants.SupportedFormatsVideo.Contains(file.Extension.ToString()))
                                    videofilescounter++;

                            foreach (var file in fileinfoSubtitleList)
                                if (AppConstants.SupportedFormatsSubtitle.Contains(file.Extension.ToString()))
                                    subtitlefilescounter++;

                            if (videofilescounter != subtitlefilescounter)
                                errormsg = AppStrings.errorNumberOfFiles;
                        }
                    }
                }
            }
            else if (radioTools.Checked)
            {
                var destination = txtToolsDestination.Text;
                if (destination == null || destination == AppStrings.empty)
                    errormsg = AppStrings.MessageAddressEmpty(AppStrings.destination);
                else if (radioToolsCSF.Checked)
                {
                    if (txtToolsCSFSeasonNumber.Text == "0")
                        errormsg = AppStrings.errorChooseNumber;
                }
                else if (radioToolsSFP.Checked)
                {

                }
                else
                {
                    DirectoryInfo dirinfoDestination = new DirectoryInfo(destination);
                    if (!dirinfoDestination.Exists)
                    {
                        errormsg = AppStrings.MessageFolderNotExist(AppStrings.destination);
                    }
                    else
                    {
                        var dirs = dirinfoDestination.GetDirectories();
                        foreach (var dir in dirs)
                        {
                            if (dir.Name.Contains(AppStrings.season))
                                errormsg = AppStrings.errorFolderNotExistTaskFailed;
                        }
                    }
                }
            }
            else
            {
                errormsg = AppStrings.errorChooseAction;
            }

            lblFooterStatus.Text = AppStrings.statusIdle;

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
                            (AppConstants.SupportedFormatsVideo.Contains(file.Extension) || checkRenameAllFormats.Checked))
                        {
                            File.Move(file.FullName, file.FullName.Replace(text, newtext));
                            counter++;
                        }
            }

            //Predefined Filters
            if (radioRenamePredefinedFilter.Checked)
            {
                List<AppPreDefinedFilters> filtersList = Enum.GetValues<AppPreDefinedFilters>().ToList();
                AppPreDefinedFilters selectedFilter = filtersList.FirstOrDefault(e => e.GetName() == comboRenamePredefinedFilters.Text);
                List<string> stringList = selectedFilter.GetStringList();
                stringList.ForEach(e => RenameExecute(e, AppStrings.empty));

                if (checkRenameFullArrange.Checked)
                {
                    //Not Implemented
                }
            }

            //Custom Filter
            if (radioRenameCustomFilter.Checked)
            {
                string oldtext = txtRenameCustomFilterOriginalText.Text;
                string replacetext = txtRenameCustomFilterReplaceText.Text;
                if (checkRenameCustomFilterRemove.Checked)
                    replacetext = AppStrings.empty;

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

                string FolderName = AppStrings.empty;
                string FolderNameYear = AppStrings.empty;

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
                    if (AppConstants.SupportedFormatsVideo.Contains(tempfileinfoSourceList[z].Extension))
                        fileinfoSourceList.Add(tempfileinfoSourceList[z]);

                for (int z = 0; z < tempfileinfoSubtitleList.Count(); z++)
                    if (AppConstants.SupportedFormatsSubtitle.Contains(tempfileinfoSubtitleList[z].Extension))
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
                    string folderAddressSeasons = Path.Combine(txtToolsDestination.Text, AppStrings.season + AppStrings.space + i.ToString().PadLeft(2, '0'));
                    Directory.CreateDirectory(folderAddressSeasons);
                    counter++;
                }
                string folderAddressSubtitle = Path.Combine(txtToolsDestination.Text, AppStrings.subtitles);
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
                        if (AppConstants.SupportedFormatsVideo.Contains(file.Extension))
                        {
                            var oldfilename = file.Name;
                            string seprator1;
                            string seprator2;
                            seprator1 = txtToolsSFP1.Text == null || txtToolsSFP1.Text == AppStrings.empty ? AppStrings.empty : "-";
                            seprator2 = txtToolsSFP2.Text == null || txtToolsSFP2.Text == AppStrings.empty ? AppStrings.empty : "-";
                            var newfilename = $"{txtToolsSFP1.Text}{seprator1}" +
                                $"{AppStrings.seasonInitial}{foldercounter.ToString().PadLeft(2, '0')}" +
                                $"{AppStrings.episodeInitial}{filecounter.ToString().PadLeft(2, '0')}" +
                                $"{seprator2}{txtToolsSFP2.Text}" +
                                $"{file.Extension}";
                            File.Move(file.FullName, file.FullName.Replace(oldfilename, newfilename));
                            filecounter++;
                            counter++;
                        }
                    }
                    var foldername = AppStrings.season + AppStrings.space + foldercounter++.ToString().PadLeft(2, '0');
                    if (foldername != folder.Name)
                        Directory.Move(folder.FullName, folder.FullName.Replace(folder.Name, foldername));
                }
            }

            return counter;
        }
        private void RadioBox_CheckedChanged(object sender, EventArgs e)
        {
            boxNotSelected.Visible = !(radioRename.Checked || radioSubtitles.Checked || radioTools.Checked);
            boxRename.Visible = radioRename.Checked;
            boxSubtitle.Visible = radioSubtitles.Checked;
            boxTools.Visible = radioTools.Checked;

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
                comboRenamePredefinedFilters.Hint = AppHints.filter;
            else
                comboRenamePredefinedFilters.Hint = AppStrings.empty;
            if (radioRenameCustomFilter.Checked)
            {
                txtRenameCustomFilterOriginalText.Hint = AppHints.originalText;
                txtRenameCustomFilterReplaceText.Hint = AppHints.replaceText;
            }
            else
            {
                txtRenameCustomFilterOriginalText.Hint = AppStrings.empty;
                txtRenameCustomFilterReplaceText.Hint = AppStrings.empty;
            }
        }
        private void RadioSubtitleBox_CheckedChanged(object sender, EventArgs e)
        {
            boxSubtitleInner.Enabled = radioSubtitleMovie.Checked || radioSubtitleSeries.Checked;
            txtSubtitleSource.Text = AppStrings.empty;
            txtSubtitleSubtitle.Text = AppStrings.empty;
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
                txtRenameCustomFilterReplaceText.Hint = AppStrings.empty;
            else
                txtRenameCustomFilterReplaceText.Hint = AppHints.replaceText;
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
            var index = buttonname.IndexOf(AppStrings.browse);
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
                if (extension != AppStrings.empty)
                    //File Dropped
                    MessageBox.Show(AppStrings.messageDragFolder);
                else
                    textbox.Text = filepath[0];
            }
            else
            {
                if (extension == "")
                    //Folder Dropped
                    MessageBox.Show(AppStrings.messageDragFile);
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

            tt.SetToolTip(radioRename, AppToolTips.radioRename);
            tt.SetToolTip(checkRenameFullArrange, AppToolTips.checkRenameFullArrange);
            tt.SetToolTip(checkRenameCustomFilterRemove, AppToolTips.checkRenameCustomFilterRemove);
            tt.SetToolTip(checkRenameAllFormats, AppToolTips.checkRenameAllFormats);
            tt.SetToolTip(checkRenameSubfolders, AppToolTips.checkRenameSubfolders);
            tt.SetToolTip(radioRenamePredefinedFilter, AppToolTips.radioRenamePredefinedFilter);
            tt.SetToolTip(comboRenamePredefinedFilters, AppToolTips.comboRenamePredefinedFilters);
            tt.SetToolTip(checkRenamePowerShell, AppToolTips.checkRenamePowerShell);
            tt.SetToolTip(radioSubtitles, AppToolTips.radioSubtitles);
            tt.SetToolTip(checkSameFolder, AppToolTips.checkSameFolder);
            tt.SetToolTip(radioTools, AppToolTips.radioTools);
            tt.SetToolTip(radioToolsCSF, AppToolTips.radioToolsCSF);
            tt.SetToolTip(radioToolsSFP, AppToolTips.radioToolsSFP);
            
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