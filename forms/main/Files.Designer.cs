namespace PutioManager.forms.main
{
    partial class Files
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Files));
            this.treeViewPutioFiles = new System.Windows.Forms.TreeView();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeViewPutioFiles
            // 
            this.treeViewPutioFiles.BackColor = System.Drawing.Color.DimGray;
            this.treeViewPutioFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPutioFiles.ForeColor = System.Drawing.Color.White;
            this.treeViewPutioFiles.ImageIndex = 0;
            this.treeViewPutioFiles.ImageList = this.imageListIcons;
            this.treeViewPutioFiles.Indent = 15;
            this.treeViewPutioFiles.ItemHeight = 24;
            this.treeViewPutioFiles.LabelEdit = true;
            this.treeViewPutioFiles.Location = new System.Drawing.Point(0, 0);
            this.treeViewPutioFiles.Name = "treeViewPutioFiles";
            this.treeViewPutioFiles.SelectedImageIndex = 0;
            this.treeViewPutioFiles.ShowLines = false;
            this.treeViewPutioFiles.Size = new System.Drawing.Size(800, 450);
            this.treeViewPutioFiles.TabIndex = 0;
            this.treeViewPutioFiles.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewPutioFiles_AfterLabelEdit);
            this.treeViewPutioFiles.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewPutioFiles_BeforeExpand);
            this.treeViewPutioFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPutioFiles_AfterSelect);
            this.treeViewPutioFiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewPutioFiles_NodeMouseClick);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "folder_24.png");
            this.imageListIcons.Images.SetKeyName(1, "document.png");
            // 
            // Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeViewPutioFiles);
            this.Name = "Files";
            this.Text = "Files";
            this.Load += new System.EventHandler(this.FormFoldersAndFiles_Load);
            this.Shown += new System.EventHandler(this.Files_Shown);
            this.VisibleChanged += new System.EventHandler(this.Files_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView treeViewPutioFiles;
        private System.Windows.Forms.ImageList imageListIcons;
    }
}