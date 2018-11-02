namespace PutioManager.forms.main
{
    partial class AutoDownloads
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDownloads = new System.Windows.Forms.DataGridView();
            this.Folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowedExtensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownloadPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDownloads)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDownloads
            // 
            this.dataGridViewDownloads.AllowUserToAddRows = false;
            this.dataGridViewDownloads.AllowUserToDeleteRows = false;
            this.dataGridViewDownloads.AllowUserToResizeRows = false;
            this.dataGridViewDownloads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDownloads.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewDownloads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDownloads.ColumnHeadersHeight = 32;
            this.dataGridViewDownloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDownloads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folder,
            this.AllowedExtensions,
            this.MinSize,
            this.DownloadPath});
            this.dataGridViewDownloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDownloads.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewDownloads.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDownloads.Name = "dataGridViewDownloads";
            this.dataGridViewDownloads.ReadOnly = true;
            this.dataGridViewDownloads.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewDownloads.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDownloads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDownloads.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewDownloads.TabIndex = 1;
            // 
            // Folder
            // 
            this.Folder.HeaderText = "Folder";
            this.Folder.Name = "Folder";
            this.Folder.ReadOnly = true;
            // 
            // AllowedExtensions
            // 
            this.AllowedExtensions.HeaderText = "Allowed Extensions";
            this.AllowedExtensions.Name = "AllowedExtensions";
            this.AllowedExtensions.ReadOnly = true;
            // 
            // MinSize
            // 
            this.MinSize.HeaderText = "Minimum Download Size";
            this.MinSize.Name = "MinSize";
            this.MinSize.ReadOnly = true;
            // 
            // DownloadPath
            // 
            this.DownloadPath.HeaderText = "Download Path";
            this.DownloadPath.Name = "DownloadPath";
            this.DownloadPath.ReadOnly = true;
            // 
            // AutoDownloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDownloads);
            this.Name = "AutoDownloads";
            this.Text = "Auto Downloads";
            this.Load += new System.EventHandler(this.FormAutoDownloads_Load);
            this.VisibleChanged += new System.EventHandler(this.AutoDownloads_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDownloads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder;
        public System.Windows.Forms.DataGridView dataGridViewDownloads;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowedExtensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownloadPath;
    }
}