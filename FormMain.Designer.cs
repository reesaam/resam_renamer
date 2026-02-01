namespace ResamRenamer
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            boxRename = new System.Windows.Forms.GroupBox();
            checkRenameAllFormats = new MaterialSkin.Controls.MaterialCheckbox();
            checkRenamePowerShell = new MaterialSkin.Controls.MaterialCheckbox();
            checkRenameSubfolders = new MaterialSkin.Controls.MaterialCheckbox();
            checkRenameCustomFilterRemove = new MaterialSkin.Controls.MaterialCheckbox();
            txtRenameCustomFilterReplaceText = new MaterialSkin.Controls.MaterialTextBox();
            txtRenameCustomFilterOriginalText = new MaterialSkin.Controls.MaterialTextBox();
            checkRenameFullArrange = new MaterialSkin.Controls.MaterialCheckbox();
            comboRenamePredefinedFilters = new MaterialSkin.Controls.MaterialComboBox();
            txtRenameAddress = new MaterialSkin.Controls.MaterialTextBox();
            radioRenameCustomFilter = new MaterialSkin.Controls.MaterialRadioButton();
            radioRenamePredefinedFilter = new MaterialSkin.Controls.MaterialRadioButton();
            btnRenameAddressBrowse = new MaterialSkin.Controls.MaterialButton();
            lblRenameAddress = new MaterialSkin.Controls.MaterialLabel();
            boxSubtitle = new System.Windows.Forms.GroupBox();
            checkSameFolder = new MaterialSkin.Controls.MaterialCheckbox();
            boxSubtitleInner = new System.Windows.Forms.GroupBox();
            btnSubtitleSubtitleBrowse = new MaterialSkin.Controls.MaterialButton();
            btnSubtitleSourceBrowse = new MaterialSkin.Controls.MaterialButton();
            btnSubtitleDestinationBrowse = new MaterialSkin.Controls.MaterialButton();
            txtSubtitleSubtitle = new MaterialSkin.Controls.MaterialTextBox();
            txtSubtitleSource = new MaterialSkin.Controls.MaterialTextBox();
            lblSubtitleSubtitle = new MaterialSkin.Controls.MaterialLabel();
            lblSubtitleSource = new MaterialSkin.Controls.MaterialLabel();
            lblSubtitleDestination = new MaterialSkin.Controls.MaterialLabel();
            txtSubtitleDestination = new MaterialSkin.Controls.MaterialTextBox();
            radioSubtitleSeries = new MaterialSkin.Controls.MaterialRadioButton();
            radioSubtitleMovie = new MaterialSkin.Controls.MaterialRadioButton();
            btnRun = new MaterialSkin.Controls.MaterialButton();
            btnExit = new MaterialSkin.Controls.MaterialButton();
            btnAbout = new MaterialSkin.Controls.MaterialButton();
            boxFooter = new System.Windows.Forms.GroupBox();
            lblFooterStatus = new System.Windows.Forms.Label();
            lblFooterVersion = new System.Windows.Forms.Label();
            lblFooterVersionLabel = new System.Windows.Forms.Label();
            lblFooterStatusLabel = new System.Windows.Forms.Label();
            radioRename = new MaterialSkin.Controls.MaterialRadioButton();
            radioSubtitles = new MaterialSkin.Controls.MaterialRadioButton();
            radioTools = new MaterialSkin.Controls.MaterialRadioButton();
            boxTools = new System.Windows.Forms.GroupBox();
            txtToolsSFPE = new MaterialSkin.Controls.MaterialTextBox();
            txtToolsSFP2 = new MaterialSkin.Controls.MaterialTextBox();
            txtToolsSFPS = new MaterialSkin.Controls.MaterialTextBox();
            txtToolsSFP1 = new MaterialSkin.Controls.MaterialTextBox();
            btnToolsCSFSeasonNumberDec = new MaterialSkin.Controls.MaterialButton();
            btnToolsCSFSeasonNumberInc = new MaterialSkin.Controls.MaterialButton();
            lblToolsCSFSeasonsNumber = new MaterialSkin.Controls.MaterialLabel();
            txtToolsCSFSeasonNumber = new MaterialSkin.Controls.MaterialTextBox();
            btnToolsDestinationBrowse = new MaterialSkin.Controls.MaterialButton();
            radioToolsSFP = new MaterialSkin.Controls.MaterialRadioButton();
            radioToolsCSF = new MaterialSkin.Controls.MaterialRadioButton();
            lblToolsDestination = new MaterialSkin.Controls.MaterialLabel();
            txtToolsDestination = new MaterialSkin.Controls.MaterialTextBox();
            btnHelp = new MaterialSkin.Controls.MaterialButton();
            boxNotSelected = new System.Windows.Forms.GroupBox();
            panelLoading = new System.Windows.Forms.Panel();
            lblLoading = new System.Windows.Forms.Label();
            progressBar = new System.Windows.Forms.ProgressBar();
            lblNotSelected = new System.Windows.Forms.Label();
            radioData = new MaterialSkin.Controls.MaterialRadioButton();
            boxRename.SuspendLayout();
            boxSubtitle.SuspendLayout();
            boxSubtitleInner.SuspendLayout();
            boxFooter.SuspendLayout();
            boxTools.SuspendLayout();
            boxNotSelected.SuspendLayout();
            panelLoading.SuspendLayout();
            SuspendLayout();
            // 
            // boxRename
            // 
            boxRename.Controls.Add(checkRenameAllFormats);
            boxRename.Controls.Add(checkRenamePowerShell);
            boxRename.Controls.Add(checkRenameSubfolders);
            boxRename.Controls.Add(checkRenameCustomFilterRemove);
            boxRename.Controls.Add(txtRenameCustomFilterReplaceText);
            boxRename.Controls.Add(txtRenameCustomFilterOriginalText);
            boxRename.Controls.Add(checkRenameFullArrange);
            boxRename.Controls.Add(comboRenamePredefinedFilters);
            boxRename.Controls.Add(txtRenameAddress);
            boxRename.Controls.Add(radioRenameCustomFilter);
            boxRename.Controls.Add(radioRenamePredefinedFilter);
            boxRename.Controls.Add(btnRenameAddressBrowse);
            boxRename.Controls.Add(lblRenameAddress);
            boxRename.Controls.Add(boxNotSelected);
            boxRename.Location = new System.Drawing.Point(20, 140);
            boxRename.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            boxRename.Name = "boxRename";
            boxRename.Padding = new System.Windows.Forms.Padding(10);
            boxRename.Size = new System.Drawing.Size(960, 250);
            boxRename.TabIndex = 0;
            boxRename.TabStop = false;
            // 
            // checkRenameAllFormats
            // 
            checkRenameAllFormats.AutoSize = true;
            checkRenameAllFormats.Depth = 0;
            checkRenameAllFormats.Location = new System.Drawing.Point(182, 192);
            checkRenameAllFormats.Margin = new System.Windows.Forms.Padding(0);
            checkRenameAllFormats.MouseLocation = new System.Drawing.Point(-1, -1);
            checkRenameAllFormats.MouseState = MaterialSkin.MouseState.HOVER;
            checkRenameAllFormats.Name = "checkRenameAllFormats";
            checkRenameAllFormats.Ripple = true;
            checkRenameAllFormats.Size = new System.Drawing.Size(116, 37);
            checkRenameAllFormats.TabIndex = 15;
            checkRenameAllFormats.Text = "All Formats";
            checkRenameAllFormats.UseVisualStyleBackColor = true;
            // 
            // checkRenamePowerShell
            // 
            checkRenamePowerShell.AutoSize = true;
            checkRenamePowerShell.Depth = 0;
            checkRenamePowerShell.Location = new System.Drawing.Point(828, 192);
            checkRenamePowerShell.Margin = new System.Windows.Forms.Padding(0);
            checkRenamePowerShell.MouseLocation = new System.Drawing.Point(-1, -1);
            checkRenamePowerShell.MouseState = MaterialSkin.MouseState.HOVER;
            checkRenamePowerShell.Name = "checkRenamePowerShell";
            checkRenamePowerShell.Ripple = true;
            checkRenamePowerShell.Size = new System.Drawing.Size(114, 37);
            checkRenamePowerShell.TabIndex = 14;
            checkRenamePowerShell.Text = "PowerShell";
            checkRenamePowerShell.UseVisualStyleBackColor = true;
            // 
            // checkRenameSubfolders
            // 
            checkRenameSubfolders.AutoSize = true;
            checkRenameSubfolders.Depth = 0;
            checkRenameSubfolders.Location = new System.Drawing.Point(323, 192);
            checkRenameSubfolders.Margin = new System.Windows.Forms.Padding(0);
            checkRenameSubfolders.MouseLocation = new System.Drawing.Point(-1, -1);
            checkRenameSubfolders.MouseState = MaterialSkin.MouseState.HOVER;
            checkRenameSubfolders.Name = "checkRenameSubfolders";
            checkRenameSubfolders.Ripple = true;
            checkRenameSubfolders.Size = new System.Drawing.Size(112, 37);
            checkRenameSubfolders.TabIndex = 13;
            checkRenameSubfolders.Text = "Subfolders";
            checkRenameSubfolders.UseVisualStyleBackColor = true;
            // 
            // checkRenameCustomFilterRemove
            // 
            checkRenameCustomFilterRemove.AutoSize = true;
            checkRenameCustomFilterRemove.Depth = 0;
            checkRenameCustomFilterRemove.Location = new System.Drawing.Point(853, 125);
            checkRenameCustomFilterRemove.Margin = new System.Windows.Forms.Padding(0);
            checkRenameCustomFilterRemove.MouseLocation = new System.Drawing.Point(-1, -1);
            checkRenameCustomFilterRemove.MouseState = MaterialSkin.MouseState.HOVER;
            checkRenameCustomFilterRemove.Name = "checkRenameCustomFilterRemove";
            checkRenameCustomFilterRemove.Ripple = true;
            checkRenameCustomFilterRemove.Size = new System.Drawing.Size(92, 37);
            checkRenameCustomFilterRemove.TabIndex = 12;
            checkRenameCustomFilterRemove.Text = "Remove";
            checkRenameCustomFilterRemove.UseVisualStyleBackColor = true;
            checkRenameCustomFilterRemove.CheckedChanged += checkRenameCustomFilterRemove_CheckedChanged;
            // 
            // txtRenameCustomFilterReplaceText
            // 
            txtRenameCustomFilterReplaceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtRenameCustomFilterReplaceText.Depth = 0;
            txtRenameCustomFilterReplaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtRenameCustomFilterReplaceText.Location = new System.Drawing.Point(528, 125);
            txtRenameCustomFilterReplaceText.MaxLength = 50;
            txtRenameCustomFilterReplaceText.MouseState = MaterialSkin.MouseState.OUT;
            txtRenameCustomFilterReplaceText.Multiline = false;
            txtRenameCustomFilterReplaceText.Name = "txtRenameCustomFilterReplaceText";
            txtRenameCustomFilterReplaceText.Size = new System.Drawing.Size(312, 36);
            txtRenameCustomFilterReplaceText.TabIndex = 11;
            txtRenameCustomFilterReplaceText.Text = "";
            txtRenameCustomFilterReplaceText.UseTallSize = false;
            // 
            // txtRenameCustomFilterOriginalText
            // 
            txtRenameCustomFilterOriginalText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtRenameCustomFilterOriginalText.Depth = 0;
            txtRenameCustomFilterOriginalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtRenameCustomFilterOriginalText.Location = new System.Drawing.Point(182, 125);
            txtRenameCustomFilterOriginalText.MaxLength = 50;
            txtRenameCustomFilterOriginalText.MouseState = MaterialSkin.MouseState.OUT;
            txtRenameCustomFilterOriginalText.Multiline = false;
            txtRenameCustomFilterOriginalText.Name = "txtRenameCustomFilterOriginalText";
            txtRenameCustomFilterOriginalText.Size = new System.Drawing.Size(333, 36);
            txtRenameCustomFilterOriginalText.TabIndex = 10;
            txtRenameCustomFilterOriginalText.Text = "";
            txtRenameCustomFilterOriginalText.UseTallSize = false;
            // 
            // checkRenameFullArrange
            // 
            checkRenameFullArrange.AutoSize = true;
            checkRenameFullArrange.Depth = 0;
            checkRenameFullArrange.Location = new System.Drawing.Point(528, 79);
            checkRenameFullArrange.Margin = new System.Windows.Forms.Padding(0);
            checkRenameFullArrange.MouseLocation = new System.Drawing.Point(-1, -1);
            checkRenameFullArrange.MouseState = MaterialSkin.MouseState.HOVER;
            checkRenameFullArrange.Name = "checkRenameFullArrange";
            checkRenameFullArrange.Ripple = true;
            checkRenameFullArrange.Size = new System.Drawing.Size(115, 37);
            checkRenameFullArrange.TabIndex = 9;
            checkRenameFullArrange.Text = "Full Arange";
            checkRenameFullArrange.UseVisualStyleBackColor = true;
            // 
            // comboRenamePredefinedFilters
            // 
            comboRenamePredefinedFilters.AutoResize = false;
            comboRenamePredefinedFilters.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            comboRenamePredefinedFilters.Depth = 0;
            comboRenamePredefinedFilters.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            comboRenamePredefinedFilters.DropDownHeight = 118;
            comboRenamePredefinedFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboRenamePredefinedFilters.DropDownWidth = 121;
            comboRenamePredefinedFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            comboRenamePredefinedFilters.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            comboRenamePredefinedFilters.FormattingEnabled = true;
            comboRenamePredefinedFilters.IntegralHeight = false;
            comboRenamePredefinedFilters.ItemHeight = 29;
            comboRenamePredefinedFilters.Location = new System.Drawing.Point(182, 80);
            comboRenamePredefinedFilters.Margin = new System.Windows.Forms.Padding(10);
            comboRenamePredefinedFilters.MaxDropDownItems = 4;
            comboRenamePredefinedFilters.MouseState = MaterialSkin.MouseState.OUT;
            comboRenamePredefinedFilters.Name = "comboRenamePredefinedFilters";
            comboRenamePredefinedFilters.Size = new System.Drawing.Size(333, 35);
            comboRenamePredefinedFilters.StartIndex = 0;
            comboRenamePredefinedFilters.TabIndex = 8;
            comboRenamePredefinedFilters.UseAccent = false;
            comboRenamePredefinedFilters.UseTallSize = false;
            // 
            // txtRenameAddress
            // 
            txtRenameAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtRenameAddress.Depth = 0;
            txtRenameAddress.DetectUrls = false;
            txtRenameAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtRenameAddress.Location = new System.Drawing.Point(119, 24);
            txtRenameAddress.MaxLength = 200;
            txtRenameAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtRenameAddress.Multiline = false;
            txtRenameAddress.Name = "txtRenameAddress";
            txtRenameAddress.ShowSelectionMargin = true;
            txtRenameAddress.Size = new System.Drawing.Size(728, 36);
            txtRenameAddress.TabIndex = 4;
            txtRenameAddress.Text = "";
            txtRenameAddress.UseTallSize = false;
            // 
            // radioRenameCustomFilter
            // 
            radioRenameCustomFilter.AutoSize = true;
            radioRenameCustomFilter.Depth = 0;
            radioRenameCustomFilter.Location = new System.Drawing.Point(10, 125);
            radioRenameCustomFilter.Margin = new System.Windows.Forms.Padding(0);
            radioRenameCustomFilter.MouseLocation = new System.Drawing.Point(-1, -1);
            radioRenameCustomFilter.MouseState = MaterialSkin.MouseState.HOVER;
            radioRenameCustomFilter.Name = "radioRenameCustomFilter";
            radioRenameCustomFilter.Ripple = true;
            radioRenameCustomFilter.Size = new System.Drawing.Size(133, 37);
            radioRenameCustomFilter.TabIndex = 7;
            radioRenameCustomFilter.TabStop = true;
            radioRenameCustomFilter.Text = "Custom Filter:";
            radioRenameCustomFilter.UseVisualStyleBackColor = true;
            radioRenameCustomFilter.CheckedChanged += RadioRename_CheckedChanged;
            // 
            // radioRenamePredefinedFilter
            // 
            radioRenamePredefinedFilter.AutoSize = true;
            radioRenamePredefinedFilter.Depth = 0;
            radioRenamePredefinedFilter.Location = new System.Drawing.Point(10, 79);
            radioRenamePredefinedFilter.Margin = new System.Windows.Forms.Padding(0);
            radioRenamePredefinedFilter.MouseLocation = new System.Drawing.Point(-1, -1);
            radioRenamePredefinedFilter.MouseState = MaterialSkin.MouseState.HOVER;
            radioRenamePredefinedFilter.Name = "radioRenamePredefinedFilter";
            radioRenamePredefinedFilter.Ripple = true;
            radioRenamePredefinedFilter.Size = new System.Drawing.Size(162, 37);
            radioRenamePredefinedFilter.TabIndex = 6;
            radioRenamePredefinedFilter.TabStop = true;
            radioRenamePredefinedFilter.Text = "Predefined Filters:";
            radioRenamePredefinedFilter.UseVisualStyleBackColor = true;
            radioRenamePredefinedFilter.CheckedChanged += RadioRename_CheckedChanged;
            // 
            // btnRenameAddressBrowse
            // 
            btnRenameAddressBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnRenameAddressBrowse.Depth = 0;
            btnRenameAddressBrowse.DrawShadows = true;
            btnRenameAddressBrowse.HighEmphasis = true;
            btnRenameAddressBrowse.Icon = null;
            btnRenameAddressBrowse.Location = new System.Drawing.Point(854, 24);
            btnRenameAddressBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnRenameAddressBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            btnRenameAddressBrowse.Name = "btnRenameAddressBrowse";
            btnRenameAddressBrowse.Size = new System.Drawing.Size(92, 36);
            btnRenameAddressBrowse.TabIndex = 5;
            btnRenameAddressBrowse.Text = "Browse...";
            btnRenameAddressBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnRenameAddressBrowse.UseAccentColor = false;
            btnRenameAddressBrowse.UseVisualStyleBackColor = true;
            btnRenameAddressBrowse.Click += btnBrowse_Click;
            // 
            // lblRenameAddress
            // 
            lblRenameAddress.AutoSize = true;
            lblRenameAddress.Depth = 0;
            lblRenameAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblRenameAddress.Location = new System.Drawing.Point(24, 34);
            lblRenameAddress.Margin = new System.Windows.Forms.Padding(5);
            lblRenameAddress.MouseState = MaterialSkin.MouseState.HOVER;
            lblRenameAddress.Name = "lblRenameAddress";
            lblRenameAddress.Size = new System.Drawing.Size(62, 19);
            lblRenameAddress.TabIndex = 0;
            lblRenameAddress.Text = "Address:";
            // 
            // boxSubtitle
            // 
            boxSubtitle.Controls.Add(checkSameFolder);
            boxSubtitle.Controls.Add(boxSubtitleInner);
            boxSubtitle.Controls.Add(radioSubtitleSeries);
            boxSubtitle.Controls.Add(radioSubtitleMovie);
            boxSubtitle.Location = new System.Drawing.Point(20, 140);
            boxSubtitle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            boxSubtitle.Name = "boxSubtitle";
            boxSubtitle.Padding = new System.Windows.Forms.Padding(5);
            boxSubtitle.Size = new System.Drawing.Size(960, 250);
            boxSubtitle.TabIndex = 2;
            boxSubtitle.TabStop = false;
            // 
            // checkSameFolder
            // 
            checkSameFolder.AutoSize = true;
            checkSameFolder.Depth = 0;
            checkSameFolder.Location = new System.Drawing.Point(220, 203);
            checkSameFolder.Margin = new System.Windows.Forms.Padding(0);
            checkSameFolder.MouseLocation = new System.Drawing.Point(-1, -1);
            checkSameFolder.MouseState = MaterialSkin.MouseState.HOVER;
            checkSameFolder.Name = "checkSameFolder";
            checkSameFolder.Ripple = true;
            checkSameFolder.Size = new System.Drawing.Size(163, 37);
            checkSameFolder.TabIndex = 23;
            checkSameFolder.Text = "All in Same Folder";
            checkSameFolder.UseVisualStyleBackColor = true;
            checkSameFolder.CheckedChanged += checkSameFolder_CheckedChanged;
            // 
            // boxSubtitleInner
            // 
            boxSubtitleInner.Controls.Add(btnSubtitleSubtitleBrowse);
            boxSubtitleInner.Controls.Add(btnSubtitleSourceBrowse);
            boxSubtitleInner.Controls.Add(btnSubtitleDestinationBrowse);
            boxSubtitleInner.Controls.Add(txtSubtitleSubtitle);
            boxSubtitleInner.Controls.Add(txtSubtitleSource);
            boxSubtitleInner.Controls.Add(lblSubtitleSubtitle);
            boxSubtitleInner.Controls.Add(lblSubtitleSource);
            boxSubtitleInner.Controls.Add(lblSubtitleDestination);
            boxSubtitleInner.Controls.Add(txtSubtitleDestination);
            boxSubtitleInner.Location = new System.Drawing.Point(110, 18);
            boxSubtitleInner.Name = "boxSubtitleInner";
            boxSubtitleInner.Size = new System.Drawing.Size(842, 176);
            boxSubtitleInner.TabIndex = 2;
            boxSubtitleInner.TabStop = false;
            // 
            // btnSubtitleSubtitleBrowse
            // 
            btnSubtitleSubtitleBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSubtitleSubtitleBrowse.Depth = 0;
            btnSubtitleSubtitleBrowse.DrawShadows = true;
            btnSubtitleSubtitleBrowse.HighEmphasis = true;
            btnSubtitleSubtitleBrowse.Icon = null;
            btnSubtitleSubtitleBrowse.Location = new System.Drawing.Point(729, 118);
            btnSubtitleSubtitleBrowse.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            btnSubtitleSubtitleBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            btnSubtitleSubtitleBrowse.Name = "btnSubtitleSubtitleBrowse";
            btnSubtitleSubtitleBrowse.Size = new System.Drawing.Size(92, 36);
            btnSubtitleSubtitleBrowse.TabIndex = 22;
            btnSubtitleSubtitleBrowse.Text = "Browse...";
            btnSubtitleSubtitleBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnSubtitleSubtitleBrowse.UseAccentColor = false;
            btnSubtitleSubtitleBrowse.UseVisualStyleBackColor = true;
            btnSubtitleSubtitleBrowse.Click += btnBrowse_Click;
            // 
            // btnSubtitleSourceBrowse
            // 
            btnSubtitleSourceBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSubtitleSourceBrowse.Depth = 0;
            btnSubtitleSourceBrowse.DrawShadows = true;
            btnSubtitleSourceBrowse.HighEmphasis = true;
            btnSubtitleSourceBrowse.Icon = null;
            btnSubtitleSourceBrowse.Location = new System.Drawing.Point(729, 70);
            btnSubtitleSourceBrowse.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            btnSubtitleSourceBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            btnSubtitleSourceBrowse.Name = "btnSubtitleSourceBrowse";
            btnSubtitleSourceBrowse.Size = new System.Drawing.Size(92, 36);
            btnSubtitleSourceBrowse.TabIndex = 20;
            btnSubtitleSourceBrowse.Text = "Browse...";
            btnSubtitleSourceBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnSubtitleSourceBrowse.UseAccentColor = false;
            btnSubtitleSourceBrowse.UseVisualStyleBackColor = true;
            btnSubtitleSourceBrowse.Click += btnBrowse_Click;
            // 
            // btnSubtitleDestinationBrowse
            // 
            btnSubtitleDestinationBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSubtitleDestinationBrowse.Depth = 0;
            btnSubtitleDestinationBrowse.DrawShadows = true;
            btnSubtitleDestinationBrowse.HighEmphasis = true;
            btnSubtitleDestinationBrowse.Icon = null;
            btnSubtitleDestinationBrowse.Location = new System.Drawing.Point(729, 22);
            btnSubtitleDestinationBrowse.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            btnSubtitleDestinationBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            btnSubtitleDestinationBrowse.Name = "btnSubtitleDestinationBrowse";
            btnSubtitleDestinationBrowse.Size = new System.Drawing.Size(92, 36);
            btnSubtitleDestinationBrowse.TabIndex = 18;
            btnSubtitleDestinationBrowse.Text = "Browse...";
            btnSubtitleDestinationBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnSubtitleDestinationBrowse.UseAccentColor = false;
            btnSubtitleDestinationBrowse.UseVisualStyleBackColor = true;
            btnSubtitleDestinationBrowse.Click += btnBrowse_Click;
            // 
            // txtSubtitleSubtitle
            // 
            txtSubtitleSubtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSubtitleSubtitle.Depth = 0;
            txtSubtitleSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtSubtitleSubtitle.Location = new System.Drawing.Point(110, 119);
            txtSubtitleSubtitle.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            txtSubtitleSubtitle.MaxLength = 200;
            txtSubtitleSubtitle.MouseState = MaterialSkin.MouseState.OUT;
            txtSubtitleSubtitle.Multiline = false;
            txtSubtitleSubtitle.Name = "txtSubtitleSubtitle";
            txtSubtitleSubtitle.Size = new System.Drawing.Size(606, 36);
            txtSubtitleSubtitle.TabIndex = 21;
            txtSubtitleSubtitle.Text = "";
            txtSubtitleSubtitle.UseTallSize = false;
            // 
            // txtSubtitleSource
            // 
            txtSubtitleSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSubtitleSource.Depth = 0;
            txtSubtitleSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtSubtitleSource.Location = new System.Drawing.Point(110, 71);
            txtSubtitleSource.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            txtSubtitleSource.MaxLength = 200;
            txtSubtitleSource.MouseState = MaterialSkin.MouseState.OUT;
            txtSubtitleSource.Multiline = false;
            txtSubtitleSource.Name = "txtSubtitleSource";
            txtSubtitleSource.Size = new System.Drawing.Size(606, 36);
            txtSubtitleSource.TabIndex = 19;
            txtSubtitleSource.Text = "";
            txtSubtitleSource.UseTallSize = false;
            // 
            // lblSubtitleSubtitle
            // 
            lblSubtitleSubtitle.AutoSize = true;
            lblSubtitleSubtitle.Depth = 0;
            lblSubtitleSubtitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblSubtitleSubtitle.Location = new System.Drawing.Point(36, 128);
            lblSubtitleSubtitle.Margin = new System.Windows.Forms.Padding(5);
            lblSubtitleSubtitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblSubtitleSubtitle.Name = "lblSubtitleSubtitle";
            lblSubtitleSubtitle.Size = new System.Drawing.Size(59, 19);
            lblSubtitleSubtitle.TabIndex = 0;
            lblSubtitleSubtitle.Text = "Subtitle:";
            // 
            // lblSubtitleSource
            // 
            lblSubtitleSource.AutoSize = true;
            lblSubtitleSource.Depth = 0;
            lblSubtitleSource.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblSubtitleSource.Location = new System.Drawing.Point(41, 80);
            lblSubtitleSource.Margin = new System.Windows.Forms.Padding(5);
            lblSubtitleSource.MouseState = MaterialSkin.MouseState.HOVER;
            lblSubtitleSource.Name = "lblSubtitleSource";
            lblSubtitleSource.Size = new System.Drawing.Size(54, 19);
            lblSubtitleSource.TabIndex = 0;
            lblSubtitleSource.Text = "Source:";
            // 
            // lblSubtitleDestination
            // 
            lblSubtitleDestination.AutoSize = true;
            lblSubtitleDestination.Depth = 0;
            lblSubtitleDestination.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblSubtitleDestination.Location = new System.Drawing.Point(9, 30);
            lblSubtitleDestination.Margin = new System.Windows.Forms.Padding(5);
            lblSubtitleDestination.MouseState = MaterialSkin.MouseState.HOVER;
            lblSubtitleDestination.Name = "lblSubtitleDestination";
            lblSubtitleDestination.Size = new System.Drawing.Size(86, 19);
            lblSubtitleDestination.TabIndex = 0;
            lblSubtitleDestination.Text = "Destination:";
            // 
            // txtSubtitleDestination
            // 
            txtSubtitleDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSubtitleDestination.Depth = 0;
            txtSubtitleDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtSubtitleDestination.Location = new System.Drawing.Point(110, 23);
            txtSubtitleDestination.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            txtSubtitleDestination.MaxLength = 200;
            txtSubtitleDestination.MouseState = MaterialSkin.MouseState.OUT;
            txtSubtitleDestination.Multiline = false;
            txtSubtitleDestination.Name = "txtSubtitleDestination";
            txtSubtitleDestination.Size = new System.Drawing.Size(606, 36);
            txtSubtitleDestination.TabIndex = 17;
            txtSubtitleDestination.Text = "";
            txtSubtitleDestination.UseTallSize = false;
            txtSubtitleDestination.TextChanged += txtSubtitleDestination_TextChanged;
            // 
            // radioSubtitleSeries
            // 
            radioSubtitleSeries.AutoSize = true;
            radioSubtitleSeries.Depth = 0;
            radioSubtitleSeries.Location = new System.Drawing.Point(15, 87);
            radioSubtitleSeries.Margin = new System.Windows.Forms.Padding(0);
            radioSubtitleSeries.MouseLocation = new System.Drawing.Point(-1, -1);
            radioSubtitleSeries.MouseState = MaterialSkin.MouseState.HOVER;
            radioSubtitleSeries.Name = "radioSubtitleSeries";
            radioSubtitleSeries.Ripple = true;
            radioSubtitleSeries.Size = new System.Drawing.Size(78, 37);
            radioSubtitleSeries.TabIndex = 16;
            radioSubtitleSeries.TabStop = true;
            radioSubtitleSeries.Text = "Series";
            radioSubtitleSeries.UseVisualStyleBackColor = true;
            radioSubtitleSeries.CheckedChanged += RadioSubtitleBox_CheckedChanged;
            // 
            // radioSubtitleMovie
            // 
            radioSubtitleMovie.AutoSize = true;
            radioSubtitleMovie.Depth = 0;
            radioSubtitleMovie.Location = new System.Drawing.Point(15, 40);
            radioSubtitleMovie.Margin = new System.Windows.Forms.Padding(0);
            radioSubtitleMovie.MouseLocation = new System.Drawing.Point(-1, -1);
            radioSubtitleMovie.MouseState = MaterialSkin.MouseState.HOVER;
            radioSubtitleMovie.Name = "radioSubtitleMovie";
            radioSubtitleMovie.Ripple = true;
            radioSubtitleMovie.Size = new System.Drawing.Size(78, 37);
            radioSubtitleMovie.TabIndex = 15;
            radioSubtitleMovie.TabStop = true;
            radioSubtitleMovie.Text = "Movie";
            radioSubtitleMovie.UseVisualStyleBackColor = true;
            radioSubtitleMovie.CheckedChanged += RadioSubtitleBox_CheckedChanged;
            // 
            // btnRun
            // 
            btnRun.AutoSize = false;
            btnRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnRun.Depth = 0;
            btnRun.DrawShadows = true;
            btnRun.HighEmphasis = true;
            btnRun.Icon = null;
            btnRun.Location = new System.Drawing.Point(21, 410);
            btnRun.Margin = new System.Windows.Forms.Padding(10);
            btnRun.MouseState = MaterialSkin.MouseState.HOVER;
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(100, 35);
            btnRun.TabIndex = 50;
            btnRun.Text = "Run";
            btnRun.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRun.UseAccentColor = false;
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = false;
            btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnExit.Depth = 0;
            btnExit.DrawShadows = true;
            btnExit.HighEmphasis = true;
            btnExit.Icon = null;
            btnExit.Location = new System.Drawing.Point(878, 410);
            btnExit.Margin = new System.Windows.Forms.Padding(10);
            btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(100, 35);
            btnExit.TabIndex = 52;
            btnExit.Text = "Exit";
            btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExit.UseAccentColor = false;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAbout
            // 
            btnAbout.AutoSize = false;
            btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnAbout.Depth = 0;
            btnAbout.DrawShadows = true;
            btnAbout.HighEmphasis = true;
            btnAbout.Icon = null;
            btnAbout.Location = new System.Drawing.Point(758, 410);
            btnAbout.Margin = new System.Windows.Forms.Padding(10);
            btnAbout.MouseState = MaterialSkin.MouseState.HOVER;
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new System.Drawing.Size(100, 35);
            btnAbout.TabIndex = 1;
            btnAbout.Text = "About";
            btnAbout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAbout.UseAccentColor = false;
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // boxFooter
            // 
            boxFooter.Controls.Add(lblFooterStatus);
            boxFooter.Controls.Add(lblFooterVersion);
            boxFooter.Controls.Add(lblFooterVersionLabel);
            boxFooter.Controls.Add(lblFooterStatusLabel);
            boxFooter.Location = new System.Drawing.Point(0, 455);
            boxFooter.Margin = new System.Windows.Forms.Padding(0);
            boxFooter.Name = "boxFooter";
            boxFooter.Size = new System.Drawing.Size(1000, 45);
            boxFooter.TabIndex = 7;
            boxFooter.TabStop = false;
            // 
            // lblFooterStatus
            // 
            lblFooterStatus.AutoSize = true;
            lblFooterStatus.Location = new System.Drawing.Point(74, 18);
            lblFooterStatus.Name = "lblFooterStatus";
            lblFooterStatus.Size = new System.Drawing.Size(39, 15);
            lblFooterStatus.TabIndex = 0;
            lblFooterStatus.Text = "Status";
            // 
            // lblFooterVersion
            // 
            lblFooterVersion.AutoSize = true;
            lblFooterVersion.Location = new System.Drawing.Point(937, 18);
            lblFooterVersion.Name = "lblFooterVersion";
            lblFooterVersion.Size = new System.Drawing.Size(31, 15);
            lblFooterVersion.TabIndex = 0;
            lblFooterVersion.Text = "0.0.0";
            // 
            // lblFooterVersionLabel
            // 
            lblFooterVersionLabel.AutoSize = true;
            lblFooterVersionLabel.Location = new System.Drawing.Point(877, 18);
            lblFooterVersionLabel.Name = "lblFooterVersionLabel";
            lblFooterVersionLabel.Size = new System.Drawing.Size(48, 15);
            lblFooterVersionLabel.TabIndex = 0;
            lblFooterVersionLabel.Text = "Version:";
            // 
            // lblFooterStatusLabel
            // 
            lblFooterStatusLabel.AutoSize = true;
            lblFooterStatusLabel.Location = new System.Drawing.Point(24, 18);
            lblFooterStatusLabel.Name = "lblFooterStatusLabel";
            lblFooterStatusLabel.Size = new System.Drawing.Size(42, 15);
            lblFooterStatusLabel.TabIndex = 0;
            lblFooterStatusLabel.Text = "Status:";
            // 
            // radioRename
            // 
            radioRename.AutoSize = true;
            radioRename.Depth = 0;
            radioRename.Location = new System.Drawing.Point(13, 84);
            radioRename.Margin = new System.Windows.Forms.Padding(0);
            radioRename.MouseLocation = new System.Drawing.Point(-1, -1);
            radioRename.MouseState = MaterialSkin.MouseState.HOVER;
            radioRename.Name = "radioRename";
            radioRename.Ripple = true;
            radioRename.Size = new System.Drawing.Size(93, 37);
            radioRename.TabIndex = 2;
            radioRename.TabStop = true;
            radioRename.Text = "Rename";
            radioRename.UseVisualStyleBackColor = true;
            radioRename.CheckedChanged += RadioBox_CheckedChanged;
            // 
            // radioSubtitles
            // 
            radioSubtitles.AutoSize = true;
            radioSubtitles.Depth = 0;
            radioSubtitles.Location = new System.Drawing.Point(152, 84);
            radioSubtitles.Margin = new System.Windows.Forms.Padding(0);
            radioSubtitles.MouseLocation = new System.Drawing.Point(-1, -1);
            radioSubtitles.MouseState = MaterialSkin.MouseState.HOVER;
            radioSubtitles.Name = "radioSubtitles";
            radioSubtitles.Ripple = true;
            radioSubtitles.Size = new System.Drawing.Size(97, 37);
            radioSubtitles.TabIndex = 3;
            radioSubtitles.TabStop = true;
            radioSubtitles.Text = "Subtitles";
            radioSubtitles.UseVisualStyleBackColor = true;
            radioSubtitles.CheckedChanged += RadioBox_CheckedChanged;
            // 
            // radioTools
            // 
            radioTools.AutoSize = true;
            radioTools.Depth = 0;
            radioTools.Location = new System.Drawing.Point(295, 84);
            radioTools.Margin = new System.Windows.Forms.Padding(0);
            radioTools.MouseLocation = new System.Drawing.Point(-1, -1);
            radioTools.MouseState = MaterialSkin.MouseState.HOVER;
            radioTools.Name = "radioTools";
            radioTools.Ripple = true;
            radioTools.Size = new System.Drawing.Size(75, 37);
            radioTools.TabIndex = 3;
            radioTools.TabStop = true;
            radioTools.Text = "Tools";
            radioTools.UseVisualStyleBackColor = true;
            radioTools.CheckedChanged += RadioBox_CheckedChanged;
            // 
            // boxTools
            // 
            boxTools.Controls.Add(txtToolsSFPE);
            boxTools.Controls.Add(txtToolsSFP2);
            boxTools.Controls.Add(txtToolsSFPS);
            boxTools.Controls.Add(txtToolsSFP1);
            boxTools.Controls.Add(btnToolsCSFSeasonNumberDec);
            boxTools.Controls.Add(btnToolsCSFSeasonNumberInc);
            boxTools.Controls.Add(lblToolsCSFSeasonsNumber);
            boxTools.Controls.Add(txtToolsCSFSeasonNumber);
            boxTools.Controls.Add(btnToolsDestinationBrowse);
            boxTools.Controls.Add(radioToolsSFP);
            boxTools.Controls.Add(radioToolsCSF);
            boxTools.Controls.Add(lblToolsDestination);
            boxTools.Controls.Add(txtToolsDestination);
            boxTools.Location = new System.Drawing.Point(20, 140);
            boxTools.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            boxTools.Name = "boxTools";
            boxTools.Padding = new System.Windows.Forms.Padding(5);
            boxTools.Size = new System.Drawing.Size(960, 250);
            boxTools.TabIndex = 10;
            boxTools.TabStop = false;
            // 
            // txtToolsSFPE
            // 
            txtToolsSFPE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtToolsSFPE.Depth = 0;
            txtToolsSFPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtToolsSFPE.Location = new System.Drawing.Point(667, 172);
            txtToolsSFPE.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            txtToolsSFPE.MaxLength = 200;
            txtToolsSFPE.MouseState = MaterialSkin.MouseState.OUT;
            txtToolsSFPE.Multiline = false;
            txtToolsSFPE.Name = "txtToolsSFPE";
            txtToolsSFPE.ReadOnly = true;
            txtToolsSFPE.Size = new System.Drawing.Size(48, 36);
            txtToolsSFPE.TabIndex = 22;
            txtToolsSFPE.Text = "E#";
            txtToolsSFPE.UseTallSize = false;
            // 
            // txtToolsSFP2
            // 
            txtToolsSFP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtToolsSFP2.Depth = 0;
            txtToolsSFP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtToolsSFP2.Location = new System.Drawing.Point(727, 172);
            txtToolsSFP2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            txtToolsSFP2.MaxLength = 200;
            txtToolsSFP2.MouseState = MaterialSkin.MouseState.OUT;
            txtToolsSFP2.Multiline = false;
            txtToolsSFP2.Name = "txtToolsSFP2";
            txtToolsSFP2.Size = new System.Drawing.Size(218, 36);
            txtToolsSFP2.TabIndex = 32;
            txtToolsSFP2.Text = "";
            txtToolsSFP2.UseTallSize = false;
            // 
            // txtToolsSFPS
            // 
            txtToolsSFPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtToolsSFPS.Depth = 0;
            txtToolsSFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtToolsSFPS.Location = new System.Drawing.Point(606, 172);
            txtToolsSFPS.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            txtToolsSFPS.MaxLength = 200;
            txtToolsSFPS.MouseState = MaterialSkin.MouseState.OUT;
            txtToolsSFPS.Multiline = false;
            txtToolsSFPS.Name = "txtToolsSFPS";
            txtToolsSFPS.ReadOnly = true;
            txtToolsSFPS.Size = new System.Drawing.Size(48, 36);
            txtToolsSFPS.TabIndex = 18;
            txtToolsSFPS.Text = "S#";
            txtToolsSFPS.UseTallSize = false;
            // 
            // txtToolsSFP1
            // 
            txtToolsSFP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtToolsSFP1.Depth = 0;
            txtToolsSFP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtToolsSFP1.Location = new System.Drawing.Point(345, 173);
            txtToolsSFP1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            txtToolsSFP1.MaxLength = 200;
            txtToolsSFP1.MouseState = MaterialSkin.MouseState.OUT;
            txtToolsSFP1.Multiline = false;
            txtToolsSFP1.Name = "txtToolsSFP1";
            txtToolsSFP1.Size = new System.Drawing.Size(248, 36);
            txtToolsSFP1.TabIndex = 31;
            txtToolsSFP1.Text = "";
            txtToolsSFP1.UseTallSize = false;
            // 
            // btnToolsCSFSeasonNumberDec
            // 
            btnToolsCSFSeasonNumberDec.AutoSize = false;
            btnToolsCSFSeasonNumberDec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnToolsCSFSeasonNumberDec.Depth = 0;
            btnToolsCSFSeasonNumberDec.DrawShadows = true;
            btnToolsCSFSeasonNumberDec.HighEmphasis = true;
            btnToolsCSFSeasonNumberDec.Icon = null;
            btnToolsCSFSeasonNumberDec.Location = new System.Drawing.Point(925, 116);
            btnToolsCSFSeasonNumberDec.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnToolsCSFSeasonNumberDec.MouseState = MaterialSkin.MouseState.HOVER;
            btnToolsCSFSeasonNumberDec.Name = "btnToolsCSFSeasonNumberDec";
            btnToolsCSFSeasonNumberDec.Size = new System.Drawing.Size(15, 15);
            btnToolsCSFSeasonNumberDec.TabIndex = 30;
            btnToolsCSFSeasonNumberDec.Text = "-";
            btnToolsCSFSeasonNumberDec.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnToolsCSFSeasonNumberDec.UseAccentColor = false;
            btnToolsCSFSeasonNumberDec.UseVisualStyleBackColor = true;
            btnToolsCSFSeasonNumberDec.Click += btnToolsCSFSeasonNumberDec_Click;
            // 
            // btnToolsCSFSeasonNumberInc
            // 
            btnToolsCSFSeasonNumberInc.AutoSize = false;
            btnToolsCSFSeasonNumberInc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnToolsCSFSeasonNumberInc.Depth = 0;
            btnToolsCSFSeasonNumberInc.DrawShadows = true;
            btnToolsCSFSeasonNumberInc.HighEmphasis = true;
            btnToolsCSFSeasonNumberInc.Icon = null;
            btnToolsCSFSeasonNumberInc.Location = new System.Drawing.Point(925, 98);
            btnToolsCSFSeasonNumberInc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnToolsCSFSeasonNumberInc.MouseState = MaterialSkin.MouseState.HOVER;
            btnToolsCSFSeasonNumberInc.Name = "btnToolsCSFSeasonNumberInc";
            btnToolsCSFSeasonNumberInc.Size = new System.Drawing.Size(15, 15);
            btnToolsCSFSeasonNumberInc.TabIndex = 29;
            btnToolsCSFSeasonNumberInc.Text = "+";
            btnToolsCSFSeasonNumberInc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnToolsCSFSeasonNumberInc.UseAccentColor = false;
            btnToolsCSFSeasonNumberInc.UseVisualStyleBackColor = true;
            btnToolsCSFSeasonNumberInc.Click += btnToolsCSFSeasonNumberInc_Click;
            // 
            // lblToolsCSFSeasonsNumber
            // 
            lblToolsCSFSeasonsNumber.AutoSize = true;
            lblToolsCSFSeasonsNumber.Depth = 0;
            lblToolsCSFSeasonsNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblToolsCSFSeasonsNumber.Location = new System.Drawing.Point(722, 105);
            lblToolsCSFSeasonsNumber.MouseState = MaterialSkin.MouseState.HOVER;
            lblToolsCSFSeasonsNumber.Name = "lblToolsCSFSeasonsNumber";
            lblToolsCSFSeasonsNumber.Size = new System.Drawing.Size(126, 19);
            lblToolsCSFSeasonsNumber.TabIndex = 0;
            lblToolsCSFSeasonsNumber.Text = "Seasons Number:";
            // 
            // txtToolsCSFSeasonNumber
            // 
            txtToolsCSFSeasonNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtToolsCSFSeasonNumber.Depth = 0;
            txtToolsCSFSeasonNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtToolsCSFSeasonNumber.Location = new System.Drawing.Point(861, 96);
            txtToolsCSFSeasonNumber.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            txtToolsCSFSeasonNumber.MaxLength = 2;
            txtToolsCSFSeasonNumber.MouseState = MaterialSkin.MouseState.OUT;
            txtToolsCSFSeasonNumber.Multiline = false;
            txtToolsCSFSeasonNumber.Name = "txtToolsCSFSeasonNumber";
            txtToolsCSFSeasonNumber.ReadOnly = true;
            txtToolsCSFSeasonNumber.Size = new System.Drawing.Size(57, 36);
            txtToolsCSFSeasonNumber.TabIndex = 28;
            txtToolsCSFSeasonNumber.Text = "";
            txtToolsCSFSeasonNumber.UseTallSize = false;
            txtToolsCSFSeasonNumber.TextChanged += txtToolsCSFSeasonNumber_TextChanged;
            // 
            // btnToolsDestinationBrowse
            // 
            btnToolsDestinationBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnToolsDestinationBrowse.Depth = 0;
            btnToolsDestinationBrowse.DrawShadows = true;
            btnToolsDestinationBrowse.HighEmphasis = true;
            btnToolsDestinationBrowse.Icon = null;
            btnToolsDestinationBrowse.Location = new System.Drawing.Point(853, 27);
            btnToolsDestinationBrowse.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            btnToolsDestinationBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            btnToolsDestinationBrowse.Name = "btnToolsDestinationBrowse";
            btnToolsDestinationBrowse.Size = new System.Drawing.Size(92, 36);
            btnToolsDestinationBrowse.TabIndex = 25;
            btnToolsDestinationBrowse.Text = "Browse...";
            btnToolsDestinationBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnToolsDestinationBrowse.UseAccentColor = false;
            btnToolsDestinationBrowse.UseVisualStyleBackColor = true;
            btnToolsDestinationBrowse.Click += btnBrowse_Click;
            // 
            // radioToolsSFP
            // 
            radioToolsSFP.AutoSize = true;
            radioToolsSFP.Depth = 0;
            radioToolsSFP.Location = new System.Drawing.Point(15, 172);
            radioToolsSFP.Margin = new System.Windows.Forms.Padding(0);
            radioToolsSFP.MouseLocation = new System.Drawing.Point(-1, -1);
            radioToolsSFP.MouseState = MaterialSkin.MouseState.HOVER;
            radioToolsSFP.Name = "radioToolsSFP";
            radioToolsSFP.Ripple = true;
            radioToolsSFP.Size = new System.Drawing.Size(212, 37);
            radioToolsSFP.TabIndex = 27;
            radioToolsSFP.TabStop = true;
            radioToolsSFP.Text = "Series FilesName Pattern";
            radioToolsSFP.UseVisualStyleBackColor = true;
            radioToolsSFP.CheckedChanged += RadioToolsBox_CheckedChanged;
            // 
            // radioToolsCSF
            // 
            radioToolsCSF.AutoSize = true;
            radioToolsCSF.Depth = 0;
            radioToolsCSF.Location = new System.Drawing.Point(15, 95);
            radioToolsCSF.Margin = new System.Windows.Forms.Padding(0);
            radioToolsCSF.MouseLocation = new System.Drawing.Point(-1, -1);
            radioToolsCSF.MouseState = MaterialSkin.MouseState.HOVER;
            radioToolsCSF.Name = "radioToolsCSF";
            radioToolsCSF.Ripple = true;
            radioToolsCSF.Size = new System.Drawing.Size(175, 37);
            radioToolsCSF.TabIndex = 26;
            radioToolsCSF.TabStop = true;
            radioToolsCSF.Text = "Create Series Folder";
            radioToolsCSF.UseVisualStyleBackColor = true;
            radioToolsCSF.CheckedChanged += RadioToolsBox_CheckedChanged;
            // 
            // lblToolsDestination
            // 
            lblToolsDestination.AutoSize = true;
            lblToolsDestination.Depth = 0;
            lblToolsDestination.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblToolsDestination.Location = new System.Drawing.Point(22, 36);
            lblToolsDestination.Margin = new System.Windows.Forms.Padding(5);
            lblToolsDestination.MouseState = MaterialSkin.MouseState.HOVER;
            lblToolsDestination.Name = "lblToolsDestination";
            lblToolsDestination.Size = new System.Drawing.Size(86, 19);
            lblToolsDestination.TabIndex = 0;
            lblToolsDestination.Text = "Destination:";
            // 
            // txtToolsDestination
            // 
            txtToolsDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtToolsDestination.Depth = 0;
            txtToolsDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtToolsDestination.Location = new System.Drawing.Point(116, 28);
            txtToolsDestination.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            txtToolsDestination.MaxLength = 200;
            txtToolsDestination.MouseState = MaterialSkin.MouseState.OUT;
            txtToolsDestination.Multiline = false;
            txtToolsDestination.Name = "txtToolsDestination";
            txtToolsDestination.Size = new System.Drawing.Size(724, 36);
            txtToolsDestination.TabIndex = 24;
            txtToolsDestination.Text = "";
            txtToolsDestination.UseTallSize = false;
            // 
            // btnHelp
            // 
            btnHelp.AutoSize = false;
            btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnHelp.Depth = 0;
            btnHelp.DrawShadows = true;
            btnHelp.HighEmphasis = true;
            btnHelp.Icon = null;
            btnHelp.Location = new System.Drawing.Point(638, 410);
            btnHelp.Margin = new System.Windows.Forms.Padding(10);
            btnHelp.MouseState = MaterialSkin.MouseState.HOVER;
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new System.Drawing.Size(100, 35);
            btnHelp.TabIndex = 53;
            btnHelp.Text = "Help";
            btnHelp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnHelp.UseAccentColor = false;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // boxNotSelected
            // 
            boxNotSelected.Controls.Add(panelLoading);
            boxNotSelected.Controls.Add(lblNotSelected);
            boxNotSelected.Location = new System.Drawing.Point(0, 0);
            boxNotSelected.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            boxNotSelected.Name = "boxNotSelected";
            boxNotSelected.Padding = new System.Windows.Forms.Padding(10);
            boxNotSelected.Size = new System.Drawing.Size(960, 250);
            boxNotSelected.TabIndex = 54;
            boxNotSelected.TabStop = false;
            // 
            // panelLoading
            // 
            panelLoading.Controls.Add(lblLoading);
            panelLoading.Controls.Add(progressBar);
            panelLoading.Location = new System.Drawing.Point(37, 134);
            panelLoading.Name = "panelLoading";
            panelLoading.Size = new System.Drawing.Size(894, 72);
            panelLoading.TabIndex = 2;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Location = new System.Drawing.Point(415, 12);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new System.Drawing.Size(62, 15);
            lblLoading.TabIndex = 2;
            lblLoading.Text = "Loading ...";
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(6, 39);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(881, 23);
            progressBar.TabIndex = 1;
            // 
            // lblNotSelected
            // 
            lblNotSelected.AutoSize = true;
            lblNotSelected.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblNotSelected.ForeColor = System.Drawing.Color.Red;
            lblNotSelected.Location = new System.Drawing.Point(37, 104);
            lblNotSelected.Name = "lblNotSelected";
            lblNotSelected.Size = new System.Drawing.Size(361, 30);
            lblNotSelected.TabIndex = 0;
            lblNotSelected.Text = "Select one of the Options above...";
            // 
            // radioData
            // 
            radioData.AutoSize = true;
            radioData.Depth = 0;
            radioData.Location = new System.Drawing.Point(406, 84);
            radioData.Margin = new System.Windows.Forms.Padding(0);
            radioData.MouseLocation = new System.Drawing.Point(-1, -1);
            radioData.MouseState = MaterialSkin.MouseState.HOVER;
            radioData.Name = "radioData";
            radioData.Ripple = true;
            radioData.Size = new System.Drawing.Size(69, 37);
            radioData.TabIndex = 55;
            radioData.TabStop = true;
            radioData.Text = "Data";
            radioData.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1000, 500);
            Controls.Add(boxRename);
            Controls.Add(radioData);
            Controls.Add(radioRename);
            Controls.Add(btnHelp);
            Controls.Add(radioTools);
            Controls.Add(radioSubtitles);
            Controls.Add(boxFooter);
            Controls.Add(btnAbout);
            Controls.Add(btnExit);
            Controls.Add(btnRun);
            Controls.Add(boxTools);
            Controls.Add(boxSubtitle);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Resam Renamer";
            FormClosing += FormMain_FormClosing;
            Shown += FormMain_Shown;
            KeyPress += FormMain_KeyPress;
            boxRename.ResumeLayout(false);
            boxRename.PerformLayout();
            boxSubtitle.ResumeLayout(false);
            boxSubtitle.PerformLayout();
            boxSubtitleInner.ResumeLayout(false);
            boxSubtitleInner.PerformLayout();
            boxFooter.ResumeLayout(false);
            boxFooter.PerformLayout();
            boxTools.ResumeLayout(false);
            boxTools.PerformLayout();
            boxNotSelected.ResumeLayout(false);
            boxNotSelected.PerformLayout();
            panelLoading.ResumeLayout(false);
            panelLoading.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialRadioButton radioData;

        #endregion

        private System.Windows.Forms.GroupBox boxRename;
        private GroupBox boxSubtitle;
        private MaterialSkin.Controls.MaterialButton btnRun;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialButton btnAbout;
        private MaterialSkin.Controls.MaterialTextBox txtRenameAddress;
        private MaterialSkin.Controls.MaterialLabel lblRenameAddress;
        private MaterialSkin.Controls.MaterialButton btnRenameAddressBrowse;
        private MaterialSkin.Controls.MaterialComboBox comboRenamePredefinedFilters;
        private MaterialSkin.Controls.MaterialRadioButton radioRenameCustomFilter;
        private MaterialSkin.Controls.MaterialRadioButton radioRenamePredefinedFilter;
        private MaterialSkin.Controls.MaterialCheckbox checkRenamePowerShell;
        private MaterialSkin.Controls.MaterialCheckbox checkRenameSubfolders;
        private MaterialSkin.Controls.MaterialCheckbox checkRenameCustomFilterRemove;
        private MaterialSkin.Controls.MaterialTextBox txtRenameCustomFilterReplaceText;
        private MaterialSkin.Controls.MaterialTextBox txtRenameCustomFilterOriginalText;
        private MaterialSkin.Controls.MaterialCheckbox checkRenameFullArrange;
        private GroupBox boxSubtitleInner;
        private MaterialSkin.Controls.MaterialButton btnSubtitleSubtitleBrowse;
        private MaterialSkin.Controls.MaterialButton btnSubtitleSourceBrowse;
        private MaterialSkin.Controls.MaterialButton btnSubtitleDestinationBrowse;
        private MaterialSkin.Controls.MaterialTextBox txtSubtitleSubtitle;
        private MaterialSkin.Controls.MaterialTextBox txtSubtitleSource;
        private MaterialSkin.Controls.MaterialLabel lblSubtitleSubtitle;
        private MaterialSkin.Controls.MaterialLabel lblSubtitleSource;
        private MaterialSkin.Controls.MaterialLabel lblSubtitleDestination;
        private MaterialSkin.Controls.MaterialTextBox txtSubtitleDestination;
        private MaterialSkin.Controls.MaterialRadioButton radioSubtitleSeries;
        private MaterialSkin.Controls.MaterialRadioButton radioSubtitleMovie;
        private GroupBox boxFooter;
        private MaterialSkin.Controls.MaterialRadioButton radioRename;
        private MaterialSkin.Controls.MaterialRadioButton radioSubtitles;
        private MaterialSkin.Controls.MaterialCheckbox checkSameFolder;
        private Label lblFooterVersionLabel;
        private Label lblFooterStatusLabel;
        private Label lblFooterVersion;
        private Label lblFooterStatus;
        private MaterialSkin.Controls.MaterialRadioButton radioTools;
        private GroupBox boxTools;
        private MaterialSkin.Controls.MaterialTextBox txtToolsSFP1;
        private MaterialSkin.Controls.MaterialButton btnToolsCSFSeasonNumberDec;
        private MaterialSkin.Controls.MaterialButton btnToolsCSFSeasonNumberInc;
        private MaterialSkin.Controls.MaterialLabel lblToolsCSFSeasonsNumber;
        private MaterialSkin.Controls.MaterialTextBox txtToolsCSFSeasonNumber;
        private MaterialSkin.Controls.MaterialButton btnToolsDestinationBrowse;
        private MaterialSkin.Controls.MaterialRadioButton radioToolsSFP;
        private MaterialSkin.Controls.MaterialRadioButton radioToolsCSF;
        private MaterialSkin.Controls.MaterialLabel lblToolsDestination;
        private MaterialSkin.Controls.MaterialTextBox txtToolsDestination;
        private MaterialSkin.Controls.MaterialTextBox txtToolsSFPE;
        private MaterialSkin.Controls.MaterialTextBox txtToolsSFP2;
        private MaterialSkin.Controls.MaterialTextBox txtToolsSFPS;
        private MaterialSkin.Controls.MaterialButton btnHelp;
        private MaterialSkin.Controls.MaterialCheckbox checkRenameAllFormats;
        private System.Windows.Forms.GroupBox boxNotSelected;
        private Label lblNotSelected;
        private ProgressBar progressBar;
        private Panel panelLoading;
        private Label lblLoading;
    }
}