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
using PutioManager;

namespace PutioManager.forms.main
{
    public partial class Files : Form
    {
        public Files(PutioManager inPutioManager)
        {
            InitializeComponent();
            putioManager = inPutioManager;
        }

        PutioApi.Files filemgr;
        PutioApi.Zips zipmgr;
        PutioApi.Transfers trfrmgr;

        PutioManager putioManager;

        Updaters updaters;
        EmbeddedFonts embeddedfonts;

        public TreeNode SelectedNode;

        public string OAuthToken;
        public TreeNode rootnode;

        private async void FormFoldersAndFiles_Load(object sender, EventArgs e)
        {
            OAuthToken = Properties.Settings.Default.OAuthToken;

            filemgr = new PutioApi.Files(OAuthToken);
            zipmgr = new PutioApi.Zips(OAuthToken);
            trfrmgr = new PutioApi.Transfers(OAuthToken);
            updaters = new Updaters();
            embeddedfonts = new EmbeddedFonts();

            InitializeTreeView(treeViewPutioFiles);
            updaters.UpdateTreeView(await filemgr.List("0"), rootnode);


        }

        void InitializeTreeView(TreeView inTreview)
        {
            int FontSize = 9;
            var TreeViewFont = new Font(embeddedfonts.Fonts.First(font => font.Name == "Open Sans"), FontSize);

            var root = new PutioFile("0", "putio files");
            root.file_type = "FOLDER";
            root.parent_id = "0";
            inTreview.Nodes.Clear();
            rootnode = inTreview.Nodes.Add("putio files");
            rootnode.Tag = root;

            inTreview.ShowNodeToolTips = Properties.Settings.Default.ShowToolTips;
            inTreview.SelectedNode = inTreview.Nodes[0];
            inTreview.Font = TreeViewFont;
        }

        private async void treeViewPutioFiles_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeViewPutioFiles.SelectedNode = e.Node;
            PutioFile file = e.Node.Tag as PutioFile;

            if (e.Node != rootnode)
                updaters.UpdateTreeView(await filemgr.List(file.id), e.Node);
        }

        private void treeViewPutioFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectedNode = e.Node;
        }

        private void treeViewPutioFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private async void treeViewPutioFiles_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)    
                await filemgr.Rename((e.Node.Tag as PutioFile).id, e.Label);
        }

        private void Files_VisibleChanged(object sender, EventArgs e)
        {


            foreach (ToolStripMenuItem item in putioManager.menuStripMain.Items)
                if (item.Alignment == ToolStripItemAlignment.Left)
                    item.Visible = false;

            putioManager.toolStripMenuItemDownload.Visible = true;
            putioManager.toolStripMenuItemDeleteFile.Visible = true;
            putioManager.toolStripMenuItemRefresh.Visible = true;
            putioManager.toolStripMenuItemZipDownload.Visible = true;
        }

        private void Files_Shown(object sender, EventArgs e)
        {

        }
    }
}
