using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PutioManager.classes.helpers;
using System.IO;
using System.Diagnostics;
namespace PutioManager.forms.settings
{
    public partial class Downloads : Form
    {
        public Downloads()
        {
            InitializeComponent();
        }

        EmbeddedFonts embeddedFonts = new EmbeddedFonts();

        private void Downloads_Load(object sender, EventArgs e)
        {
            numericUpDownParallelDownloads.Value = Properties.Settings.Default.ParallelDownloads;
            textBoxDefaultDownloadLocation.Text = Properties.Settings.Default.DownloadDirectory;
            checkBoxDeleteAfterDownload.Checked = Properties.Settings.Default.DeleteAfterDownload;
            numericUpDownAutoDownloadInterval.Value = Properties.Settings.Default.AutoDownloadInterval;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ParallelDownloads = Convert.ToInt32(numericUpDownParallelDownloads.Value);
            Properties.Settings.Default.Save();
        }

        private void buttonChangeChangeDefaultDownloadLocation_Click(object sender, EventArgs e)
        {
            DialogHelper.PrepDialogToCenter(this);
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                var dialog = fbd.ShowDialog();
                if (dialog == DialogResult.Cancel)
                    return;
                else
                {
                    Properties.Settings.Default.DownloadDirectory = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                }
                    
            }
            textBoxDefaultDownloadLocation.Text = Properties.Settings.Default.DownloadDirectory;
        }

        private void checkBoxDeleteAfterDownload_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DeleteAfterDownload = checkBoxDeleteAfterDownload.Checked;
            Properties.Settings.Default.Save();
        }

        private void textBoxDefaultDownloadLocation_DoubleClick(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxDefaultDownloadLocation.Text))
                Process.Start(textBoxDefaultDownloadLocation.Text);
        }

        private void numericUpDownAutoDownloadInterval_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoDownloadInterval = Convert.ToInt32(numericUpDownAutoDownloadInterval.Value);
        }
    }
}
