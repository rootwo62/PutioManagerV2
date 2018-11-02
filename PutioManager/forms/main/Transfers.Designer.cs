namespace PutioManager.forms.main
{
    partial class Transfers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTransfers = new System.Windows.Forms.DataGridView();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Started = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTransfers
            // 
            this.dataGridViewTransfers.AllowUserToAddRows = false;
            this.dataGridViewTransfers.AllowUserToDeleteRows = false;
            this.dataGridViewTransfers.AllowUserToResizeRows = false;
            this.dataGridViewTransfers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransfers.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewTransfers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTransfers.ColumnHeadersHeight = 32;
            this.dataGridViewTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTransfers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File,
            this.Size,
            this.Peers,
            this.Uploaded,
            this.Started,
            this.Status});
            this.dataGridViewTransfers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransfers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTransfers.Name = "dataGridViewTransfers";
            this.dataGridViewTransfers.ReadOnly = true;
            this.dataGridViewTransfers.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTransfers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTransfers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransfers.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewTransfers.TabIndex = 1;
            // 
            // File
            // 
            this.File.HeaderText = "File";
            this.File.Name = "File";
            this.File.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Peers
            // 
            this.Peers.HeaderText = "Peers";
            this.Peers.Name = "Peers";
            this.Peers.ReadOnly = true;
            // 
            // Uploaded
            // 
            this.Uploaded.HeaderText = "Uploaded";
            this.Uploaded.Name = "Uploaded";
            this.Uploaded.ReadOnly = true;
            // 
            // Started
            // 
            this.Started.HeaderText = "Started";
            this.Started.Name = "Started";
            this.Started.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Transfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTransfers);
            this.Name = "Transfers";
            this.Text = "Transfers";
            this.Load += new System.EventHandler(this.FormTransfers_Load);
            this.VisibleChanged += new System.EventHandler(this.Transfers_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uploaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn Started;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        public System.Windows.Forms.DataGridView dataGridViewTransfers;
    }
}