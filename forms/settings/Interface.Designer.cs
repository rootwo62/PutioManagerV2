namespace PutioManager.forms.settings
{
    partial class Interface
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
            this.checkBoxAutoStartApplication = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxAutoStartApplication
            // 
            this.checkBoxAutoStartApplication.AutoSize = true;
            this.checkBoxAutoStartApplication.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.checkBoxAutoStartApplication.ForeColor = System.Drawing.Color.White;
            this.checkBoxAutoStartApplication.Location = new System.Drawing.Point(12, 12);
            this.checkBoxAutoStartApplication.Name = "checkBoxAutoStartApplication";
            this.checkBoxAutoStartApplication.Size = new System.Drawing.Size(239, 21);
            this.checkBoxAutoStartApplication.TabIndex = 8;
            this.checkBoxAutoStartApplication.Text = "Start application on system startup";
            this.checkBoxAutoStartApplication.UseVisualStyleBackColor = true;
            this.checkBoxAutoStartApplication.CheckedChanged += new System.EventHandler(this.checkBoxAutoStartApplication_CheckedChanged);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxAutoStartApplication);
            this.Name = "Interface";
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAutoStartApplication;
    }
}