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
using Newtonsoft.Json.Linq;
namespace PutioManager.forms.main
{
    public partial class Transfers : Form
    {

        PutioApi.Transfers trfmgr;
        PutioManager putioManager;

        public Transfers(PutioManager inPutioManager, PutioApi.Transfers inTransfers)
        {
            InitializeComponent();
            trfmgr = inTransfers;
            putioManager = inPutioManager;
        }

        private void FormTransfers_Load(object sender, EventArgs e)
        {
            GetTransfers();
            dataGridViewTransfers.RowsDefaultCellStyle = (new Visuals()).DataGridViewStyle;
        }

        public async void GetTransfers()
        {
            dataGridViewTransfers.Rows.Clear();
            var transferlist = await trfmgr.List();
            foreach (JObject transfer in transferlist)
            {

                string name = transfer["name"].ToString();
                string id = transfer["id"].ToString();
                string peers = transfer["peers_connected"].ToString();
                string uploaded = ((Convert.ToInt64(transfer["uploaded"]) / 1024) / 1024).ToString() + " Mb";
                string status = transfer["status"].ToString();
                string parentid = transfer["save_parent_id"].ToString();
                string source = transfer["source"].ToString();
                string started = transfer["created_at"].ToString();
                string size = transfer["size"].ToString();

                var putiotransfer = new PutioTransfer(name, id);
                putiotransfer.save_parent_id = parentid;
                putiotransfer.source = source;
                putiotransfer.status = status;
                putiotransfer.started = started;
                putiotransfer.size = size;

                size = ((Convert.ToInt64(size) / 1024) / 1024).ToString() + " Mb";

                int rowindex = dataGridViewTransfers.Rows.Add(name, size, peers, uploaded, started, status);
                var row = dataGridViewTransfers.Rows[rowindex];
                row.Tag = putiotransfer;

            }

            dataGridViewTransfers.Sort(dataGridViewTransfers.Columns[4], ListSortDirection.Descending);

        }

        private void Transfers_VisibleChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in putioManager.menuStripMain.Items)
                if (item.Alignment == ToolStripItemAlignment.Left)
                    item.Visible = false;

            putioManager.toolStripMenuItemTransfer.Visible = true;
            putioManager.toolStripMenuItemRefreshTransfers.Visible = true;
            putioManager.toolStripMenuItemCancelTransfer.Visible = true;
        }

        public async void CancelTransfer()
        {
            if (dataGridViewTransfers.SelectedRows.Count >= 1)
            {
                var id = (dataGridViewTransfers.SelectedRows[0].Tag as PutioTransfer).file_id;
                await trfmgr.Cancel(id);
                GetTransfers();
            }
        }
    }
}
