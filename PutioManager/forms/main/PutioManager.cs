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
using PutioManager.classes.managers;
using PutioManager.forms.sub;
using Newtonsoft.Json.Linq;

namespace PutioManager.forms.main
{
    public partial class PutioManager : Form
    {

        private EmbeddedFonts embeddedfonts;
        private Files PutioFiles;
        private Downloads Downloads;
        private Transfers Transfers;
        private AutoDownloads AutoDownloads;
        private Settings Settings;
        private Visuals Visuals;
        private Web WebMgr;
        private PutioApi.Files filemgr;
        private PutioApi.Zips zipmgr;
        private PutioApi.Transfers trfmgr;
        private ToolStripMenuItem curSelectedMenuItem;
        private Updaters Updaters;
        private Mask mask;
        private BackgroundWorker TimeWorker = new BackgroundWorker();

        public PutioManager()
        {
            InitializeComponent();
        }

        private void FormPutioManager_Load(object sender, EventArgs e)
        {
            filemgr = new PutioApi.Files(Properties.Settings.Default.OAuthToken);
            zipmgr = new PutioApi.Zips(Properties.Settings.Default.OAuthToken);
            trfmgr = new PutioApi.Transfers(Properties.Settings.Default.OAuthToken);

            Visuals = new Visuals();
            embeddedfonts = new EmbeddedFonts();
            WebMgr = new Web(Properties.Settings.Default.ParallelDownloads, PutioFiles);
            Updaters = new Updaters();

            PutioFiles = new Files(this);
            Downloads = new Downloads(this);
            Transfers = new Transfers(this,trfmgr);
            AutoDownloads = new AutoDownloads(this, filemgr, WebMgr, Downloads);
            Settings = new Settings(this);

            menuStripMain.Renderer = new Visuals.MenuRenderer();
            curSelectedMenuItem = toolStripMenuItemFiles;
            toolStripMenuItemFiles.BackColor = ColorTranslator.FromHtml("#FDC214");
            SetGridHeaderFonts();
            Visuals.LoadClickedForm(PutioFiles, panelMain);

            TimeWorker.DoWork += TimeWorker_DoWork;
            TimeWorker.WorkerReportsProgress = true;
            TimeWorker.ProgressChanged += TimeWorker_ReportProgress;
            TimeWorker.RunWorkerCompleted += TimeWorker_Complete;
       
            TimeWorker.RunWorkerAsync();
            mask = new Mask(this);

        }

        private void TimeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                if (TimeWorker.CancellationPending)
                    break;
                int sleeptime = Properties.Settings.Default.AutoDownloadInterval * 1000;
                System.Threading.Thread.Sleep(sleeptime);
                TimeWorker.ReportProgress(0);
            } while (true);
        }

        private void TimeWorker_ReportProgress(object sender, ProgressChangedEventArgs e)
        {
            AutoDownloads.CheckAutoDownloads();
        }

        private void TimeWorker_Complete(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("TimeWorker Stopped");
        }

        private void menuItem_Click(object sender, EventArgs e)
        {


            var menuitem = sender as ToolStripMenuItem;

            foreach (ToolStripMenuItem item in menuStripMain.Items)
            {
                if (item != menuitem)
                    item.BackColor = Color.Transparent;
                else
                    item.BackColor = ColorTranslator.FromHtml("#FDC214");
            }


            if (menuitem.Name == "toolStripMenuItemFiles")
                Visuals.LoadClickedForm(PutioFiles, panelMain);
            if (menuitem.Name == "toolStripMenuItemDownloads")
                Visuals.LoadClickedForm(Downloads, panelMain);
            if (menuitem.Name == "toolStripMenuItemTransfers")
                Visuals.LoadClickedForm(Transfers, panelMain);
            if (menuitem.Name == "toolStripMenuItemAutoDownloads")
                Visuals.LoadClickedForm(AutoDownloads, panelMain);
            if (menuitem.Name == "toolStripMenuItemSettings")
                Visuals.LoadClickedForm(Settings, panelMain);

        }

        private void Files_Click(object sender, EventArgs e)
        {

        }

        public void SetGridHeaderFonts()
        {
            var header_font = new Font(embeddedfonts.Fonts.First(font => font.Name == "Open Sans"), 9, FontStyle.Bold);
            
            embeddedfonts.SetTableHeaderFont(Downloads.dataGridViewDownloads, header_font);
            embeddedfonts.SetTableHeaderFont(Transfers.dataGridViewTransfers, header_font);
            embeddedfonts.SetTableHeaderFont(AutoDownloads.dataGridViewDownloads, header_font);
        }

        private void toolStripMenuItemDownload_Click(object sender, EventArgs e)
        {
            var selectednode = PutioFiles.treeViewPutioFiles.SelectedNode;
            var putiofile = selectednode.Tag as PutioFile;

            if (putiofile.file_type != "FOLDER")
            {
                if (!Downloads.AlreadyDownloading(putiofile))
                {
                    string started = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    string urlPutioApi = "https://api.put.io/v2/";

                    putiofile.downloadlink = new Uri(urlPutioApi + "files/" + putiofile.id + "/download?oauth_token=" + Properties.Settings.Default.OAuthToken);
                    putiofile.download_path = Properties.Settings.Default.DownloadDirectory + @"\" + putiofile.name;

                    var RowIndex = Downloads.dataGridViewDownloads.Rows.Add(putiofile.name, putiofile.file_type, started, "", "Not Started");
                    var NewDownloadRow = Downloads.dataGridViewDownloads.Rows[RowIndex];

                    putiofile.rowinque = NewDownloadRow;
                    NewDownloadRow.Tag = putiofile;
                    WebMgr.QueueDownload(NewDownloadRow);
                }
                else
                    Console.WriteLine(putiofile.name + " is already downloading");
            }
        }

        private void toolStripMenuItemTransfer_Click(object sender, EventArgs e)
        {
            var newtransfer = new NewTransfer(this, Transfers, PutioFiles);
            newtransfer.Show();
        }

        private async void toolStripMenuItemZipDownload_Click(object sender, EventArgs e)
        {
            var selectednode = PutioFiles.treeViewPutioFiles.SelectedNode;
            var putiofile = selectednode.Tag as PutioFile;
            
            string zipstatus = "";
            var createzip_response = await zipmgr.CreateZip(putiofile.id);
            string zipid = JObject.Parse(createzip_response)["zip_id"].ToString();
            PutioFile zipfile = new PutioFile(zipid, putiofile.name + ".zip");
            zipfile.file_type = "ZIP";
            zipfile.parent_id = putiofile.id;
            zipfile.file = putiofile.file;
            string started = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            int RowIndex = Downloads.dataGridViewDownloads.Rows.Add(zipfile.name, zipfile.file_type, started, "", "ZIPPING");

            do
            {
                var zip_properties = await zipmgr.GetZip(zipid);
                zipstatus = zip_properties["zip_status"].ToString();
                if (zipstatus == "DONE")
                    zipfile.downloadlink = new Uri(zip_properties["url"].ToString());
            } while (zipstatus != "DONE");
         

            DataGridViewRow NewDownloadRow = Downloads.dataGridViewDownloads.Rows[RowIndex];

            NewDownloadRow.Cells["Status"].Value = "ZIPPED";

            zipfile.download_path = Properties.Settings.Default.DownloadDirectory + @"\" + zipfile.name;
            zipfile.rowinque = NewDownloadRow;

            NewDownloadRow.Tag = zipfile;

            WebMgr.QueueDownload(NewDownloadRow);
        }

        private async void toolStripMenuItemRefresh_Click(object sender, EventArgs e)
        {
            PutioFile file = PutioFiles.treeViewPutioFiles.SelectedNode.Tag as PutioFile;
            string id;
            if (file.file_type == "FOLDER")
                id = file.id;
            else
                id = file.parent_id;

            Updaters.UpdateTreeView(await filemgr.List(id), PutioFiles.treeViewPutioFiles.SelectedNode);

        }

        private async void toolStripMenuItemDeleteFile_Click(object sender, EventArgs e)
        {
            var putiofile = PutioFiles.treeViewPutioFiles.SelectedNode.Tag as PutioFile;
            DialogHelper.PrepDialogToCenter(this);
            if (putiofile.id != "0")
                if (MessageBox.Show(string.Format("Do you really want to delete {0}", putiofile.name), "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await filemgr.Delete(putiofile.id);
                    putiofile.file.Remove();
                }
        }

        private void toolStripMenuItemCancelDownload_Click(object sender, EventArgs e)
        {
            if (Downloads.dataGridViewDownloads.SelectedRows.Count == 1)
			(Downloads.dataGridViewDownloads.SelectedRows[0].Tag as PutioFile).webclient.CancelAsync();
			else if
			(Downloads.dataGridViewDownloads.SelectedRows.Count > 1) {
				foreach (DataGridViewRow row in Downloads.dataGridViewDownloads.SelectedRows)
				{
					var pfile = row.Tag as PutioFile;
					pfile.canceled = true;
				}
				}
		}

        private void toolStripMenuItemRefreshTransfers_Click(object sender, EventArgs e)
        {
            Transfers.GetTransfers();
        }

        private void toolStripMenuItemCancelTransfer_Click(object sender, EventArgs e)
        {
            Transfers.CancelTransfer();
        }

        private void toolStripMenuItemNewAutoDownload_Click(object sender, EventArgs e)
        {
            var newautodownload = new NewAutoDownload(this, PutioFiles.treeViewPutioFiles.SelectedNode, AutoDownloads);
            newautodownload.Show();
        }

        private void toolStripMenuItemRemoveAutoDownload_Click(object sender, EventArgs e)
        {
            if (AutoDownloads.dataGridViewDownloads.SelectedRows.Count >= 1)
            {
                var selectedrow = AutoDownloads.dataGridViewDownloads.SelectedRows[0];
                AutoDownloads.dataGridViewDownloads.Rows.Remove(selectedrow);
            }
        }

        private void toolStripMenuItemCheckAutoDownloads_Click(object sender, EventArgs e)
        {
            AutoDownloads.CheckAutoDownloads();
        }

        private void PutioManager_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIconMain.Visible = true;
            }
        }

        private void notifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIconMain.Visible = false;
        }

        private void toolStripMenuItemCancelAll_Click(object sender, EventArgs e)
        {
            DialogHelper.PrepDialogToCenter(this);
            var msgbox = MessageBox.Show("This will cancel all downloads. Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            CancelDownloads(msgbox);
        }

        private void CancelDownloads(DialogResult yesno)
        {
            if (yesno == DialogResult.Yes)
            {
                if (WebMgr.FileQueueRow.Count >= 1)
                {
                    foreach (var download in WebMgr.FileQueueRow)
                        download.Cells["Status"].Value = "CANCELED";
                    WebMgr.FileQueueRow.Clear();
                }

                if (WebMgr.Clients.Count >= 1)
                {
                    foreach (var client in WebMgr.Clients)
                        client.CancelAsync();
                }
            }
        }

        private void PutioManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelDownloads(DialogResult.Yes);
        }
    }
}
