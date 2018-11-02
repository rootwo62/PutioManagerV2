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
using PutioManager.forms.main;

namespace PutioManager.forms.sub
{
    public partial class NewAutoDownload : Form
    {

        Mask mask;
        Form parent;
        AutoDownloads autoDownloads;
        TreeNode SelectedFile;
        PutioFile putiofile;
 
        string path = Properties.Settings.Default.DownloadDirectory;

        public NewAutoDownload(Form inParentForm, TreeNode inSelectedFile, AutoDownloads inAutoDownloads)
        {
            
            InitializeComponent();

            autoDownloads = inAutoDownloads;
            SelectedFile = inSelectedFile;
            putiofile = SelectedFile.Tag as PutioFile;
            parent = inParentForm;

            mask = new Mask(inParentForm, inParentForm);
            Owner = mask;
            mask.Show();

            CenterToParent();
            mask.Move += AdjustPosition;
            mask.Resize += AdjustPosition;
        }

        private void NewAutoDownload_Load(object sender, EventArgs e)
        {
            
            labelTitle.Text = "New Auto Download: " + putiofile.name;
            textBoxDownloadLocation.Text = path;
        }

        private void buttonAccept_click(object sender, EventArgs e)
        {
            var putiofile = SelectedFile.Tag as PutioFile;

            var autodownload = new PutioAutoDownload(putiofile.name,
                putiofile.id, 
                textBoxDownloadLocation.Text, 
                Convert.ToInt32(textBoxMinDownloadSize.Text), 
                textBoxAllowedExtensions.Text, checkBoxDownloadToParentFolder.Checked);

            var index = autoDownloads.dataGridViewDownloads.Rows.Add(putiofile.name, 
                autodownload.allowed_extensions, 
                autodownload.min_download_size.ToString(),
                autodownload.download_path);

            autoDownloads.dataGridViewDownloads.Rows[index].Tag = autodownload;

             Close();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonChangeChangeDefaultDownloadLocation_Click(object sender, EventArgs e)
        {
            DialogHelper.PrepDialogToCenter(this);
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBoxDownloadLocation.Text = fbd.SelectedPath;
                    path = textBoxDownloadLocation.Text;
                }
            }
        }

        private void AdjustPosition(object sender, EventArgs e)
        {
            if (!mask.IsDisposed)
            {
                CenterToParent();
                if (parent.WindowState == FormWindowState.Minimized)
                    Hide();
                else
                    Show();
            }
        }

        private void NewAutoDownload_FormClosing(object sender, FormClosingEventArgs e)
        {
            mask.Dispose();
            Dispose();
        }
    }
}
