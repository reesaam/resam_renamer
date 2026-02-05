namespace ResamRenamer.Forms
{
    partial class FormData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormData));
            btnClose = new MaterialSkin.Controls.MaterialButton();
            lblDataDirCountTitle = new System.Windows.Forms.Label();
            lblDataDirCount = new System.Windows.Forms.Label();
            lblDataFileCount = new System.Windows.Forms.Label();
            lblDataFileCountTitle = new System.Windows.Forms.Label();
            txtDataList = new System.Windows.Forms.TextBox();
            btnCopy = new MaterialSkin.Controls.MaterialButton();
            btnExport = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.AutoSize = false;
            btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnClose.Depth = 0;
            btnClose.DrawShadows = true;
            btnClose.HighEmphasis = true;
            btnClose.Icon = null;
            btnClose.Location = new System.Drawing.Point(632, 553);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(140, 35);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClose.UseAccentColor = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblDataDirCountTitle
            // 
            lblDataDirCountTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblDataDirCountTitle.Location = new System.Drawing.Point(73, 83);
            lblDataDirCountTitle.Name = "lblDataDirCountTitle";
            lblDataDirCountTitle.Size = new System.Drawing.Size(200, 22);
            lblDataDirCountTitle.TabIndex = 5;
            lblDataDirCountTitle.Text = "Total Directories Count:";
            // 
            // lblDataDirCount
            // 
            lblDataDirCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblDataDirCount.Location = new System.Drawing.Point(261, 83);
            lblDataDirCount.Name = "lblDataDirCount";
            lblDataDirCount.Size = new System.Drawing.Size(70, 22);
            lblDataDirCount.TabIndex = 6;
            lblDataDirCount.Text = "0";
            // 
            // lblDataFileCount
            // 
            lblDataFileCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblDataFileCount.Location = new System.Drawing.Point(698, 83);
            lblDataFileCount.Name = "lblDataFileCount";
            lblDataFileCount.Size = new System.Drawing.Size(74, 22);
            lblDataFileCount.TabIndex = 8;
            lblDataFileCount.Text = "0";
            // 
            // lblDataFileCountTitle
            // 
            lblDataFileCountTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblDataFileCountTitle.Location = new System.Drawing.Point(551, 83);
            lblDataFileCountTitle.Name = "lblDataFileCountTitle";
            lblDataFileCountTitle.Size = new System.Drawing.Size(141, 22);
            lblDataFileCountTitle.TabIndex = 7;
            lblDataFileCountTitle.Text = "Total Files Count:";
            // 
            // txtDataList
            // 
            txtDataList.AcceptsReturn = true;
            txtDataList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            txtDataList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            txtDataList.Location = new System.Drawing.Point(32, 128);
            txtDataList.Multiline = true;
            txtDataList.Name = "txtDataList";
            txtDataList.ReadOnly = true;
            txtDataList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDataList.Size = new System.Drawing.Size(740, 400);
            txtDataList.TabIndex = 9;
            txtDataList.Visible = false;
            // 
            // btnCopy
            // 
            btnCopy.AutoSize = false;
            btnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnCopy.Depth = 0;
            btnCopy.DrawShadows = true;
            btnCopy.HighEmphasis = true;
            btnCopy.Icon = null;
            btnCopy.Location = new System.Drawing.Point(32, 553);
            btnCopy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnCopy.MouseState = MaterialSkin.MouseState.HOVER;
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(140, 35);
            btnCopy.TabIndex = 10;
            btnCopy.Text = "Copy";
            btnCopy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCopy.UseAccentColor = false;
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnExport
            // 
            btnExport.AutoSize = false;
            btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnExport.Depth = 0;
            btnExport.DrawShadows = true;
            btnExport.HighEmphasis = true;
            btnExport.Icon = null;
            btnExport.Location = new System.Drawing.Point(180, 553);
            btnExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnExport.MouseState = MaterialSkin.MouseState.HOVER;
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(140, 35);
            btnExport.TabIndex = 11;
            btnExport.Text = "Export";
            btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExport.UseAccentColor = false;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // FormData
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 612);
            Controls.Add(btnExport);
            Controls.Add(btnCopy);
            Controls.Add(txtDataList);
            Controls.Add(lblDataFileCount);
            Controls.Add(lblDataFileCountTitle);
            Controls.Add(lblDataDirCount);
            Controls.Add(lblDataDirCountTitle);
            Controls.Add(btnClose);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Data";
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialButton btnCopy;
        private MaterialSkin.Controls.MaterialButton btnExport;

        private System.Windows.Forms.TextBox txtDataList;

        private System.Windows.Forms.Label lblDataDirCountTitle;
        private System.Windows.Forms.Label lblDataFileCountTitle;
        private System.Windows.Forms.Label lblDataDirCount;
        private System.Windows.Forms.Label lblDataFileCount;

        #endregion
        private MaterialSkin.Controls.MaterialButton btnClose;
    }
}