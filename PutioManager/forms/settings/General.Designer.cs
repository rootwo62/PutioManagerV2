namespace PutioManager.forms.settings
{
    partial class General
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
            this.labelOAuthToken = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonChangeGetToken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOAuthToken
            // 
            this.labelOAuthToken.AutoSize = true;
            this.labelOAuthToken.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.labelOAuthToken.ForeColor = System.Drawing.Color.White;
            this.labelOAuthToken.Location = new System.Drawing.Point(12, 9);
            this.labelOAuthToken.Name = "labelOAuthToken";
            this.labelOAuthToken.Size = new System.Drawing.Size(89, 17);
            this.labelOAuthToken.TabIndex = 0;
            this.labelOAuthToken.Text = "OAuthToken:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(15, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '•';
            this.textBox1.Size = new System.Drawing.Size(175, 21);
            this.textBox1.TabIndex = 1;
            // 
            // buttonChangeGetToken
            // 
            this.buttonChangeGetToken.BackColor = System.Drawing.SystemColors.Window;
            this.buttonChangeGetToken.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonChangeGetToken.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonChangeGetToken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonChangeGetToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeGetToken.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.buttonChangeGetToken.Location = new System.Drawing.Point(189, 32);
            this.buttonChangeGetToken.Name = "buttonChangeGetToken";
            this.buttonChangeGetToken.Size = new System.Drawing.Size(82, 21);
            this.buttonChangeGetToken.TabIndex = 5;
            this.buttonChangeGetToken.Text = "Get Token...";
            this.buttonChangeGetToken.UseVisualStyleBackColor = false;
            this.buttonChangeGetToken.Click += new System.EventHandler(this.buttonChangeGetToken_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangeGetToken);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelOAuthToken);
            this.Name = "General";
            this.Text = "General";
            this.Load += new System.EventHandler(this.General_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOAuthToken;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonChangeGetToken;
    }
}