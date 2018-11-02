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
using Newtonsoft.Json.Linq;
using System.IO;

namespace PutioManager.forms.main
{
    public partial class AutoDownloads : Form
    {

        EmbeddedFonts embeddedFonts = new EmbeddedFonts();
        PutioManager putioManager;
        PutioApi.Files filemgr;
        Web WebMgr;
        Downloads downloads;

        public AutoDownloads(PutioManager inPutioManager, PutioApi.Files inFileMgr, Web inWebMgr, Downloads inDownloads)
        {
            InitializeComponent();
            putioManager = inPutioManager;
            filemgr = inFileMgr;
            WebMgr = inWebMgr;
            downloads = inDownloads;
        }

        private void FormAutoDownloads_Load(object sender, EventArgs e)
        {
            dataGridViewDownloads.RowsDefaultCellStyle = (new Visuals()).DataGridViewStyle;
        }

        private void AutoDownloads_VisibleChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in putioManager.menuStripMain.Items)
                if (item.Alignment == ToolStripItemAlignment.Left)
                    item.Visible = false;

            putioManager.toolStripMenuItemNewAutoDownload.Visible = true;
            putioManager.toolStripMenuItemRemoveAutoDownload.Visible = true;
            putioManager.toolStripMenuItemCheckAutoDownloads.Visible = true;

        }

        public void CheckAutoDownloads()
        {
            foreach (DataGridViewRow row in dataGridViewDownloads.Rows)
            {
                AutoDownloadFiles(row.Tag as PutioAutoDownload);
            }
        }

        private string GetFileExtension(string inStrFileName)
        {
            return Path.GetExtension(inStrFileName.ToLower()).Trim('.');
        }

        private async void AutoDownloadFiles(PutioAutoDownload inParentAutoDownload)
        {
            var response = await filemgr.List(inParentAutoDownload.folder_id);
            List<string> allowed_extensions = new List<string>();
            allowed_extensions.AddRange(inParentAutoDownload.allowed_extensions.Split(',').ToArray());

            foreach (JObject jobject in response)
            {
                var putiofile = new PutioFile(jobject);
                string download_path = Path.Combine(inParentAutoDownload.download_path);

                if (inParentAutoDownload.keep_folder_structure)
                    download_path = Path.Combine(inParentAutoDownload.download_path, inParentAutoDownload.folder_name);

                //Console.WriteLine(download_path);

                //Console.WriteLine("filename = " + putiofile.name);
                var childAutoDownload = new PutioAutoDownload(putiofile.name, 
                    putiofile.id, download_path,
                    inParentAutoDownload.min_download_size,
                    inParentAutoDownload.allowed_extensions, 
                    inParentAutoDownload.keep_folder_structure);
                    
                putiofile.download_path = childAutoDownload.download_path + @"\" + putiofile.name;

                if (jobject["file_type"].ToString() == "FOLDER")
                {
                    AutoDownloadFiles(childAutoDownload);
                }
                else
                {
                    var match = allowed_extensions.FirstOrDefault(filext => filext.Contains(GetFileExtension(putiofile.name)));
                    if (match != null)
                    {
                        if (putiofile.file_type != "FOLDER")
                        {
                            if (!downloads.AlreadyDownloading(putiofile))
                            {
                                string started = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                                string urlPutioApi = "https://api.put.io/v2/";

                                putiofile.downloadlink = new Uri(urlPutioApi + "files/" + putiofile.id + "/download?oauth_token=" + Properties.Settings.Default.OAuthToken);
                                putiofile.download_path = Path.Combine(download_path, putiofile.name);

                                var RowIndex = downloads.dataGridViewDownloads.Rows.Add(putiofile.name, putiofile.file_type, started, "", "Not Started");
                                var NewDownloadRow = downloads.dataGridViewDownloads.Rows[RowIndex];

                                putiofile.rowinque = NewDownloadRow;
                                NewDownloadRow.Tag = putiofile;
                                WebMgr.QueueDownload(NewDownloadRow);
                            }
                            else
                                Console.WriteLine(putiofile.name + " is already downloading");
                        }

                    }
                }
            }

        }
    }
}
