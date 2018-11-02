namespace PutioManager.forms.main
{
    partial class Settings
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
            this.menuStripSettings = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStripSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripSettings
            // 
            this.menuStripSettings.AutoSize = false;
            this.menuStripSettings.BackColor = System.Drawing.Color.White;
            this.menuStripSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.downloadsToolStripMenuItem,
            this.interfaceToolStripMenuItem});
            this.menuStripSettings.Location = new System.Drawing.Point(0, 0);
            this.menuStripSettings.Name = "menuStripSettings";
            this.menuStripSettings.Padding = new System.Windows.Forms.Padding(0);
            this.menuStripSettings.Size = new System.Drawing.Size(137, 450);
            this.menuStripSettings.TabIndex = 0;
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.AutoSize = false;
            this.generalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.generalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(136, 40);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.AutoSize = false;
            this.downloadsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadsToolStripMenuItem.Name = "downloadsToolStripMenuItem";
            this.downloadsToolStripMenuItem.Size = new System.Drawing.Size(136, 40);
            this.downloadsToolStripMenuItem.Text = "Downloads";
            this.downloadsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downloadsToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // interfaceToolStripMenuItem
            // 
            this.interfaceToolStripMenuItem.AutoSize = false;
            this.interfaceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interfaceToolStripMenuItem.Name = "interfaceToolStripMenuItem";
            this.interfaceToolStripMenuItem.Size = new System.Drawing.Size(136, 40);
            this.interfaceToolStripMenuItem.Text = "Interface";
            this.interfaceToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.interfaceToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(137, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(663, 450);
            this.panelMain.TabIndex = 1;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripSettings);
            this.MainMenuStrip = this.menuStripSettings;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.VisibleChanged += new System.EventHandler(this.Settings_VisibleChanged);
            this.menuStripSettings.ResumeLayout(false);
            this.menuStripSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripSettings;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interfaceToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem downloadsToolStripMenuItem;
    }
}