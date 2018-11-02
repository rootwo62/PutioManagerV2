namespace PutioManager.forms.sub
{
    partial class NewAutoDownload
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxDownloadLocation = new System.Windows.Forms.TextBox();
            this.textBoxAllowedExtensions = new System.Windows.Forms.TextBox();
            this.textBoxMinDownloadSize = new System.Windows.Forms.TextBox();
            this.labelDownloadLocation = new System.Windows.Forms.Label();
            this.labelAllowedExtensions = new System.Windows.Forms.Label();
            this.labelMinDownload = new System.Windows.Forms.Label();
            this.buttonChangeChangeDefaultDownloadLocation = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.panelFormBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonX = new System.Windows.Forms.Button();
            this.checkBoxDownloadToParentFolder = new System.Windows.Forms.CheckBox();
            this.panelBottomBar.SuspendLayout();
            this.panelFormBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDownloadLocation
            // 
            this.textBoxDownloadLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDownloadLocation.Font = new System.Drawing.Font("Corbel", 10F);
            this.textBoxDownloadLocation.Location = new System.Drawing.Point(148, 32);
            this.textBoxDownloadLocation.Multiline = true;
            this.textBoxDownloadLocation.Name = "textBoxDownloadLocation";
            this.textBoxDownloadLocation.Size = new System.Drawing.Size(257, 24);
            this.textBoxDownloadLocation.TabIndex = 0;
            // 
            // textBoxAllowedExtensions
            // 
            this.textBoxAllowedExtensions.Font = new System.Drawing.Font("Corbel", 10F);
            this.textBoxAllowedExtensions.Location = new System.Drawing.Point(147, 68);
            this.textBoxAllowedExtensions.Name = "textBoxAllowedExtensions";
            this.textBoxAllowedExtensions.Size = new System.Drawing.Size(116, 24);
            this.textBoxAllowedExtensions.TabIndex = 1;
            this.textBoxAllowedExtensions.Text = "mp4,avi,mkv,mp3";
            // 
            // textBoxMinDownloadSize
            // 
            this.textBoxMinDownloadSize.Font = new System.Drawing.Font("Corbel", 10F);
            this.textBoxMinDownloadSize.Location = new System.Drawing.Point(431, 68);
            this.textBoxMinDownloadSize.Name = "textBoxMinDownloadSize";
            this.textBoxMinDownloadSize.Size = new System.Drawing.Size(39, 24);
            this.textBoxMinDownloadSize.TabIndex = 2;
            this.textBoxMinDownloadSize.Text = "300";
            // 
            // labelDownloadLocation
            // 
            this.labelDownloadLocation.AutoSize = true;
            this.labelDownloadLocation.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.labelDownloadLocation.ForeColor = System.Drawing.Color.White;
            this.labelDownloadLocation.Location = new System.Drawing.Point(12, 36);
            this.labelDownloadLocation.Name = "labelDownloadLocation";
            this.labelDownloadLocation.Size = new System.Drawing.Size(127, 17);
            this.labelDownloadLocation.TabIndex = 3;
            this.labelDownloadLocation.Text = "Download location:";
            // 
            // labelAllowedExtensions
            // 
            this.labelAllowedExtensions.AutoSize = true;
            this.labelAllowedExtensions.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.labelAllowedExtensions.ForeColor = System.Drawing.Color.White;
            this.labelAllowedExtensions.Location = new System.Drawing.Point(12, 71);
            this.labelAllowedExtensions.Name = "labelAllowedExtensions";
            this.labelAllowedExtensions.Size = new System.Drawing.Size(130, 17);
            this.labelAllowedExtensions.TabIndex = 4;
            this.labelAllowedExtensions.Text = "Allowed extensions:";
            // 
            // labelMinDownload
            // 
            this.labelMinDownload.AutoSize = true;
            this.labelMinDownload.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.labelMinDownload.ForeColor = System.Drawing.Color.White;
            this.labelMinDownload.Location = new System.Drawing.Point(269, 71);
            this.labelMinDownload.Name = "labelMinDownload";
            this.labelMinDownload.Size = new System.Drawing.Size(156, 17);
            this.labelMinDownload.TabIndex = 5;
            this.labelMinDownload.Text = "Min download size (mb):";
            // 
            // buttonChangeChangeDefaultDownloadLocation
            // 
            this.buttonChangeChangeDefaultDownloadLocation.BackColor = System.Drawing.SystemColors.Window;
            this.buttonChangeChangeDefaultDownloadLocation.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonChangeChangeDefaultDownloadLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonChangeChangeDefaultDownloadLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonChangeChangeDefaultDownloadLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeChangeDefaultDownloadLocation.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.buttonChangeChangeDefaultDownloadLocation.Location = new System.Drawing.Point(400, 32);
            this.buttonChangeChangeDefaultDownloadLocation.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChangeChangeDefaultDownloadLocation.Name = "buttonChangeChangeDefaultDownloadLocation";
            this.buttonChangeChangeDefaultDownloadLocation.Size = new System.Drawing.Size(70, 24);
            this.buttonChangeChangeDefaultDownloadLocation.TabIndex = 7;
            this.buttonChangeChangeDefaultDownloadLocation.Text = "Change...";
            this.buttonChangeChangeDefaultDownloadLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonChangeChangeDefaultDownloadLocation.UseVisualStyleBackColor = false;
            this.buttonChangeChangeDefaultDownloadLocation.Click += new System.EventHandler(this.buttonChangeChangeDefaultDownloadLocation_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAccept.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonAccept.FlatAppearance.BorderSize = 0;
            this.buttonAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.buttonAccept.Location = new System.Drawing.Point(400, 5);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(79, 23);
            this.buttonAccept.TabIndex = 8;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_click);
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.BackColor = System.Drawing.Color.DarkGray;
            this.panelBottomBar.Controls.Add(this.buttonAccept);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Location = new System.Drawing.Point(0, 134);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Size = new System.Drawing.Size(482, 31);
            this.panelBottomBar.TabIndex = 9;
            // 
            // panelFormBar
            // 
            this.panelFormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelFormBar.Controls.Add(this.labelTitle);
            this.panelFormBar.Controls.Add(this.buttonX);
            this.panelFormBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormBar.Location = new System.Drawing.Point(0, 0);
            this.panelFormBar.Name = "panelFormBar";
            this.panelFormBar.Size = new System.Drawing.Size(482, 23);
            this.panelFormBar.TabIndex = 10;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(453, 23);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "New Auto Download";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonX.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX.FlatAppearance.BorderSize = 0;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonX.Location = new System.Drawing.Point(459, 0);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(23, 23);
            this.buttonX.TabIndex = 0;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // checkBoxDownloadToParentFolder
            // 
            this.checkBoxDownloadToParentFolder.AutoSize = true;
            this.checkBoxDownloadToParentFolder.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.checkBoxDownloadToParentFolder.ForeColor = System.Drawing.Color.White;
            this.checkBoxDownloadToParentFolder.Location = new System.Drawing.Point(14, 104);
            this.checkBoxDownloadToParentFolder.Name = "checkBoxDownloadToParentFolder";
            this.checkBoxDownloadToParentFolder.Size = new System.Drawing.Size(156, 21);
            this.checkBoxDownloadToParentFolder.TabIndex = 11;
            this.checkBoxDownloadToParentFolder.Text = "Keep folder structure";
            this.checkBoxDownloadToParentFolder.UseVisualStyleBackColor = true;
            // 
            // NewAutoDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(482, 165);
            this.Controls.Add(this.textBoxDownloadLocation);
            this.Controls.Add(this.checkBoxDownloadToParentFolder);
            this.Controls.Add(this.panelFormBar);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.labelMinDownload);
            this.Controls.Add(this.labelAllowedExtensions);
            this.Controls.Add(this.labelDownloadLocation);
            this.Controls.Add(this.textBoxMinDownloadSize);
            this.Controls.Add(this.textBoxAllowedExtensions);
            this.Controls.Add(this.buttonChangeChangeDefaultDownloadLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAutoDownload";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Auto Download";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewAutoDownload_FormClosing);
            this.Load += new System.EventHandler(this.NewAutoDownload_Load);
            this.panelBottomBar.ResumeLayout(false);
            this.panelFormBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxDownloadLocation;
        private System.Windows.Forms.TextBox textBoxAllowedExtensions;
        private System.Windows.Forms.TextBox textBoxMinDownloadSize;
        private System.Windows.Forms.Label labelDownloadLocation;
        private System.Windows.Forms.Label labelAllowedExtensions;
        private System.Windows.Forms.Label labelMinDownload;
        private System.Windows.Forms.Button buttonChangeChangeDefaultDownloadLocation;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.Panel panelFormBar;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxDownloadToParentFolder;
    }
}