using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Diagnostics;
using PutioManager.forms.main;
using PutioManager.classes.helpers;
using PutioApi;

namespace PutioManager.classes.managers
{
    public class Web
    {
        public readonly List<WebClient> Clients = new List<WebClient>();
        public Queue<DataGridViewRow> FileQueueRow = new Queue<DataGridViewRow>();
        private forms.main.Files foldersAndFiles;

        public Web(int inIntParallelClients, forms.main.Files infoldersAndFiles)
        {
            foldersAndFiles = infoldersAndFiles;
            for (int i = 0; i < inIntParallelClients; i++)
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += (s,e) => WebClient_DownloadProgressChanged(s, e);
                client.DownloadFileCompleted += WebClient_DownloadFileCompleted;
                Clients.Add(client);
            }
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            var putiofile = e.UserState as PutioFile;
            DataGridViewRow FileQueRow = putiofile.rowinque;
            string bytesrecieved = ((e.BytesReceived / 1024d) / 1024d).ToString("0.0");
            string totalbytes = ((e.TotalBytesToReceive / 1024d) / 1024d).ToString("0.0");
            FileQueRow.Cells["Status"].Value = string.Format("{0} MB / {1} MB", bytesrecieved, totalbytes);
        }

        private async void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            var putiofile = e.UserState as PutioFile;
            DataGridViewRow FileQueRow = putiofile.rowinque;

            var downloadpath = putiofile.download_path + ".download";

            if (e.Cancelled)
            {
                FileQueRow.Cells["Status"].Value = "CANCELED";
                if (File.Exists(downloadpath))
                    File.Delete(downloadpath);
            }
            else if(e.Error != null)
            {
                FileQueRow.Cells["Status"].Value = "ERROR";
                if (File.Exists(downloadpath))
                    File.Delete(downloadpath);
            }
            else
            {
                FileQueRow.Cells["Status"].Value = "COMPLETE";
                File.Move(downloadpath, putiofile.download_path);
                if (Properties.Settings.Default.DeleteAfterDownload & putiofile.parent_id != "0")
                {
                    if (putiofile.file_type != "ZIP")
                        await (new PutioApi.Files(Properties.Settings.Default.OAuthToken)).Delete(putiofile.id);
                    else
                        await (new PutioApi.Files(Properties.Settings.Default.OAuthToken)).Delete(putiofile.parent_id);
                }
            }
            FileQueRow.Cells["Completed"].Value = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            CheckDownloadQueue();
        }

        private void CheckDownloadQueue()
        {
            if (FileQueueRow.Any())
            {
                foreach (WebClient wc in Clients)
                {
                    if (!wc.IsBusy)
                    {
                        var DownloadQueueRow = FileQueueRow.Dequeue();
                        var putiofile = DownloadQueueRow.Tag as PutioFile;
                        DownloadQueueRow.Cells["Status"].Value = "QUEUED";
                        putiofile.webclient = wc;
                        if (!Directory.Exists(Path.GetDirectoryName(putiofile.download_path)))
                            Directory.CreateDirectory(Path.GetDirectoryName(putiofile.download_path));
                        wc.DownloadFileAsync(putiofile.downloadlink, putiofile.download_path + ".download", putiofile);
                        return;
                    }
                }
            }
        }

        public void QueueDownload(DataGridViewRow inNewDownloadRow)
        {
            FileQueueRow.Enqueue(inNewDownloadRow);
            CheckDownloadQueue();
        }

        protected virtual void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
