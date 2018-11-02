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

namespace PutioManager.forms.main
{
    public partial class Downloads : Form
    {

        PutioManager putioManager;

        public Downloads(PutioManager inPutioManager)
        {
            InitializeComponent();
            putioManager = inPutioManager;
        }

        private void FormDownloads_Load(object sender, EventArgs e)
        {
            dataGridViewDownloads.RowsDefaultCellStyle = (new Visuals()).DataGridViewStyle;
        }

        public bool AlreadyDownloading(PutioFile putiofile)
        {
            foreach (DataGridViewRow row in dataGridViewDownloads.Rows)
                if (row.Cells["File"].Value.ToString() == putiofile.name)
                    return true;
            return false;
        }

        private void Downloads_VisibleChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in putioManager.menuStripMain.Items)
                if (item.Alignment == ToolStripItemAlignment.Left)
                    item.Visible = false;

            putioManager.toolStripMenuItemCancelDownload.Visible = true;
            putioManager.toolStripMenuItemCancelAll.Visible = true;
        }
    }
}
