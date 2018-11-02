namespace PutioManager.forms.settings
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
            this.numericUpDownParallelDownloads = new System.Windows.Forms.NumericUpDown();
            this.labelParallelDownloads = new System.Windows.Forms.Label();
            this.labelDefaultDownloadLocation = new System.Windows.Forms.Label();
            this.textBoxDefaultDownloadLocation = new System.Windows.Forms.TextBox();
            this.buttonChangeChangeDefaultDownloadLocation = new System.Windows.Forms.Button();
            this.checkBoxDeleteAfterDownload = new System.Windows.Forms.CheckBox();
            this.labelAutoDownloadInterval = new System.Windows.Forms.Label();
            this.numericUpDownAutoDownloadInterval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParallelDownloads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAutoDownloadInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownParallelDownloads
            // 
            this.numericUpDownParallelDownloads.Font = new System.Drawing.Font("Corbel", 12F);
            this.numericUpDownParallelDownloads.Location = new System.Drawing.Point(12, 83);
            this.numericUpDownParallelDownloads.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownParallelDownloads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownParallelDownloads.Name = "numericUpDownParallelDownloads";
            this.numericUpDownParallelDownloads.Size = new System.Drawing.Size(63, 27);
            this.numericUpDownParallelDownloads.TabIndex = 0;
            this.numericUpDownParallelDownloads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownParallelDownloads.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelParallelDownloads
            // 
            this.labelParallelDownloads.AutoSize = true;
            this.labelParallelDownloads.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.labelParallelDownloads.ForeColor = System.Drawing.Color.White;
            this.labelParallelDownloads.Location = new System.Drawing.Point(9, 63);
            this.labelParallelDownloads.Name = "labelParallelDownloads";
            this.labelParallelDownloads.Size = new System.Drawing.Size(171, 17);
            this.labelParallelDownloads.TabIndex = 1;
            this.labelParallelDownloads.Text = "Adjust parallel downloads:";
            // 
            // labelDefaultDownloadLocation
            // 
            this.labelDefaultDownloadLocation.AutoSize = true;
            this.labelDefaultDownloadLocation.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.labelDefaultDownloadLocation.ForeColor = System.Drawing.Color.White;
            this.labelDefaultDownloadLocation.Location = new System.Drawing.Point(9, 9);
            this.labelDefaultDownloadLocation.Name = "labelDefaultDownloadLocation";
            this.labelDefaultDownloadLocation.Size = new System.Drawing.Size(174, 17);
            this.labelDefaultDownloadLocation.TabIndex = 2;
            this.labelDefaultDownloadLocation.Text = "Default download location:";
            // 
            // textBoxDefaultDownloadLocation
            // 
            this.textBoxDefaultDownloadLocation.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDefaultDownloadLocation.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultDownloadLocation.Location = new System.Drawing.Point(12, 29);
            this.textBoxDefaultDownloadLocation.Multiline = true;
            this.textBoxDefaultDownloadLocation.Name = "textBoxDefaultDownloadLocation";
            this.textBoxDefaultDownloadLocation.ReadOnly = true;
            this.textBoxDefaultDownloadLocation.Size = new System.Drawing.Size(362, 23);
            this.textBoxDefaultDownloadLocation.TabIndex = 3;
            this.textBoxDefaultDownloadLocation.WordWrap = false;
            this.textBoxDefaultDownloadLocation.DoubleClick += new System.EventHandler(this.textBoxDefaultDownloadLocation_DoubleClick);
            // 
            // buttonChangeChangeDefaultDownloadLocation
            // 
            this.buttonChangeChangeDefaultDownloadLocation.BackColor = System.Drawing.SystemColors.Window;
            this.buttonChangeChangeDefaultDownloadLocation.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonChangeChangeDefaultDownloadLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonChangeChangeDefaultDownloadLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(194)))), ((int)(((byte)(20)))));
            this.buttonChangeChangeDefaultDownloadLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeChangeDefaultDownloadLocation.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeChangeDefaultDownloadLocation.Location = new System.Drawing.Point(373, 29);
            this.buttonChangeChangeDefaultDownloadLocation.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChangeChangeDefaultDownloadLocation.Name = "buttonChangeChangeDefaultDownloadLocation";
            this.buttonChangeChangeDefaultDownloadLocation.Size = new System.Drawing.Size(71, 23);
            this.buttonChangeChangeDefaultDownloadLocation.TabIndex = 6;
            this.buttonChangeChangeDefaultDownloadLocation.Text = "Change...";
            this.buttonChangeChangeDefaultDownloadLocation.UseVisualStyleBackColor = false;
            this.buttonChangeChangeDefaultDownloadLocation.Click += new System.EventHandler(this.buttonChangeChangeDefaultDownloadLocation_Click);
            // 
            // checkBoxDeleteAfterDownload
            // 
            this.checkBoxDeleteAfterDownload.AutoSize = true;
            this.checkBoxDeleteAfterDownload.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.checkBoxDeleteAfterDownload.ForeColor = System.Drawing.Color.White;
            this.checkBoxDeleteAfterDownload.Location = new System.Drawing.Point(12, 187);
            this.checkBoxDeleteAfterDownload.Name = "checkBoxDeleteAfterDownload";
            this.checkBoxDeleteAfterDownload.Size = new System.Drawing.Size(163, 21);
            this.checkBoxDeleteAfterDownload.TabIndex = 7;
            this.checkBoxDeleteAfterDownload.Text = "Delete after download";
            this.checkBoxDeleteAfterDownload.UseVisualStyleBackColor = true;
            this.checkBoxDeleteAfterDownload.CheckedChanged += new System.EventHandler(this.checkBoxDeleteAfterDownload_CheckedChanged);
            // 
            // labelAutoDownloadInterval
            // 
            this.labelAutoDownloadInterval.AutoSize = true;
            this.labelAutoDownloadInterval.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.labelAutoDownloadInterval.ForeColor = System.Drawing.Color.White;
            this.labelAutoDownloadInterval.Location = new System.Drawing.Point(9, 124);
            this.labelAutoDownloadInterval.Name = "labelAutoDownloadInterval";
            this.labelAutoDownloadInterval.Size = new System.Drawing.Size(155, 17);
            this.labelAutoDownloadInterval.TabIndex = 9;
            this.labelAutoDownloadInterval.Text = "Auto download interval:";
            // 
            // numericUpDownAutoDownloadInterval
            // 
            this.numericUpDownAutoDownloadInterval.Font = new System.Drawing.Font("Corbel", 12F);
            this.numericUpDownAutoDownloadInterval.Location = new System.Drawing.Point(12, 144);
            this.numericUpDownAutoDownloadInterval.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.numericUpDownAutoDownloadInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAutoDownloadInterval.Name = "numericUpDownAutoDownloadInterval";
            this.numericUpDownAutoDownloadInterval.Size = new System.Drawing.Size(63, 27);
            this.numericUpDownAutoDownloadInterval.TabIndex = 8;
            this.numericUpDownAutoDownloadInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownAutoDownloadInterval.ValueChanged += new System.EventHandler(this.numericUpDownAutoDownloadInterval_ValueChanged);
            // 
            // Downloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAutoDownloadInterval);
            this.Controls.Add(this.numericUpDownAutoDownloadInterval);
            this.Controls.Add(this.checkBoxDeleteAfterDownload);
            this.Controls.Add(this.buttonChangeChangeDefaultDownloadLocation);
            this.Controls.Add(this.textBoxDefaultDownloadLocation);
            this.Controls.Add(this.labelDefaultDownloadLocation);
            this.Controls.Add(this.labelParallelDownloads);
            this.Controls.Add(this.numericUpDownParallelDownloads);
            this.Name = "Downloads";
            this.Text = "Downloads";
            this.Load += new System.EventHandler(this.Downloads_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParallelDownloads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAutoDownloadInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownParallelDownloads;
        private System.Windows.Forms.Label labelParallelDownloads;
        private System.Windows.Forms.Label labelDefaultDownloadLocation;
        private System.Windows.Forms.TextBox textBoxDefaultDownloadLocation;
        private System.Windows.Forms.Button buttonChangeChangeDefaultDownloadLocation;
        private System.Windows.Forms.CheckBox checkBoxDeleteAfterDownload;
        private System.Windows.Forms.Label labelAutoDownloadInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownAutoDownloadInterval;
    }
}