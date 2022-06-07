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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.boxRename = new System.Windows.Forms.GroupBox();
            this.checkRenameAllFormats = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkRenamePowerShell = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkRenameSubfolders = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkRenameCustomFilterRemove = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtRenameCustomFilterReplaceText = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRenameCustomFilterOriginalText = new MaterialSkin.Controls.MaterialTextBox();
            this.checkRenameFullArrange = new MaterialSkin.Controls.MaterialCheckbox();
            this.comboRenamePredefinedFilters = new MaterialSkin.Controls.MaterialComboBox();
            this.radioRenameCustomFilter = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioRenamePredefinedFilter = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnRenameAddressBrowse = new MaterialSkin.Controls.MaterialButton();
            this.txtRenameAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.lblRenameAddress = new MaterialSkin.Controls.MaterialLabel();
            this.boxSubtitle = new System.Windows.Forms.GroupBox();
            this.checkSameFolder = new MaterialSkin.Controls.MaterialCheckbox();
            this.boxSubtitleInner = new System.Windows.Forms.GroupBox();
            this.btnSubtitleSubtitleBrowse = new MaterialSkin.Controls.MaterialButton();
            this.btnSubtitleSourceBrowse = new MaterialSkin.Controls.MaterialButton();
            this.btnSubtitleDestinationBrowse = new MaterialSkin.Controls.MaterialButton();
            this.txtSubtitleSubtitle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSubtitleSource = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSubtitleSubtitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblSubtitleSource = new MaterialSkin.Controls.MaterialLabel();
            this.lblSubtitleDestination = new MaterialSkin.Controls.MaterialLabel();
            this.txtSubtitleDestination = new MaterialSkin.Controls.MaterialTextBox();
            this.radioSubtitleSeries = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioSubtitleMovie = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnRun = new MaterialSkin.Controls.MaterialButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.btnAbout = new MaterialSkin.Controls.MaterialButton();
            this.boxFooter = new System.Windows.Forms.GroupBox();
            this.lblFooterStatus = new System.Windows.Forms.Label();
            this.lblFooterVersion = new System.Windows.Forms.Label();
            this.lblFooterVersionLabel = new System.Windows.Forms.Label();
            this.lblFooterStatusLabel = new System.Windows.Forms.Label();
            this.radioRename = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioSubtitles = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioTools = new MaterialSkin.Controls.MaterialRadioButton();
            this.boxTools = new System.Windows.Forms.GroupBox();
            this.txtToolsSFPE = new MaterialSkin.Controls.MaterialTextBox();
            this.txtToolsSFP2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtToolsSFPS = new MaterialSkin.Controls.MaterialTextBox();
            this.txtToolsSFP1 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnToolsCSFSeasonNumberDec = new MaterialSkin.Controls.MaterialButton();
            this.btnToolsCSFSeasonNumberInc = new MaterialSkin.Controls.MaterialButton();
            this.lblToolsCSFSeasonsNumber = new MaterialSkin.Controls.MaterialLabel();
            this.txtToolsCSFSeasonNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.btnToolsDestinationBrowse = new MaterialSkin.Controls.MaterialButton();
            this.radioToolsSFP = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioToolsCSF = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblToolsDestination = new MaterialSkin.Controls.MaterialLabel();
            this.txtToolsDestination = new MaterialSkin.Controls.MaterialTextBox();
            this.btnHelp = new MaterialSkin.Controls.MaterialButton();
            this.boxRename.SuspendLayout();
            this.boxSubtitle.SuspendLayout();
            this.boxSubtitleInner.SuspendLayout();
            this.boxFooter.SuspendLayout();
            this.boxTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxRename
            // 
            this.boxRename.Controls.Add(this.checkRenameAllFormats);
            this.boxRename.Controls.Add(this.checkRenamePowerShell);
            this.boxRename.Controls.Add(this.checkRenameSubfolders);
            this.boxRename.Controls.Add(this.checkRenameCustomFilterRemove);
            this.boxRename.Controls.Add(this.txtRenameCustomFilterReplaceText);
            this.boxRename.Controls.Add(this.txtRenameCustomFilterOriginalText);
            this.boxRename.Controls.Add(this.checkRenameFullArrange);
            this.boxRename.Controls.Add(this.comboRenamePredefinedFilters);
            this.boxRename.Controls.Add(this.radioRenameCustomFilter);
            this.boxRename.Controls.Add(this.radioRenamePredefinedFilter);
            this.boxRename.Controls.Add(this.btnRenameAddressBrowse);
            this.boxRename.Controls.Add(this.txtRenameAddress);
            this.boxRename.Controls.Add(this.lblRenameAddress);
            this.boxRename.Location = new System.Drawing.Point(13, 102);
            this.boxRename.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.boxRename.Name = "boxRename";
            this.boxRename.Padding = new System.Windows.Forms.Padding(10);
            this.boxRename.Size = new System.Drawing.Size(974, 225);
            this.boxRename.TabIndex = 0;
            this.boxRename.TabStop = false;
            // 
            // checkRenameAllFormats
            // 
            this.checkRenameAllFormats.AutoSize = true;
            this.checkRenameAllFormats.Depth = 0;
            this.checkRenameAllFormats.Location = new System.Drawing.Point(182, 178);
            this.checkRenameAllFormats.Margin = new System.Windows.Forms.Padding(0);
            this.checkRenameAllFormats.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkRenameAllFormats.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkRenameAllFormats.Name = "checkRenameAllFormats";
            this.checkRenameAllFormats.Ripple = true;
            this.checkRenameAllFormats.Size = new System.Drawing.Size(116, 37);
            this.checkRenameAllFormats.TabIndex = 15;
            this.checkRenameAllFormats.Text = "All Formats";
            this.checkRenameAllFormats.UseVisualStyleBackColor = true;
            // 
            // checkRenamePowerShell
            // 
            this.checkRenamePowerShell.AutoSize = true;
            this.checkRenamePowerShell.Depth = 0;
            this.checkRenamePowerShell.Location = new System.Drawing.Point(747, 178);
            this.checkRenamePowerShell.Margin = new System.Windows.Forms.Padding(0);
            this.checkRenamePowerShell.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkRenamePowerShell.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkRenamePowerShell.Name = "checkRenamePowerShell";
            this.checkRenamePowerShell.Ripple = true;
            this.checkRenamePowerShell.Size = new System.Drawing.Size(114, 37);
            this.checkRenamePowerShell.TabIndex = 14;
            this.checkRenamePowerShell.Text = "PowerShell";
            this.checkRenamePowerShell.UseVisualStyleBackColor = true;
            // 
            // checkRenameSubfolders
            // 
            this.checkRenameSubfolders.AutoSize = true;
            this.checkRenameSubfolders.Depth = 0;
            this.checkRenameSubfolders.Location = new System.Drawing.Point(403, 178);
            this.checkRenameSubfolders.Margin = new System.Windows.Forms.Padding(0);
            this.checkRenameSubfolders.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkRenameSubfolders.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkRenameSubfolders.Name = "checkRenameSubfolders";
            this.checkRenameSubfolders.Ripple = true;
            this.checkRenameSubfolders.Size = new System.Drawing.Size(112, 37);
            this.checkRenameSubfolders.TabIndex = 13;
            this.checkRenameSubfolders.Text = "Subfolders";
            this.checkRenameSubfolders.UseVisualStyleBackColor = true;
            // 
            // checkRenameCustomFilterRemove
            // 
            this.checkRenameCustomFilterRemove.AutoSize = true;
            this.checkRenameCustomFilterRemove.Depth = 0;
            this.checkRenameCustomFilterRemove.Location = new System.Drawing.Point(872, 125);
            this.checkRenameCustomFilterRemove.Margin = new System.Windows.Forms.Padding(0);
            this.checkRenameCustomFilterRemove.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkRenameCustomFilterRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkRenameCustomFilterRemove.Name = "checkRenameCustomFilterRemove";
            this.checkRenameCustomFilterRemove.Ripple = true;
            this.checkRenameCustomFilterRemove.Size = new System.Drawing.Size(92, 37);
            this.checkRenameCustomFilterRemove.TabIndex = 12;
            this.checkRenameCustomFilterRemove.Text = "Remove";
            this.checkRenameCustomFilterRemove.UseVisualStyleBackColor = true;
            this.checkRenameCustomFilterRemove.CheckedChanged += new System.EventHandler(this.checkRenameCustomFilterRemove_CheckedChanged);
            // 
            // txtRenameCustomFilterReplaceText
            // 
            this.txtRenameCustomFilterReplaceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRenameCustomFilterReplaceText.Depth = 0;
            this.txtRenameCustomFilterReplaceText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRenameCustomFilterReplaceText.Location = new System.Drawing.Point(528, 125);
            this.txtRenameCustomFilterReplaceText.MaxLength = 50;
            this.txtRenameCustomFilterReplaceText.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRenameCustomFilterReplaceText.Multiline = false;
            this.txtRenameCustomFilterReplaceText.Name = "txtRenameCustomFilterReplaceText";
            this.txtRenameCustomFilterReplaceText.Size = new System.Drawing.Size(333, 36);
            this.txtRenameCustomFilterReplaceText.TabIndex = 11;
            this.txtRenameCustomFilterReplaceText.Text = "";
            this.txtRenameCustomFilterReplaceText.UseTallSize = false;
            // 
            // txtRenameCustomFilterOriginalText
            // 
            this.txtRenameCustomFilterOriginalText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRenameCustomFilterOriginalText.Depth = 0;
            this.txtRenameCustomFilterOriginalText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRenameCustomFilterOriginalText.Location = new System.Drawing.Point(182, 125);
            this.txtRenameCustomFilterOriginalText.MaxLength = 50;
            this.txtRenameCustomFilterOriginalText.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRenameCustomFilterOriginalText.Multiline = false;
            this.txtRenameCustomFilterOriginalText.Name = "txtRenameCustomFilterOriginalText";
            this.txtRenameCustomFilterOriginalText.Size = new System.Drawing.Size(333, 36);
            this.txtRenameCustomFilterOriginalText.TabIndex = 10;
            this.txtRenameCustomFilterOriginalText.Text = "";
            this.txtRenameCustomFilterOriginalText.UseTallSize = false;
            // 
            // checkRenameFullArrange
            // 
            this.checkRenameFullArrange.AutoSize = true;
            this.checkRenameFullArrange.Depth = 0;
            this.checkRenameFullArrange.Location = new System.Drawing.Point(528, 79);
            this.checkRenameFullArrange.Margin = new System.Windows.Forms.Padding(0);
            this.checkRenameFullArrange.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkRenameFullArrange.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkRenameFullArrange.Name = "checkRenameFullArrange";
            this.checkRenameFullArrange.Ripple = true;
            this.checkRenameFullArrange.Size = new System.Drawing.Size(115, 37);
            this.checkRenameFullArrange.TabIndex = 9;
            this.checkRenameFullArrange.Text = "Full Arange";
            this.checkRenameFullArrange.UseVisualStyleBackColor = true;
            // 
            // comboRenamePredefinedFilters
            // 
            this.comboRenamePredefinedFilters.AutoResize = false;
            this.comboRenamePredefinedFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboRenamePredefinedFilters.Depth = 0;
            this.comboRenamePredefinedFilters.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboRenamePredefinedFilters.DropDownHeight = 118;
            this.comboRenamePredefinedFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRenamePredefinedFilters.DropDownWidth = 121;
            this.comboRenamePredefinedFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboRenamePredefinedFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboRenamePredefinedFilters.FormattingEnabled = true;
            this.comboRenamePredefinedFilters.IntegralHeight = false;
            this.comboRenamePredefinedFilters.ItemHeight = 29;
            this.comboRenamePredefinedFilters.Location = new System.Drawing.Point(182, 80);
            this.comboRenamePredefinedFilters.Margin = new System.Windows.Forms.Padding(10);
            this.comboRenamePredefinedFilters.MaxDropDownItems = 4;
            this.comboRenamePredefinedFilters.MouseState = MaterialSkin.MouseState.OUT;
            this.comboRenamePredefinedFilters.Name = "comboRenamePredefinedFilters";
            this.comboRenamePredefinedFilters.Size = new System.Drawing.Size(333, 35);
            this.comboRenamePredefinedFilters.StartIndex = 0;
            this.comboRenamePredefinedFilters.TabIndex = 8;
            this.comboRenamePredefinedFilters.UseAccent = false;
            this.comboRenamePredefinedFilters.UseTallSize = false;
            // 
            // radioRenameCustomFilter
            // 
            this.radioRenameCustomFilter.AutoSize = true;
            this.radioRenameCustomFilter.Depth = 0;
            this.radioRenameCustomFilter.Location = new System.Drawing.Point(10, 125);
            this.radioRenameCustomFilter.Margin = new System.Windows.Forms.Padding(0);
            this.radioRenameCustomFilter.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioRenameCustomFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioRenameCustomFilter.Name = "radioRenameCustomFilter";
            this.radioRenameCustomFilter.Ripple = true;
            this.radioRenameCustomFilter.Size = new System.Drawing.Size(133, 37);
            this.radioRenameCustomFilter.TabIndex = 7;
            this.radioRenameCustomFilter.TabStop = true;
            this.radioRenameCustomFilter.Text = "Custom Filter:";
            this.radioRenameCustomFilter.UseVisualStyleBackColor = true;
            this.radioRenameCustomFilter.CheckedChanged += new System.EventHandler(this.RadioRename_CheckedChanged);
            // 
            // radioRenamePredefinedFilter
            // 
            this.radioRenamePredefinedFilter.AutoSize = true;
            this.radioRenamePredefinedFilter.Depth = 0;
            this.radioRenamePredefinedFilter.Location = new System.Drawing.Point(10, 79);
            this.radioRenamePredefinedFilter.Margin = new System.Windows.Forms.Padding(0);
            this.radioRenamePredefinedFilter.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioRenamePredefinedFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioRenamePredefinedFilter.Name = "radioRenamePredefinedFilter";
            this.radioRenamePredefinedFilter.Ripple = true;
            this.radioRenamePredefinedFilter.Size = new System.Drawing.Size(162, 37);
            this.radioRenamePredefinedFilter.TabIndex = 6;
            this.radioRenamePredefinedFilter.TabStop = true;
            this.radioRenamePredefinedFilter.Text = "Predefined Filters:";
            this.radioRenamePredefinedFilter.UseVisualStyleBackColor = true;
            this.radioRenamePredefinedFilter.CheckedChanged += new System.EventHandler(this.RadioRename_CheckedChanged);
            // 
            // btnRenameAddressBrowse
            // 
            this.btnRenameAddressBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRenameAddressBrowse.Depth = 0;
            this.btnRenameAddressBrowse.DrawShadows = true;
            this.btnRenameAddressBrowse.HighEmphasis = true;
            this.btnRenameAddressBrowse.Icon = null;
            this.btnRenameAddressBrowse.Location = new System.Drawing.Point(868, 24);
            this.btnRenameAddressBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRenameAddressBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRenameAddressBrowse.Name = "btnRenameAddressBrowse";
            this.btnRenameAddressBrowse.Size = new System.Drawing.Size(92, 36);
            this.btnRenameAddressBrowse.TabIndex = 5;
            this.btnRenameAddressBrowse.Text = "Browse...";
            this.btnRenameAddressBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRenameAddressBrowse.UseAccentColor = false;
            this.btnRenameAddressBrowse.UseVisualStyleBackColor = true;
            this.btnRenameAddressBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtRenameAddress
            // 
            this.txtRenameAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRenameAddress.Depth = 0;
            this.txtRenameAddress.DetectUrls = false;
            this.txtRenameAddress.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRenameAddress.Location = new System.Drawing.Point(85, 24);
            this.txtRenameAddress.MaxLength = 200;
            this.txtRenameAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRenameAddress.Multiline = false;
            this.txtRenameAddress.Name = "txtRenameAddress";
            this.txtRenameAddress.ShowSelectionMargin = true;
            this.txtRenameAddress.Size = new System.Drawing.Size(776, 36);
            this.txtRenameAddress.TabIndex = 4;
            this.txtRenameAddress.Text = "";
            this.txtRenameAddress.UseTallSize = false;
            // 
            // lblRenameAddress
            // 
            this.lblRenameAddress.AutoSize = true;
            this.lblRenameAddress.Depth = 0;
            this.lblRenameAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRenameAddress.Location = new System.Drawing.Point(15, 31);
            this.lblRenameAddress.Margin = new System.Windows.Forms.Padding(5);
            this.lblRenameAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRenameAddress.Name = "lblRenameAddress";
            this.lblRenameAddress.Size = new System.Drawing.Size(62, 19);
            this.lblRenameAddress.TabIndex = 0;
            this.lblRenameAddress.Text = "Address:";
            // 
            // boxSubtitle
            // 
            this.boxSubtitle.Controls.Add(this.checkSameFolder);
            this.boxSubtitle.Controls.Add(this.boxSubtitleInner);
            this.boxSubtitle.Controls.Add(this.radioSubtitleSeries);
            this.boxSubtitle.Controls.Add(this.radioSubtitleMovie);
            this.boxSubtitle.Location = new System.Drawing.Point(13, 367);
            this.boxSubtitle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.boxSubtitle.Name = "boxSubtitle";
            this.boxSubtitle.Padding = new System.Windows.Forms.Padding(5);
            this.boxSubtitle.Size = new System.Drawing.Size(974, 232);
            this.boxSubtitle.TabIndex = 2;
            this.boxSubtitle.TabStop = false;
            // 
            // checkSameFolder
            // 
            this.checkSameFolder.AutoSize = true;
            this.checkSameFolder.Depth = 0;
            this.checkSameFolder.Location = new System.Drawing.Point(220, 191);
            this.checkSameFolder.Margin = new System.Windows.Forms.Padding(0);
            this.checkSameFolder.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkSameFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkSameFolder.Name = "checkSameFolder";
            this.checkSameFolder.Ripple = true;
            this.checkSameFolder.Size = new System.Drawing.Size(163, 37);
            this.checkSameFolder.TabIndex = 23;
            this.checkSameFolder.Text = "All in Same Folder";
            this.checkSameFolder.UseVisualStyleBackColor = true;
            this.checkSameFolder.CheckedChanged += new System.EventHandler(this.checkSameFolder_CheckedChanged);
            // 
            // boxSubtitleInner
            // 
            this.boxSubtitleInner.Controls.Add(this.btnSubtitleSubtitleBrowse);
            this.boxSubtitleInner.Controls.Add(this.btnSubtitleSourceBrowse);
            this.boxSubtitleInner.Controls.Add(this.btnSubtitleDestinationBrowse);
            this.boxSubtitleInner.Controls.Add(this.txtSubtitleSubtitle);
            this.boxSubtitleInner.Controls.Add(this.txtSubtitleSource);
            this.boxSubtitleInner.Controls.Add(this.lblSubtitleSubtitle);
            this.boxSubtitleInner.Controls.Add(this.lblSubtitleSource);
            this.boxSubtitleInner.Controls.Add(this.lblSubtitleDestination);
            this.boxSubtitleInner.Controls.Add(this.txtSubtitleDestination);
            this.boxSubtitleInner.Location = new System.Drawing.Point(110, 14);
            this.boxSubtitleInner.Name = "boxSubtitleInner";
            this.boxSubtitleInner.Size = new System.Drawing.Size(850, 176);
            this.boxSubtitleInner.TabIndex = 2;
            this.boxSubtitleInner.TabStop = false;
            // 
            // btnSubtitleSubtitleBrowse
            // 
            this.btnSubtitleSubtitleBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubtitleSubtitleBrowse.Depth = 0;
            this.btnSubtitleSubtitleBrowse.DrawShadows = true;
            this.btnSubtitleSubtitleBrowse.HighEmphasis = true;
            this.btnSubtitleSubtitleBrowse.Icon = null;
            this.btnSubtitleSubtitleBrowse.Location = new System.Drawing.Point(743, 119);
            this.btnSubtitleSubtitleBrowse.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.btnSubtitleSubtitleBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubtitleSubtitleBrowse.Name = "btnSubtitleSubtitleBrowse";
            this.btnSubtitleSubtitleBrowse.Size = new System.Drawing.Size(92, 36);
            this.btnSubtitleSubtitleBrowse.TabIndex = 22;
            this.btnSubtitleSubtitleBrowse.Text = "Browse...";
            this.btnSubtitleSubtitleBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSubtitleSubtitleBrowse.UseAccentColor = false;
            this.btnSubtitleSubtitleBrowse.UseVisualStyleBackColor = true;
            this.btnSubtitleSubtitleBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSubtitleSourceBrowse
            // 
            this.btnSubtitleSourceBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubtitleSourceBrowse.Depth = 0;
            this.btnSubtitleSourceBrowse.DrawShadows = true;
            this.btnSubtitleSourceBrowse.HighEmphasis = true;
            this.btnSubtitleSourceBrowse.Icon = null;
            this.btnSubtitleSourceBrowse.Location = new System.Drawing.Point(743, 71);
            this.btnSubtitleSourceBrowse.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.btnSubtitleSourceBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubtitleSourceBrowse.Name = "btnSubtitleSourceBrowse";
            this.btnSubtitleSourceBrowse.Size = new System.Drawing.Size(92, 36);
            this.btnSubtitleSourceBrowse.TabIndex = 20;
            this.btnSubtitleSourceBrowse.Text = "Browse...";
            this.btnSubtitleSourceBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSubtitleSourceBrowse.UseAccentColor = false;
            this.btnSubtitleSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSubtitleSourceBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSubtitleDestinationBrowse
            // 
            this.btnSubtitleDestinationBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubtitleDestinationBrowse.Depth = 0;
            this.btnSubtitleDestinationBrowse.DrawShadows = true;
            this.btnSubtitleDestinationBrowse.HighEmphasis = true;
            this.btnSubtitleDestinationBrowse.Icon = null;
            this.btnSubtitleDestinationBrowse.Location = new System.Drawing.Point(743, 23);
            this.btnSubtitleDestinationBrowse.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.btnSubtitleDestinationBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubtitleDestinationBrowse.Name = "btnSubtitleDestinationBrowse";
            this.btnSubtitleDestinationBrowse.Size = new System.Drawing.Size(92, 36);
            this.btnSubtitleDestinationBrowse.TabIndex = 18;
            this.btnSubtitleDestinationBrowse.Text = "Browse...";
            this.btnSubtitleDestinationBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSubtitleDestinationBrowse.UseAccentColor = false;
            this.btnSubtitleDestinationBrowse.UseVisualStyleBackColor = true;
            this.btnSubtitleDestinationBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtSubtitleSubtitle
            // 
            this.txtSubtitleSubtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtitleSubtitle.Depth = 0;
            this.txtSubtitleSubtitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubtitleSubtitle.Location = new System.Drawing.Point(110, 119);
            this.txtSubtitleSubtitle.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtSubtitleSubtitle.MaxLength = 200;
            this.txtSubtitleSubtitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSubtitleSubtitle.Multiline = false;
            this.txtSubtitleSubtitle.Name = "txtSubtitleSubtitle";
            this.txtSubtitleSubtitle.Size = new System.Drawing.Size(620, 36);
            this.txtSubtitleSubtitle.TabIndex = 21;
            this.txtSubtitleSubtitle.Text = "";
            this.txtSubtitleSubtitle.UseTallSize = false;
            // 
            // txtSubtitleSource
            // 
            this.txtSubtitleSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtitleSource.Depth = 0;
            this.txtSubtitleSource.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubtitleSource.Location = new System.Drawing.Point(110, 71);
            this.txtSubtitleSource.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtSubtitleSource.MaxLength = 200;
            this.txtSubtitleSource.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSubtitleSource.Multiline = false;
            this.txtSubtitleSource.Name = "txtSubtitleSource";
            this.txtSubtitleSource.Size = new System.Drawing.Size(620, 36);
            this.txtSubtitleSource.TabIndex = 19;
            this.txtSubtitleSource.Text = "";
            this.txtSubtitleSource.UseTallSize = false;
            // 
            // lblSubtitleSubtitle
            // 
            this.lblSubtitleSubtitle.AutoSize = true;
            this.lblSubtitleSubtitle.Depth = 0;
            this.lblSubtitleSubtitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSubtitleSubtitle.Location = new System.Drawing.Point(36, 128);
            this.lblSubtitleSubtitle.Margin = new System.Windows.Forms.Padding(5);
            this.lblSubtitleSubtitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSubtitleSubtitle.Name = "lblSubtitleSubtitle";
            this.lblSubtitleSubtitle.Size = new System.Drawing.Size(59, 19);
            this.lblSubtitleSubtitle.TabIndex = 0;
            this.lblSubtitleSubtitle.Text = "Subtitle:";
            // 
            // lblSubtitleSource
            // 
            this.lblSubtitleSource.AutoSize = true;
            this.lblSubtitleSource.Depth = 0;
            this.lblSubtitleSource.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSubtitleSource.Location = new System.Drawing.Point(41, 80);
            this.lblSubtitleSource.Margin = new System.Windows.Forms.Padding(5);
            this.lblSubtitleSource.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSubtitleSource.Name = "lblSubtitleSource";
            this.lblSubtitleSource.Size = new System.Drawing.Size(54, 19);
            this.lblSubtitleSource.TabIndex = 0;
            this.lblSubtitleSource.Text = "Source:";
            // 
            // lblSubtitleDestination
            // 
            this.lblSubtitleDestination.AutoSize = true;
            this.lblSubtitleDestination.Depth = 0;
            this.lblSubtitleDestination.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSubtitleDestination.Location = new System.Drawing.Point(9, 32);
            this.lblSubtitleDestination.Margin = new System.Windows.Forms.Padding(5);
            this.lblSubtitleDestination.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSubtitleDestination.Name = "lblSubtitleDestination";
            this.lblSubtitleDestination.Size = new System.Drawing.Size(86, 19);
            this.lblSubtitleDestination.TabIndex = 0;
            this.lblSubtitleDestination.Text = "Destination:";
            // 
            // txtSubtitleDestination
            // 
            this.txtSubtitleDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtitleDestination.Depth = 0;
            this.txtSubtitleDestination.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubtitleDestination.Location = new System.Drawing.Point(110, 23);
            this.txtSubtitleDestination.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtSubtitleDestination.MaxLength = 200;
            this.txtSubtitleDestination.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSubtitleDestination.Multiline = false;
            this.txtSubtitleDestination.Name = "txtSubtitleDestination";
            this.txtSubtitleDestination.Size = new System.Drawing.Size(620, 36);
            this.txtSubtitleDestination.TabIndex = 17;
            this.txtSubtitleDestination.Text = "";
            this.txtSubtitleDestination.UseTallSize = false;
            this.txtSubtitleDestination.TextChanged += new System.EventHandler(this.txtSubtitleDestination_TextChanged);
            // 
            // radioSubtitleSeries
            // 
            this.radioSubtitleSeries.AutoSize = true;
            this.radioSubtitleSeries.Depth = 0;
            this.radioSubtitleSeries.Location = new System.Drawing.Point(15, 65);
            this.radioSubtitleSeries.Margin = new System.Windows.Forms.Padding(0);
            this.radioSubtitleSeries.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioSubtitleSeries.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioSubtitleSeries.Name = "radioSubtitleSeries";
            this.radioSubtitleSeries.Ripple = true;
            this.radioSubtitleSeries.Size = new System.Drawing.Size(78, 37);
            this.radioSubtitleSeries.TabIndex = 16;
            this.radioSubtitleSeries.TabStop = true;
            this.radioSubtitleSeries.Text = "Series";
            this.radioSubtitleSeries.UseVisualStyleBackColor = true;
            this.radioSubtitleSeries.CheckedChanged += new System.EventHandler(this.RadioSubtitleBox_CheckedChanged);
            // 
            // radioSubtitleMovie
            // 
            this.radioSubtitleMovie.AutoSize = true;
            this.radioSubtitleMovie.Depth = 0;
            this.radioSubtitleMovie.Location = new System.Drawing.Point(15, 18);
            this.radioSubtitleMovie.Margin = new System.Windows.Forms.Padding(0);
            this.radioSubtitleMovie.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioSubtitleMovie.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioSubtitleMovie.Name = "radioSubtitleMovie";
            this.radioSubtitleMovie.Ripple = true;
            this.radioSubtitleMovie.Size = new System.Drawing.Size(78, 37);
            this.radioSubtitleMovie.TabIndex = 15;
            this.radioSubtitleMovie.TabStop = true;
            this.radioSubtitleMovie.Text = "Movie";
            this.radioSubtitleMovie.UseVisualStyleBackColor = true;
            this.radioSubtitleMovie.CheckedChanged += new System.EventHandler(this.RadioSubtitleBox_CheckedChanged);
            // 
            // btnRun
            // 
            this.btnRun.AutoSize = false;
            this.btnRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRun.Depth = 0;
            this.btnRun.DrawShadows = true;
            this.btnRun.HighEmphasis = true;
            this.btnRun.Icon = null;
            this.btnRun.Location = new System.Drawing.Point(13, 910);
            this.btnRun.Margin = new System.Windows.Forms.Padding(10);
            this.btnRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 35);
            this.btnRun.TabIndex = 50;
            this.btnRun.Text = "Run";
            this.btnRun.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRun.UseAccentColor = false;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Depth = 0;
            this.btnExit.DrawShadows = true;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(887, 910);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 52;
            this.btnExit.Text = "Exit";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.AutoSize = false;
            this.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbout.Depth = 0;
            this.btnAbout.DrawShadows = true;
            this.btnAbout.HighEmphasis = true;
            this.btnAbout.Icon = null;
            this.btnAbout.Location = new System.Drawing.Point(767, 910);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(10);
            this.btnAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 35);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About";
            this.btnAbout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAbout.UseAccentColor = false;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // boxFooter
            // 
            this.boxFooter.Controls.Add(this.lblFooterStatus);
            this.boxFooter.Controls.Add(this.lblFooterVersion);
            this.boxFooter.Controls.Add(this.lblFooterVersionLabel);
            this.boxFooter.Controls.Add(this.lblFooterStatusLabel);
            this.boxFooter.Location = new System.Drawing.Point(0, 955);
            this.boxFooter.Margin = new System.Windows.Forms.Padding(0);
            this.boxFooter.Name = "boxFooter";
            this.boxFooter.Size = new System.Drawing.Size(1000, 45);
            this.boxFooter.TabIndex = 7;
            this.boxFooter.TabStop = false;
            // 
            // lblFooterStatus
            // 
            this.lblFooterStatus.AutoSize = true;
            this.lblFooterStatus.Location = new System.Drawing.Point(70, 18);
            this.lblFooterStatus.Name = "lblFooterStatus";
            this.lblFooterStatus.Size = new System.Drawing.Size(39, 15);
            this.lblFooterStatus.TabIndex = 0;
            this.lblFooterStatus.Text = "Status";
            // 
            // lblFooterVersion
            // 
            this.lblFooterVersion.AutoSize = true;
            this.lblFooterVersion.Location = new System.Drawing.Point(948, 18);
            this.lblFooterVersion.Name = "lblFooterVersion";
            this.lblFooterVersion.Size = new System.Drawing.Size(31, 15);
            this.lblFooterVersion.TabIndex = 0;
            this.lblFooterVersion.Text = "0.0.0";
            // 
            // lblFooterVersionLabel
            // 
            this.lblFooterVersionLabel.AutoSize = true;
            this.lblFooterVersionLabel.Location = new System.Drawing.Point(890, 18);
            this.lblFooterVersionLabel.Name = "lblFooterVersionLabel";
            this.lblFooterVersionLabel.Size = new System.Drawing.Size(48, 15);
            this.lblFooterVersionLabel.TabIndex = 0;
            this.lblFooterVersionLabel.Text = "Version:";
            // 
            // lblFooterStatusLabel
            // 
            this.lblFooterStatusLabel.AutoSize = true;
            this.lblFooterStatusLabel.Location = new System.Drawing.Point(20, 18);
            this.lblFooterStatusLabel.Name = "lblFooterStatusLabel";
            this.lblFooterStatusLabel.Size = new System.Drawing.Size(42, 15);
            this.lblFooterStatusLabel.TabIndex = 0;
            this.lblFooterStatusLabel.Text = "Status:";
            // 
            // radioRename
            // 
            this.radioRename.AutoSize = true;
            this.radioRename.Depth = 0;
            this.radioRename.Location = new System.Drawing.Point(13, 71);
            this.radioRename.Margin = new System.Windows.Forms.Padding(0);
            this.radioRename.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioRename.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioRename.Name = "radioRename";
            this.radioRename.Ripple = true;
            this.radioRename.Size = new System.Drawing.Size(93, 37);
            this.radioRename.TabIndex = 2;
            this.radioRename.TabStop = true;
            this.radioRename.Text = "Rename";
            this.radioRename.UseVisualStyleBackColor = true;
            this.radioRename.CheckedChanged += new System.EventHandler(this.RadioBox_CheckedChanged);
            // 
            // radioSubtitles
            // 
            this.radioSubtitles.AutoSize = true;
            this.radioSubtitles.Depth = 0;
            this.radioSubtitles.Location = new System.Drawing.Point(13, 336);
            this.radioSubtitles.Margin = new System.Windows.Forms.Padding(0);
            this.radioSubtitles.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioSubtitles.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioSubtitles.Name = "radioSubtitles";
            this.radioSubtitles.Ripple = true;
            this.radioSubtitles.Size = new System.Drawing.Size(97, 37);
            this.radioSubtitles.TabIndex = 3;
            this.radioSubtitles.TabStop = true;
            this.radioSubtitles.Text = "Subtitles";
            this.radioSubtitles.UseVisualStyleBackColor = true;
            this.radioSubtitles.CheckedChanged += new System.EventHandler(this.RadioBox_CheckedChanged);
            // 
            // radioTools
            // 
            this.radioTools.AutoSize = true;
            this.radioTools.Depth = 0;
            this.radioTools.Location = new System.Drawing.Point(13, 608);
            this.radioTools.Margin = new System.Windows.Forms.Padding(0);
            this.radioTools.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioTools.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioTools.Name = "radioTools";
            this.radioTools.Ripple = true;
            this.radioTools.Size = new System.Drawing.Size(75, 37);
            this.radioTools.TabIndex = 3;
            this.radioTools.TabStop = true;
            this.radioTools.Text = "Tools";
            this.radioTools.UseVisualStyleBackColor = true;
            this.radioTools.CheckedChanged += new System.EventHandler(this.RadioBox_CheckedChanged);
            // 
            // boxTools
            // 
            this.boxTools.Controls.Add(this.txtToolsSFPE);
            this.boxTools.Controls.Add(this.txtToolsSFP2);
            this.boxTools.Controls.Add(this.txtToolsSFPS);
            this.boxTools.Controls.Add(this.txtToolsSFP1);
            this.boxTools.Controls.Add(this.btnToolsCSFSeasonNumberDec);
            this.boxTools.Controls.Add(this.btnToolsCSFSeasonNumberInc);
            this.boxTools.Controls.Add(this.lblToolsCSFSeasonsNumber);
            this.boxTools.Controls.Add(this.txtToolsCSFSeasonNumber);
            this.boxTools.Controls.Add(this.btnToolsDestinationBrowse);
            this.boxTools.Controls.Add(this.radioToolsSFP);
            this.boxTools.Controls.Add(this.radioToolsCSF);
            this.boxTools.Controls.Add(this.lblToolsDestination);
            this.boxTools.Controls.Add(this.txtToolsDestination);
            this.boxTools.Location = new System.Drawing.Point(13, 639);
            this.boxTools.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.boxTools.Name = "boxTools";
            this.boxTools.Padding = new System.Windows.Forms.Padding(5);
            this.boxTools.Size = new System.Drawing.Size(974, 205);
            this.boxTools.TabIndex = 10;
            this.boxTools.TabStop = false;
            // 
            // txtToolsSFPE
            // 
            this.txtToolsSFPE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToolsSFPE.Depth = 0;
            this.txtToolsSFPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToolsSFPE.Location = new System.Drawing.Point(667, 139);
            this.txtToolsSFPE.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtToolsSFPE.MaxLength = 200;
            this.txtToolsSFPE.MouseState = MaterialSkin.MouseState.OUT;
            this.txtToolsSFPE.Multiline = false;
            this.txtToolsSFPE.Name = "txtToolsSFPE";
            this.txtToolsSFPE.ReadOnly = true;
            this.txtToolsSFPE.Size = new System.Drawing.Size(48, 36);
            this.txtToolsSFPE.TabIndex = 22;
            this.txtToolsSFPE.Text = "E#";
            this.txtToolsSFPE.UseTallSize = false;
            // 
            // txtToolsSFP2
            // 
            this.txtToolsSFP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToolsSFP2.Depth = 0;
            this.txtToolsSFP2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToolsSFP2.Location = new System.Drawing.Point(728, 140);
            this.txtToolsSFP2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtToolsSFP2.MaxLength = 200;
            this.txtToolsSFP2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtToolsSFP2.Multiline = false;
            this.txtToolsSFP2.Name = "txtToolsSFP2";
            this.txtToolsSFP2.Size = new System.Drawing.Size(218, 36);
            this.txtToolsSFP2.TabIndex = 32;
            this.txtToolsSFP2.Text = "";
            this.txtToolsSFP2.UseTallSize = false;
            // 
            // txtToolsSFPS
            // 
            this.txtToolsSFPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToolsSFPS.Depth = 0;
            this.txtToolsSFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToolsSFPS.Location = new System.Drawing.Point(606, 139);
            this.txtToolsSFPS.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtToolsSFPS.MaxLength = 200;
            this.txtToolsSFPS.MouseState = MaterialSkin.MouseState.OUT;
            this.txtToolsSFPS.Multiline = false;
            this.txtToolsSFPS.Name = "txtToolsSFPS";
            this.txtToolsSFPS.ReadOnly = true;
            this.txtToolsSFPS.Size = new System.Drawing.Size(48, 36);
            this.txtToolsSFPS.TabIndex = 18;
            this.txtToolsSFPS.Text = "S#";
            this.txtToolsSFPS.UseTallSize = false;
            // 
            // txtToolsSFP1
            // 
            this.txtToolsSFP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToolsSFP1.Depth = 0;
            this.txtToolsSFP1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToolsSFP1.Location = new System.Drawing.Point(345, 139);
            this.txtToolsSFP1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtToolsSFP1.MaxLength = 200;
            this.txtToolsSFP1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtToolsSFP1.Multiline = false;
            this.txtToolsSFP1.Name = "txtToolsSFP1";
            this.txtToolsSFP1.Size = new System.Drawing.Size(248, 36);
            this.txtToolsSFP1.TabIndex = 31;
            this.txtToolsSFP1.Text = "";
            this.txtToolsSFP1.UseTallSize = false;
            // 
            // btnToolsCSFSeasonNumberDec
            // 
            this.btnToolsCSFSeasonNumberDec.AutoSize = false;
            this.btnToolsCSFSeasonNumberDec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnToolsCSFSeasonNumberDec.Depth = 0;
            this.btnToolsCSFSeasonNumberDec.DrawShadows = true;
            this.btnToolsCSFSeasonNumberDec.HighEmphasis = true;
            this.btnToolsCSFSeasonNumberDec.Icon = null;
            this.btnToolsCSFSeasonNumberDec.Location = new System.Drawing.Point(931, 102);
            this.btnToolsCSFSeasonNumberDec.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnToolsCSFSeasonNumberDec.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnToolsCSFSeasonNumberDec.Name = "btnToolsCSFSeasonNumberDec";
            this.btnToolsCSFSeasonNumberDec.Size = new System.Drawing.Size(15, 15);
            this.btnToolsCSFSeasonNumberDec.TabIndex = 30;
            this.btnToolsCSFSeasonNumberDec.Text = "-";
            this.btnToolsCSFSeasonNumberDec.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnToolsCSFSeasonNumberDec.UseAccentColor = false;
            this.btnToolsCSFSeasonNumberDec.UseVisualStyleBackColor = true;
            this.btnToolsCSFSeasonNumberDec.Click += new System.EventHandler(this.btnToolsCSFSeasonNumberDec_Click);
            // 
            // btnToolsCSFSeasonNumberInc
            // 
            this.btnToolsCSFSeasonNumberInc.AutoSize = false;
            this.btnToolsCSFSeasonNumberInc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnToolsCSFSeasonNumberInc.Depth = 0;
            this.btnToolsCSFSeasonNumberInc.DrawShadows = true;
            this.btnToolsCSFSeasonNumberInc.HighEmphasis = true;
            this.btnToolsCSFSeasonNumberInc.Icon = null;
            this.btnToolsCSFSeasonNumberInc.Location = new System.Drawing.Point(931, 84);
            this.btnToolsCSFSeasonNumberInc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnToolsCSFSeasonNumberInc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnToolsCSFSeasonNumberInc.Name = "btnToolsCSFSeasonNumberInc";
            this.btnToolsCSFSeasonNumberInc.Size = new System.Drawing.Size(15, 15);
            this.btnToolsCSFSeasonNumberInc.TabIndex = 29;
            this.btnToolsCSFSeasonNumberInc.Text = "+";
            this.btnToolsCSFSeasonNumberInc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnToolsCSFSeasonNumberInc.UseAccentColor = false;
            this.btnToolsCSFSeasonNumberInc.UseVisualStyleBackColor = true;
            this.btnToolsCSFSeasonNumberInc.Click += new System.EventHandler(this.btnToolsCSFSeasonNumberInc_Click);
            // 
            // lblToolsCSFSeasonsNumber
            // 
            this.lblToolsCSFSeasonsNumber.AutoSize = true;
            this.lblToolsCSFSeasonsNumber.Depth = 0;
            this.lblToolsCSFSeasonsNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblToolsCSFSeasonsNumber.Location = new System.Drawing.Point(728, 95);
            this.lblToolsCSFSeasonsNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblToolsCSFSeasonsNumber.Name = "lblToolsCSFSeasonsNumber";
            this.lblToolsCSFSeasonsNumber.Size = new System.Drawing.Size(126, 19);
            this.lblToolsCSFSeasonsNumber.TabIndex = 0;
            this.lblToolsCSFSeasonsNumber.Text = "Seasons Number:";
            // 
            // txtToolsCSFSeasonNumber
            // 
            this.txtToolsCSFSeasonNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToolsCSFSeasonNumber.Depth = 0;
            this.txtToolsCSFSeasonNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToolsCSFSeasonNumber.Location = new System.Drawing.Point(867, 84);
            this.txtToolsCSFSeasonNumber.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtToolsCSFSeasonNumber.MaxLength = 2;
            this.txtToolsCSFSeasonNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtToolsCSFSeasonNumber.Multiline = false;
            this.txtToolsCSFSeasonNumber.Name = "txtToolsCSFSeasonNumber";
            this.txtToolsCSFSeasonNumber.ReadOnly = true;
            this.txtToolsCSFSeasonNumber.Size = new System.Drawing.Size(57, 36);
            this.txtToolsCSFSeasonNumber.TabIndex = 28;
            this.txtToolsCSFSeasonNumber.Text = "";
            this.txtToolsCSFSeasonNumber.UseTallSize = false;
            this.txtToolsCSFSeasonNumber.TextChanged += new System.EventHandler(this.txtToolsCSFSeasonNumber_TextChanged);
            // 
            // btnToolsDestinationBrowse
            // 
            this.btnToolsDestinationBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnToolsDestinationBrowse.Depth = 0;
            this.btnToolsDestinationBrowse.DrawShadows = true;
            this.btnToolsDestinationBrowse.HighEmphasis = true;
            this.btnToolsDestinationBrowse.Icon = null;
            this.btnToolsDestinationBrowse.Location = new System.Drawing.Point(853, 27);
            this.btnToolsDestinationBrowse.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.btnToolsDestinationBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnToolsDestinationBrowse.Name = "btnToolsDestinationBrowse";
            this.btnToolsDestinationBrowse.Size = new System.Drawing.Size(92, 36);
            this.btnToolsDestinationBrowse.TabIndex = 25;
            this.btnToolsDestinationBrowse.Text = "Browse...";
            this.btnToolsDestinationBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnToolsDestinationBrowse.UseAccentColor = false;
            this.btnToolsDestinationBrowse.UseVisualStyleBackColor = true;
            this.btnToolsDestinationBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // radioToolsSFP
            // 
            this.radioToolsSFP.AutoSize = true;
            this.radioToolsSFP.Depth = 0;
            this.radioToolsSFP.Location = new System.Drawing.Point(14, 140);
            this.radioToolsSFP.Margin = new System.Windows.Forms.Padding(0);
            this.radioToolsSFP.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioToolsSFP.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioToolsSFP.Name = "radioToolsSFP";
            this.radioToolsSFP.Ripple = true;
            this.radioToolsSFP.Size = new System.Drawing.Size(212, 37);
            this.radioToolsSFP.TabIndex = 27;
            this.radioToolsSFP.TabStop = true;
            this.radioToolsSFP.Text = "Series FilesName Pattern";
            this.radioToolsSFP.UseVisualStyleBackColor = true;
            this.radioToolsSFP.CheckedChanged += new System.EventHandler(this.RadioToolsBox_CheckedChanged);
            // 
            // radioToolsCSF
            // 
            this.radioToolsCSF.AutoSize = true;
            this.radioToolsCSF.Depth = 0;
            this.radioToolsCSF.Location = new System.Drawing.Point(15, 85);
            this.radioToolsCSF.Margin = new System.Windows.Forms.Padding(0);
            this.radioToolsCSF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioToolsCSF.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioToolsCSF.Name = "radioToolsCSF";
            this.radioToolsCSF.Ripple = true;
            this.radioToolsCSF.Size = new System.Drawing.Size(175, 37);
            this.radioToolsCSF.TabIndex = 26;
            this.radioToolsCSF.TabStop = true;
            this.radioToolsCSF.Text = "Create Series Folder";
            this.radioToolsCSF.UseVisualStyleBackColor = true;
            this.radioToolsCSF.CheckedChanged += new System.EventHandler(this.RadioToolsBox_CheckedChanged);
            // 
            // lblToolsDestination
            // 
            this.lblToolsDestination.AutoSize = true;
            this.lblToolsDestination.Depth = 0;
            this.lblToolsDestination.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblToolsDestination.Location = new System.Drawing.Point(15, 37);
            this.lblToolsDestination.Margin = new System.Windows.Forms.Padding(5);
            this.lblToolsDestination.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblToolsDestination.Name = "lblToolsDestination";
            this.lblToolsDestination.Size = new System.Drawing.Size(86, 19);
            this.lblToolsDestination.TabIndex = 0;
            this.lblToolsDestination.Text = "Destination:";
            // 
            // txtToolsDestination
            // 
            this.txtToolsDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToolsDestination.Depth = 0;
            this.txtToolsDestination.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToolsDestination.Location = new System.Drawing.Point(116, 28);
            this.txtToolsDestination.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtToolsDestination.MaxLength = 200;
            this.txtToolsDestination.MouseState = MaterialSkin.MouseState.OUT;
            this.txtToolsDestination.Multiline = false;
            this.txtToolsDestination.Name = "txtToolsDestination";
            this.txtToolsDestination.Size = new System.Drawing.Size(724, 36);
            this.txtToolsDestination.TabIndex = 24;
            this.txtToolsDestination.Text = "";
            this.txtToolsDestination.UseTallSize = false;
            // 
            // btnHelp
            // 
            this.btnHelp.AutoSize = false;
            this.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelp.Depth = 0;
            this.btnHelp.DrawShadows = true;
            this.btnHelp.HighEmphasis = true;
            this.btnHelp.Icon = null;
            this.btnHelp.Location = new System.Drawing.Point(647, 910);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(10);
            this.btnHelp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 35);
            this.btnHelp.TabIndex = 53;
            this.btnHelp.Text = "Help";
            this.btnHelp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHelp.UseAccentColor = false;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.radioTools);
            this.Controls.Add(this.boxTools);
            this.Controls.Add(this.radioSubtitles);
            this.Controls.Add(this.radioRename);
            this.Controls.Add(this.boxFooter);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.boxSubtitle);
            this.Controls.Add(this.boxRename);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resam Renamer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.boxRename.ResumeLayout(false);
            this.boxRename.PerformLayout();
            this.boxSubtitle.ResumeLayout(false);
            this.boxSubtitle.PerformLayout();
            this.boxSubtitleInner.ResumeLayout(false);
            this.boxSubtitleInner.PerformLayout();
            this.boxFooter.ResumeLayout(false);
            this.boxFooter.PerformLayout();
            this.boxTools.ResumeLayout(false);
            this.boxTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox boxRename;
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
    }
}