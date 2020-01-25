namespace PutioManager.forms.main
{
    partial class Downloads
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
			this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Added = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Completed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.File,
            this.Type,
            this.Added,
            this.Completed,
            this.Status});
			this.dataGridViewDownloads.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewDownloads.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewDownloads.Name = "dataGridViewDownloads";
			this.dataGridViewDownloads.ReadOnly = true;
			this.dataGridViewDownloads.RowHeadersVisible = false;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dataGridViewDownloads.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewDownloads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewDownloads.Size = new System.Drawing.Size(800, 450);
			this.dataGridViewDownloads.TabIndex = 0;
			// 
			// File
			// 
			this.File.HeaderText = "File";
			this.File.Name = "File";
			this.File.ReadOnly = true;
			// 
			// Type
			// 
			this.Type.HeaderText = "Type";
			this.Type.Name = "Type";
			this.Type.ReadOnly = true;
			// 
			// Added
			// 
			this.Added.HeaderText = "Added";
			this.Added.Name = "Added";
			this.Added.ReadOnly = true;
			// 
			// Completed
			// 
			this.Completed.HeaderText = "Completed";
			this.Completed.Name = "Completed";
			this.Completed.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.HeaderText = "Status";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			// 
			// Downloads
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridViewDownloads);
			this.Name = "Downloads";
			this.Text = "Downloads";
			this.Load += new System.EventHandler(this.FormDownloads_Load);
			this.VisibleChanged += new System.EventHandler(this.Downloads_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDownloads)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Added;
        private System.Windows.Forms.DataGridViewTextBoxColumn Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        public System.Windows.Forms.DataGridView dataGridViewDownloads;
    }
}