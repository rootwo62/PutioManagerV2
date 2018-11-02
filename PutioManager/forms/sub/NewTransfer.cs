using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PutioManager.forms.main;
using PutioManager.classes.helpers;
using Newtonsoft.Json.Linq;

namespace PutioManager.forms.sub
{
    public partial class NewTransfer : Form
    {

        private Transfers transfers;
        private Files files;
        private PutioApi.Transfers trfmgr;
        private Form parent;
        private Mask mask;

        public NewTransfer(Form inParentForm, Transfers inTransfers, Files inFiles)
        {
            InitializeComponent();
            transfers = inTransfers;
            files = inFiles;
            trfmgr = new PutioApi.Transfers(Properties.Settings.Default.OAuthToken);
            parent = inParentForm;

            mask = new Mask(inParentForm, inParentForm);
            Owner = mask;
            mask.Show();

            CenterToParent();
            mask.Move += AdjustPosition;
            mask.Resize += AdjustPosition;
        }

        private async void buttonAccept_click(object sender, EventArgs e)
        {
            if (Clipboard.GetText().ToString().StartsWith("magnet:"))
            {
                string url = Clipboard.GetText().ToString();
                var file = files.treeViewPutioFiles.SelectedNode.Tag as PutioFile;
                var option = MessageBox.Show(string.Format("Download {0} to {1}", magnet(url), file.name), "New Transfer", MessageBoxButtons.OKCancel);

                if (option == DialogResult.OK)
                {
                    await trfmgr.Add(url, file.id);
                    transfers.GetTransfers();
                }
            }
            else
                MessageBox.Show("Copy a magnet link and try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string magnet(string inStrUrl)
        {
            return inStrUrl.Split('=')[2].Replace("&tr", "").Replace("+", " ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
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

        private void NewTransfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            mask.Dispose();
            Dispose();
        }
    }
}
