namespace PutioManager.forms.sub
{
    partial class NewTransfer
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelFormBar = new System.Windows.Forms.Panel();
            this.buttonX = new System.Windows.Forms.Button();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.textBoxMagnetLink = new System.Windows.Forms.TextBox();
            this.labelMagnetLink = new System.Windows.Forms.Label();
            this.panelFormBar.SuspendLayout();
            this.panelBottomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.buttonAdd.Location = new System.Drawing.Point(225, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(79, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add...";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAccept_click);
            // 
            // panelFormBar
            // 
            this.panelFormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelFormBar.Controls.Add(this.buttonX);
            this.panelFormBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormBar.Location = new System.Drawing.Point(0, 0);
            this.panelFormBar.Name = "panelFormBar";
            this.panelFormBar.Size = new System.Drawing.Size(311, 23);
            this.panelFormBar.TabIndex = 19;
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonX.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX.FlatAppearance.BorderSize = 0;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonX.Location = new System.Drawing.Point(288, 0);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(23, 23);
            this.buttonX.TabIndex = 0;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.BackColor = System.Drawing.Color.DarkGray;
            this.panelBottomBar.Controls.Add(this.buttonAdd);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Location = new System.Drawing.Point(0, 81);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Size = new System.Drawing.Size(311, 31);
            this.panelBottomBar.TabIndex = 18;
            // 
            // textBoxMagnetLink
            // 
            this.textBoxMagnetLink.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.textBoxMagnetLink.Location = new System.Drawing.Point(13, 48);
            this.textBoxMagnetLink.Name = "textBoxMagnetLink";
            this.textBoxMagnetLink.Size = new System.Drawing.Size(291, 21);
            this.textBoxMagnetLink.TabIndex = 20;
            // 
            // labelMagnetLink
            // 
            this.labelMagnetLink.AutoSize = true;
            this.labelMagnetLink.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.labelMagnetLink.ForeColor = System.Drawing.Color.White;
            this.labelMagnetLink.Location = new System.Drawing.Point(10, 28);
            this.labelMagnetLink.Name = "labelMagnetLink";
            this.labelMagnetLink.Size = new System.Drawing.Size(88, 17);
            this.labelMagnetLink.TabIndex = 21;
            this.labelMagnetLink.Text = "Magnet Link:";
            // 
            // NewTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(311, 112);
            this.Controls.Add(this.labelMagnetLink);
            this.Controls.Add(this.textBoxMagnetLink);
            this.Controls.Add(this.panelFormBar);
            this.Controls.Add(this.panelBottomBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MessageBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewTransfer_FormClosing);
            this.panelFormBar.ResumeLayout(false);
            this.panelBottomBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelFormBar;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.TextBox textBoxMagnetLink;
        private System.Windows.Forms.Label labelMagnetLink;
    }
}