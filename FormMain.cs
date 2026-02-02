using MaterialSkin;
using MaterialSkin.Controls;
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

            //Material Skin Manager Variable
            MaterialSkinManager materialSkinManager = Classes.UserInterface.ClassMaterialSkin.SetMaterialSkinManager(this);
            FormInitialization();
        }

        private void FormInitialization()
        {
            //Initializations
            boxNotSelected.Enabled = boxNotSelected.Visible = true;
            boxRename.Enabled = boxRename.Visible = false;
            boxSubtitle.Enabled = boxSubtitle.Visible = false;
            boxTools.Enabled = boxTools.Visible = false;
            boxData.Enabled = boxData.Visible = false;
            // btnRun.Enabled = false;
            lblFooterVersion.Text = AppInfo.CurrentVersion;
            lblFooterStatus.Text = AppStatus.idle.GetMessage();

            //Rename Combo PredefinedFilters List
            comboRenamePredefinedFilters.Items.AddRange(AppConstants.ListPredefinedFilters.ToArray());

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
            txtDataAddress.AllowDrop = true;

            //DragDrop Function
            txtRenameAddress.DragDrop += ControlDragDrop!;
            txtRenameCustomFilterOriginalText.DragDrop += ControlDragDrop!;
            txtRenameCustomFilterReplaceText.DragDrop += ControlDragDrop!;
            txtSubtitleDestination.DragDrop += ControlDragDrop!;
            txtSubtitleSource.DragDrop += ControlDragDrop!;
            txtSubtitleSubtitle.DragDrop += ControlDragDrop!;
            txtToolsDestination.DragDrop += ControlDragDrop!;
            txtDataAddress.DragDrop += ControlDragDrop!;

            //Tooltips
            SetTooltips();
        }

        private async void FormMain_Shown(object sender, EventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 20;

            lblNotSelected.Visible = false;
            panelLoading.Visible = true;
            
            // await Task.Delay(AppConstants.DefaultAppUpdateDelay);
            // AppUpdate.CheckUpdate();
            // await Task.Delay(AppConstants.DefaultAppUpdateDelay * 2);
            panelLoading.Visible = false;
            lblNotSelected.Visible = true;

            progressBar.Enabled = false;
        }

        /// RUN BUTTON FUNCTIONALITY
        private void btnRun_Click(object sender, EventArgs e)
        {
            bool showCounterMessageDialog = true;
            lblFooterStatus.Text = AppStrings.StatusBusy;

            string messageLabel = AppStrings.MessageMessage;
            string message = CheckErrors();
            if (message == AppStrings.Empty)
            {
                lblFooterStatus.Text = AppStrings.StatusProcess;
                //Number of Changed Files
                int counter = 0;

                if (radioRename.Checked)
                    counter = RunRename();
                if (radioSubtitles.Checked)
                    counter = RunSubtitles();
                if (radioTools.Checked)
                    counter = RunTools();
                if (radioData.Checked)
                {
                    showCounterMessageDialog = false;
                    RunData();
                }

                lblFooterStatus.Text = AppStrings.StatusSuccessful;
                message = AppStrings.MessageSuccessful(counter);
                lblFooterStatus.Text = AppStrings.StatusIdle;
            }
            else
            {
                messageLabel = AppStrings.StatusError;
            }

            if (showCounterMessageDialog) 
            {
                MessageBox.Show(message, messageLabel, MessageBoxButtons.OK);
                lblFooterStatus.Text = AppStrings.StatusIdle;
                //Activate();
                //Enabled = true;
            }
        }
        
        /// CHECK ERRORS
        private string CheckErrors()
        {
            lblFooterStatus.Text = AppStrings.StatusCheckError;

            string errorMsg = AppStrings.Empty;

            if (radioRename.Checked)
            {
                //Check Address Field
                if (txtRenameAddress.Text == AppStrings.Empty)
                {
                    errorMsg = AppStrings.ErrorAddressEmpty;
                }

                //Check PredefinedFilters
                else if (radioRenamePredefinedFilter.Checked)
                {
                    if (comboRenamePredefinedFilters.SelectedIndex == -1)
                        errorMsg = AppStrings.ErrorPickFilter;
                }

                //Check CustomFilters
                else if (radioRenameCustomFilter.Checked)
                {
                    if (txtRenameCustomFilterOriginalText.Text == AppStrings.TextOriginalText)
                        errorMsg = AppStrings.ErrorFillOriginal;
                    else if (!checkRenameCustomFilterRemove.Checked && txtRenameCustomFilterReplaceText.Text == AppStrings.TextReplaceText)
                    {
                        errorMsg = AppStrings.ErrorFillReplace;
                    }
                }

                //Check Address Existance
                else
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(txtRenameAddress.Text);
                    if (!dirInfo.Exists)
                    {
                        DialogResult result = MessageBox.Show(AppStrings.MessageFolderNotExist(AppStrings.Destination), AppStrings.Empty, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            Directory.CreateDirectory(dirInfo.FullName);
                        else
                            errorMsg = AppStrings.MessageChooseFolderPath;
                    }
                }
            }
            else if (radioSubtitles.Checked)
            {
                if (!radioSubtitleMovie.Checked && !radioSubtitleSeries.Checked)
                {
                    errorMsg = AppStrings.MessageSelectAndFill;
                }
                else
                {
                    if (txtSubtitleDestination.Text == AppStrings.Empty)
                        errorMsg = AppStrings.MessageAddressEmpty(AppStrings.Destination);
                    else if (txtSubtitleSource.Text == AppStrings.Empty)
                        errorMsg = AppStrings.MessageAddressEmpty(AppStrings.Source);
                    else if (txtSubtitleSubtitle.Text == AppStrings.Empty)
                        errorMsg = AppStrings.MessageAddressEmpty(AppStrings.Subtitle);
                    else
                    {
                        DirectoryInfo dirInfoDestination = new DirectoryInfo(txtSubtitleDestination.Text);
                        if (!dirInfoDestination.Exists)
                        {
                            DialogResult result = MessageBox.Show(AppStrings.MessageFolderNotExist(AppStrings.Destination), AppStrings.Empty, MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                                Directory.CreateDirectory(dirInfoDestination.FullName);
                            else
                                errorMsg = AppStrings.MessageDestinationNotAvailable;
                        }

                        if (radioSubtitleMovie.Checked)
                        {
                            FileInfo fileSource = new FileInfo(txtSubtitleSource.Text);
                            FileInfo fileSubtitle = new FileInfo(txtSubtitleSubtitle.Text);

                            if (!fileSource.Exists)
                                errorMsg = AppStrings.MessageFileNotExist(AppStrings.Source);
                            else if (!fileSubtitle.Exists)
                                errorMsg = AppStrings.MessageFileNotExist(AppStrings.Subtitle);
                        }
                        else
                        {
                            DirectoryInfo dirInfoSource = new DirectoryInfo(txtSubtitleSource.Text);
                            DirectoryInfo dirInfoSubtitle = new DirectoryInfo(txtSubtitleSubtitle.Text);

                            if (!dirInfoSource.Exists)
                                errorMsg = AppStrings.MessageAddressNotExist(AppStrings.Source);
                            else if (!dirInfoSubtitle.Exists)
                                errorMsg = AppStrings.MessageAddressNotExist(AppStrings.Subtitle);
                        }
                    }

                    if (errorMsg == AppStrings.Empty)
                    {
                        if (radioSubtitleMovie.Checked)
                        {
                            FileInfo fileSource = new FileInfo(txtSubtitleSource.Text!);
                            FileInfo fileSubtitle = new FileInfo(txtSubtitleSubtitle.Text!);

                            if (!AppConstants.SupportedFormatsVideo.Contains(fileSource.Extension.ToString()))
                            {
                                errorMsg = AppStrings.MessageFormatNotSupported(AppStrings.Source);
                            }
                            if (!AppConstants.SupportedFormatsSubtitle.Contains(fileSubtitle.Extension.ToString()))
                            {
                                errorMsg = AppStrings.MessageFormatNotSupported(AppStrings.Subtitle);
                            }
                        }
                        else
                        {
                            DirectoryInfo dirInfoSource = new DirectoryInfo(txtSubtitleSource.Text!);
                            DirectoryInfo dirInfoSubtitle = new DirectoryInfo(txtSubtitleSubtitle.Text!);

                            FileInfo[] fileInfoSourceList = dirInfoSource.GetFiles();
                            FileInfo[] fileInfoSubtitleList = dirInfoSubtitle.GetFiles();

                            int videoFilesCounter = 0;
                            int subtitleFilesCounter = 0;

                            foreach (FileInfo file in fileInfoSourceList)
                                if (AppConstants.SupportedFormatsVideo.Contains(file.Extension.ToString()))
                                    videoFilesCounter++;

                            foreach (FileInfo file in fileInfoSubtitleList)
                                if (AppConstants.SupportedFormatsSubtitle.Contains(file.Extension.ToString()))
                                    subtitleFilesCounter++;

                            if (videoFilesCounter != subtitleFilesCounter)
                                errorMsg = AppStrings.ErrorNumberOfFiles;
                        }
                    }
                }
            }
            else if (radioTools.Checked)
            {
                string destination = txtToolsDestination.Text;
                if (destination == AppStrings.Empty)
                    errorMsg = AppStrings.MessageAddressEmpty(AppStrings.Destination);
                else if (radioToolsCSF.Checked)
                {
                    if (txtToolsCSFSeasonNumber.Text == "0")
                        errorMsg = AppStrings.ErrorChooseNumber;
                }
                else if (radioToolsSFP.Checked)
                {

                }
                else
                {
                    DirectoryInfo dirInfoDestination = new DirectoryInfo(destination);
                    if (!dirInfoDestination.Exists)
                    {
                        errorMsg = AppStrings.MessageFolderNotExist(AppStrings.Destination);
                    }
                    else
                    {
                        List<DirectoryInfo> dirs = dirInfoDestination.GetDirectories().ToList();
                        foreach (DirectoryInfo dir in dirs)
                        {
                            if (dir.Name.Contains(AppStrings.Season))
                                errorMsg = AppStrings.ErrorFolderNotExistTaskFailed;
                        }
                    }
                }
            }
            if (radioData.Checked)
            {
                //Check Address Field
                if (txtDataAddress.Text == AppStrings.Empty)
                {
                    errorMsg = AppStrings.ErrorAddressEmpty;
                }
            }
            else
            {
                errorMsg = AppStrings.ErrorChooseAction;
            }

            lblFooterStatus.Text = AppStrings.StatusIdle;

            return errorMsg;
        }
        private int RunRename()
        {
            int counter = 0;
            DirectoryInfo dirInfo = new DirectoryInfo(txtRenameAddress.Text);
            FileInfo[] fileInfoList = dirInfo.GetFiles();

            //Predefined Filters
            if (radioRenamePredefinedFilter.Checked)
            {
                List<AppPreDefinedFilters> filtersList = Enum.GetValues<AppPreDefinedFilters>().ToList();
                AppPreDefinedFilters selectedFilter = filtersList.FirstOrDefault(e => e.GetName() == comboRenamePredefinedFilters.Text);
                List<string> stringList = selectedFilter.GetStringList();
                stringList.ForEach(e => RenameExecute(e, AppStrings.Empty));

                if (checkRenameFullArrange.Checked)
                {
                    //Not Implemented
                }
            }

            //Custom Filter
            if (radioRenameCustomFilter.Checked)
            {
                string oldText = txtRenameCustomFilterOriginalText.Text;
                string replaceText = txtRenameCustomFilterReplaceText.Text;
                if (checkRenameCustomFilterRemove.Checked)
                    replaceText = AppStrings.Empty;

                RenameExecute(oldText, replaceText);
            }

            return counter;

            void RenameExecute(string text, string newtext)
            {
                List<DirectoryInfo> dirList = new List<DirectoryInfo>();
                dirList.Add(dirInfo);
                if (checkRenameSubfolders.Checked && dirInfo.GetDirectories().Any())
                { 
                    for (int i = 0; i < dirList.Count; i++)
                        if (dirList[i].GetDirectories().Any())
                            dirList.AddRange(dirList[i].GetDirectories());
                }
                foreach (DirectoryInfo folder in dirList)
                foreach (FileInfo file in folder.GetFiles())
                    if (file.Name.Contains(text) &&
                        (AppConstants.SupportedFormatsVideo.Contains(file.Extension) || checkRenameAllFormats.Checked))
                    {
                        File.Move(file.FullName, file.FullName.Replace(text, newtext));
                        counter++;
                    }
            }
        }
        private int RunSubtitles()
        {
            int counter = 0;

            if (radioSubtitleMovie.Checked)
            {
                FileInfo fileSource = new FileInfo(txtSubtitleSource.Text);
                FileInfo fileSubtitle = new FileInfo(txtSubtitleSubtitle.Text);

                string folderName = AppStrings.Empty;
                string folderNameYear = AppStrings.Empty;

                //Detect MovieName
                foreach (char ch in fileSource.Name)
                {
                    if (ch != '_' && ch != '-')
                        folderName += ch;
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
                        folderNameYear = " (" + y.ToString() + ")";
                }

                string newFolderAddress = Path.Combine(txtSubtitleDestination.Text, folderName + folderNameYear);
                Directory.CreateDirectory(newFolderAddress);

                string nameMovie = Path.Combine(newFolderAddress, fileSource.Name);
                fileSource.MoveTo(nameMovie);

                string nameSubtitle = Path.Combine(newFolderAddress, fileSource.Name);
                nameSubtitle = nameSubtitle.Replace(fileSource.Extension, fileSubtitle.Extension);
                fileSubtitle.MoveTo(nameSubtitle);

                counter++;
            }
            else
            {
                DirectoryInfo dirInfoSource = new DirectoryInfo(txtSubtitleSource.Text);
                DirectoryInfo dirInfoSubtitle = new DirectoryInfo(txtSubtitleSubtitle.Text);
                FileInfo[] tempFileInfoSourceList = dirInfoSource.GetFiles();
                FileInfo[] tempFileInfoSubtitleList = dirInfoSubtitle.GetFiles();
                List<FileInfo> fileInfoSourceList = new List<FileInfo>();
                List<FileInfo> fileInfoSubtitleList = new List<FileInfo>();

                for (int z = 0; z < tempFileInfoSourceList.Length; z++)
                    if (AppConstants.SupportedFormatsVideo.Contains(tempFileInfoSourceList[z].Extension))
                        fileInfoSourceList.Add(tempFileInfoSourceList[z]);

                for (int z = 0; z < tempFileInfoSubtitleList.Length; z++)
                    if (AppConstants.SupportedFormatsSubtitle.Contains(tempFileInfoSubtitleList[z].Extension))
                        fileInfoSubtitleList.Add(tempFileInfoSubtitleList[z]);

                int i = 0;
                foreach (FileInfo file in fileInfoSourceList)
                {
                    string sourceName = file.Name;
                    file.MoveTo(Path.Combine(txtSubtitleDestination.Text, sourceName));

                    string subtitleName = Path.Combine(txtSubtitleDestination.Text, sourceName);
                    subtitleName = subtitleName.Replace(file.Extension, fileInfoSubtitleList[i].Extension);
                    fileInfoSubtitleList[i++].MoveTo(subtitleName);

                    counter++;
                }
            }

            return counter;
        }
        private int RunTools()
        {
            int counter = 0;
            int seasonsNumber = int.Parse(txtToolsCSFSeasonNumber.Text);
            DirectoryInfo dirInfo = new DirectoryInfo(txtToolsDestination.Text);

            if (radioToolsCSF.Checked)
            {
                for (int i = 1; i <= seasonsNumber; i++)
                {
                    string folderAddressSeasons = Path.Combine(txtToolsDestination.Text, AppStrings.Season + AppStrings.Space + i.ToString().PadLeft(2, '0'));
                    Directory.CreateDirectory(folderAddressSeasons);
                    counter++;
                }
                string folderAddressSubtitle = Path.Combine(txtToolsDestination.Text, AppStrings.Subtitles);
                Directory.CreateDirectory(folderAddressSubtitle);
                counter++;
            }

            else
            {
                List<DirectoryInfo> folders = dirInfo.GetDirectories().ToList();
                int folderCounter = 1;
                foreach (DirectoryInfo folder in folders)
                {
                    List<FileInfo> files = folder.GetFiles().ToList();
                    int fileCounter = 1;
                    foreach (FileInfo file in files)
                    {
                        if (AppConstants.SupportedFormatsVideo.Contains(file.Extension))
                        {
                            string oldFileName = file.Name;
                            string separator1 = txtToolsSFP1.Text is null or AppStrings.Empty ? AppStrings.Empty : "-";
                            string separator2 = txtToolsSFP2.Text is null or AppStrings.Empty ? AppStrings.Empty : "-";
                            string newFileName = $"{txtToolsSFP1.Text}{separator1}" +
                                                 $"{AppStrings.SeasonInitial}{folderCounter.ToString().PadLeft(2, '0')}" +
                                                 $"{AppStrings.EpisodeInitial}{fileCounter.ToString().PadLeft(2, '0')}" +
                                                 $"{separator2}{txtToolsSFP2.Text}" +
                                                 $"{file.Extension}";
                            File.Move(file.FullName, file.FullName.Replace(oldFileName, newFileName));
                            fileCounter++;
                            counter++;
                        }
                    }
                    string folderName = AppStrings.Season + AppStrings.Space + folderCounter++.ToString().PadLeft(2, '0');
                    if (folderName != folder.Name)
                        Directory.Move(folder.FullName, folder.FullName.Replace(folder.Name, folderName));
                }
            }

            return counter;
        }

        private void RunData()
        {
            Form? formdata = Application.OpenForms["FormData"];

            if (formdata == null)
            {
                Forms.FormData formData = new Forms.FormData(txtDataAddress.Text, checkDataSubFolders.Checked, checkDataSeriesList.Checked, checkDataMovieList.Checked);
                formData.Show();
            }
            else
            {
                formdata.BringToFront();
            }
            return;
        }
        
        private void RadioBox_CheckedChanged(object sender, EventArgs e)
        {
            // Nothing Selected
            boxNotSelected.Visible = !(radioRename.Checked || radioSubtitles.Checked || radioTools.Checked || radioData.Checked);
            boxRename.Visible = radioRename.Checked;
            boxSubtitle.Visible = radioSubtitles.Checked;
            boxTools.Visible = radioTools.Checked;
            boxData.Visible = radioData.Checked;

            // Box Rename
            boxRename.Enabled = boxRename.Visible;
            comboRenamePredefinedFilters.Enabled = !boxRename.Visible;
            checkRenameFullArrange.Enabled = !boxRename.Visible;
            txtRenameCustomFilterOriginalText.Enabled = !boxRename.Visible;
            txtRenameCustomFilterReplaceText.Enabled = !boxRename.Visible;
            checkRenameCustomFilterRemove.Enabled = !boxRename.Visible;
            radioRenamePredefinedFilter.Checked = !boxRename.Visible;
            radioRenameCustomFilter.Checked = !boxRename.Visible;
            RadioRename_CheckedChanged(sender, e);

            // Box Subtitles
            boxSubtitle.Enabled = boxSubtitle.Visible;
            boxSubtitleInner.Enabled = radioSubtitleMovie.Checked || radioSubtitleSeries.Checked;
            checkSameFolder.Enabled = radioSubtitleMovie.Checked || radioSubtitleSeries.Checked;
            radioSubtitleMovie.Checked = !boxSubtitle.Visible;
            radioSubtitleSeries.Checked = !boxSubtitle.Visible;
            RadioSubtitleBox_CheckedChanged(sender, e);

            //Box Tools
            boxTools.Enabled = boxTools.Visible;
            radioToolsCSF.Enabled = boxTools.Visible;
            radioToolsSFP.Enabled = boxTools.Visible;
            lblToolsCSFSeasonsNumber.Enabled = !boxTools.Visible;
            txtToolsCSFSeasonNumber.Enabled = !boxTools.Visible;
            btnToolsCSFSeasonNumberInc.Enabled = !boxTools.Visible;
            btnToolsCSFSeasonNumberDec.Enabled = !boxTools.Visible;
            txtToolsSFP1.Enabled = !boxTools.Visible;
            radioToolsCSF.Checked = !boxTools.Visible;
            radioToolsSFP.Checked = !boxTools.Visible;
            RadioToolsBox_CheckedChanged(sender, e);
            
            // Box Data
            boxData.Enabled = boxData.Visible;
            txtDataAddress.Enabled = boxData.Visible;
            checkDataSubFolders.Enabled = boxData.Visible;
            // RadioRename_CheckedChanged(sender, e);
        }
        private void RadioRename_CheckedChanged(object sender, EventArgs e)
        {
            comboRenamePredefinedFilters.Enabled = radioRenamePredefinedFilter.Checked;
            checkRenameFullArrange.Enabled = radioRenamePredefinedFilter.Checked;

            txtRenameCustomFilterOriginalText.Enabled = radioRenameCustomFilter.Checked;
            txtRenameCustomFilterReplaceText.Enabled = radioRenameCustomFilter.Checked;
            checkRenameCustomFilterRemove.Enabled = radioRenameCustomFilter.Checked;
            if (radioRenamePredefinedFilter.Checked)
                comboRenamePredefinedFilters.Hint = AppHints.Filter;
            else
                comboRenamePredefinedFilters.Hint = AppStrings.Empty;
            if (radioRenameCustomFilter.Checked)
            {
                txtRenameCustomFilterOriginalText.Hint = AppHints.OriginalText;
                txtRenameCustomFilterReplaceText.Hint = AppHints.ReplaceText;
            }
            else
            {
                txtRenameCustomFilterOriginalText.Hint = AppStrings.Empty;
                txtRenameCustomFilterReplaceText.Hint = AppStrings.Empty;
            }
        }
        private void RadioSubtitleBox_CheckedChanged(object sender, EventArgs e)
        {
            boxSubtitleInner.Enabled = radioSubtitleMovie.Checked || radioSubtitleSeries.Checked;
            txtSubtitleSource.Text = AppStrings.Empty;
            txtSubtitleSubtitle.Text = AppStrings.Empty;
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
                txtRenameCustomFilterReplaceText.Hint = AppStrings.Empty;
            else
                txtRenameCustomFilterReplaceText.Hint = AppHints.ReplaceText;
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
            if (!checkSameFolder.Checked) return;
            txtSubtitleSource.Text = txtSubtitleDestination.Text;
            txtSubtitleSubtitle.Text = txtSubtitleDestination.Text;
        }
        private void txtToolsCSFSeasonNumber_TextChanged(object sender, EventArgs e)
        {
            int seasonNumber = int.Parse(txtToolsCSFSeasonNumber.Text);
        }
        private void btnToolsCSFSeasonNumberInc_Click(object sender, EventArgs e)
        {
            int seasonNumber = int.Parse(txtToolsCSFSeasonNumber.Text);
            if (seasonNumber < 100)
            {
                txtToolsCSFSeasonNumber.Text = (++seasonNumber).ToString();
            }
        }
        private void btnToolsCSFSeasonNumberDec_Click(object sender, EventArgs e)
        {
            int seasonNumber = int.Parse(txtToolsCSFSeasonNumber.Text);
            if (seasonNumber > 0)
            {
                txtToolsCSFSeasonNumber.Text = (--seasonNumber).ToString();
            }

        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string BrowseFile()
            {
                //Browse File Dialog
                OpenFileDialog browseFileDialog = new OpenFileDialog();
                browseFileDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                browseFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                browseFileDialog.FilterIndex = 1;
                browseFileDialog.CheckFileExists = true;
                browseFileDialog.CheckPathExists = true;
                browseFileDialog.Multiselect = false;

                //Show Dialog
                browseFileDialog.ShowDialog();

                return browseFileDialog.FileName;
            }

            //Get ButtonName
            string buttonName = (sender as MaterialButton)!.Name;
            int index = buttonName.IndexOf(AppStrings.Browse, StringComparison.Ordinal);
            string textBoxName = buttonName.Substring(0, index);
            textBoxName = textBoxName.Replace("btn", "txt");
            Form? form = this.FindForm();
            Control textbox = form.Controls.Find(textBoxName, true)[0];

            string path = "";
            //Folder Or File Switch - True is Folder
            bool folderOrFile = true;

            //File Browse Situations
            if (radioSubtitleMovie.Checked)
            {
                if (textbox.Name == "txtSubtitleSource")
                    folderOrFile = false;
                if (textbox.Name == "txtSubtitleSubtitle")
                    folderOrFile = false;
            }

            //BrowseDialog
            if (folderOrFile)
                path = BrowseFolder();
            else
                path = BrowseFile();

            textbox.Text = path;
            return;

            string BrowseFolder()
            {
                //Browser Dialog
                FolderBrowserDialog browseFolderDialog = new FolderBrowserDialog();
                browseFolderDialog.ShowNewFolderButton = true;
                browseFolderDialog.RootFolder = Environment.SpecialFolder.Desktop;

                //Show Dialog
                browseFolderDialog.ShowDialog();

                return browseFolderDialog.SelectedPath;
            }
        }
        private void ControlDragDrop(object sender, EventArgs e)
        {
            string[] filePath = (string[])((DragEventArgs)e).Data.GetData(DataFormats.FileDrop, false);
            FileInfo file = new FileInfo(filePath[0]);
            string extension = file.Extension;

            //Get ButtonName
            MaterialTextBox textbox = (MaterialTextBox)sender;

            //Folder or File Switch - True is Folder
            bool folderOrFile = true;
            if (radioSubtitleMovie.Checked)
            {
                switch (textbox.Name)
                {
                    case "txtSubtitleSource": folderOrFile = false; break;
                    case "txtSubtitleSubtitle": folderOrFile = false; break;
                    default: break;
                }
            }

            if (folderOrFile)
            {
                if (extension != AppStrings.Empty)
                    //File Dropped
                    MessageBox.Show(AppStrings.MessageDragFolder);
                else
                    textbox.Text = filePath[0];
            }
            else
            {
                if (extension == "")
                    //Folder Dropped
                    MessageBox.Show(AppStrings.MessageDragFile);
                else
                    textbox.Text = filePath[0];
            }
        }
        private void SetTooltips()
        {
            ToolTip tt = new ToolTip();
            tt.UseFading = false;
            tt.UseAnimation = false;
            tt.Active = true;
            tt.ShowAlways = true;

            tt.SetToolTip(radioRename, AppToolTips.RadioRename);
            tt.SetToolTip(checkRenameFullArrange, AppToolTips.CheckRenameFullArrange);
            tt.SetToolTip(checkRenameCustomFilterRemove, AppToolTips.CheckRenameCustomFilterRemove);
            tt.SetToolTip(checkRenameAllFormats, AppToolTips.CheckRenameAllFormats);
            tt.SetToolTip(checkRenameSubfolders, AppToolTips.CheckRenameSubfolders);
            tt.SetToolTip(radioRenamePredefinedFilter, AppToolTips.RadioRenamePredefinedFilter);
            tt.SetToolTip(comboRenamePredefinedFilters, AppToolTips.ComboRenamePredefinedFilters);
            tt.SetToolTip(checkRenamePowerShell, AppToolTips.CheckRenamePowerShell);
            tt.SetToolTip(radioSubtitles, AppToolTips.RadioSubtitles);
            tt.SetToolTip(checkSameFolder, AppToolTips.CheckSameFolder);
            tt.SetToolTip(radioTools, AppToolTips.RadioTools);
            tt.SetToolTip(radioToolsCSF, AppToolTips.RadioToolsCsf);
            tt.SetToolTip(radioToolsSFP, AppToolTips.RadioToolsSfp);
            
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form? formabout = Application.OpenForms["FormAbout"];

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
            Form? formhelp = Application.OpenForms["FormHelp"];

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
            lblFooterStatus.Text = AppStrings.StatusExit;
            this.Close();          
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(AppStrings.MessageAreYouSure, AppStrings.ButtonTextExit, buttons: MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}