namespace PutioManager.forms.main
{
    partial class PutioManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PutioManager));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAutoDownloads = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTransfers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZipDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancelDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancelTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRefreshTransfers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNewAutoDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemoveAutoDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCheckAutoDownloads = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDownloads = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.BackColor = System.Drawing.Color.White;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSettings,
            this.toolStripMenuItemAutoDownloads,
            this.toolStripMenuItemTransfers,
            this.toolStripMenuItemDownload,
            this.toolStripMenuItemZipDownload,
            this.toolStripMenuItemDeleteFile,
            this.toolStripMenuItemRefresh,
            this.toolStripMenuItemCancelDownload,
            this.toolStripMenuItemCancelAll,
            this.toolStripMenuItemTransfer,
            this.toolStripMenuItemCancelTransfer,
            this.toolStripMenuItemRefreshTransfers,
            this.toolStripMenuItemNewAutoDownload,
            this.toolStripMenuItemRemoveAutoDownload,
            this.toolStripMenuItemCheckAutoDownloads,
            this.toolStripMenuItemDownloads,
            this.toolStripMenuItemFiles});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(0);
            this.menuStripMain.Size = new System.Drawing.Size(750, 48);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItemSettings.AutoSize = false;
            this.toolStripMenuItemSettings.AutoToolTip = true;
            this.toolStripMenuItemSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemSettings.Image")));
            this.toolStripMenuItemSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemSettings.Text = "…";
            this.toolStripMenuItemSettings.ToolTipText = "Settings";
            this.toolStripMenuItemSettings.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // toolStripMenuItemAutoDownloads
            // 
            this.toolStripMenuItemAutoDownloads.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItemAutoDownloads.AutoSize = false;
            this.toolStripMenuItemAutoDownloads.AutoToolTip = true;
            this.toolStripMenuItemAutoDownloads.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemAutoDownloads.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemAutoDownloads.Image = global::PutioManager.Properties.Resources.Folder_Loading_icon;
            this.toolStripMenuItemAutoDownloads.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemAutoDownloads.Name = "toolStripMenuItemAutoDownloads";
            this.toolStripMenuItemAutoDownloads.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemAutoDownloads.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemAutoDownloads.Text = "AD";
            this.toolStripMenuItemAutoDownloads.ToolTipText = "Auto Downloads";
            this.toolStripMenuItemAutoDownloads.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // toolStripMenuItemTransfers
            // 
            this.toolStripMenuItemTransfers.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItemTransfers.AutoSize = false;
            this.toolStripMenuItemTransfers.AutoToolTip = true;
            this.toolStripMenuItemTransfers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemTransfers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemTransfers.Image = global::PutioManager.Properties.Resources.Folder_Cloud_icon__1_;
            this.toolStripMenuItemTransfers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemTransfers.Name = "toolStripMenuItemTransfers";
            this.toolStripMenuItemTransfers.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemTransfers.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemTransfers.Text = "T";
            this.toolStripMenuItemTransfers.ToolTipText = "Transfers";
            this.toolStripMenuItemTransfers.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // toolStripMenuItemDownload
            // 
            this.toolStripMenuItemDownload.AutoSize = false;
            this.toolStripMenuItemDownload.AutoToolTip = true;
            this.toolStripMenuItemDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemDownload.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemDownload.Image = global::PutioManager.Properties.Resources.Download_2_icon;
            this.toolStripMenuItemDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemDownload.Name = "toolStripMenuItemDownload";
            this.toolStripMenuItemDownload.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemDownload.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemDownload.Text = "Download";
            this.toolStripMenuItemDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemDownload.ToolTipText = "Download";
            this.toolStripMenuItemDownload.Click += new System.EventHandler(this.toolStripMenuItemDownload_Click);
            // 
            // toolStripMenuItemZipDownload
            // 
            this.toolStripMenuItemZipDownload.AutoSize = false;
            this.toolStripMenuItemZipDownload.AutoToolTip = true;
            this.toolStripMenuItemZipDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemZipDownload.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemZipDownload.Image = global::PutioManager.Properties.Resources.File_Zip_icon;
            this.toolStripMenuItemZipDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemZipDownload.Name = "toolStripMenuItemZipDownload";
            this.toolStripMenuItemZipDownload.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemZipDownload.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemZipDownload.Text = "F";
            this.toolStripMenuItemZipDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemZipDownload.ToolTipText = "Zip & Download";
            this.toolStripMenuItemZipDownload.Click += new System.EventHandler(this.toolStripMenuItemZipDownload_Click);
            // 
            // toolStripMenuItemDeleteFile
            // 
            this.toolStripMenuItemDeleteFile.AutoSize = false;
            this.toolStripMenuItemDeleteFile.AutoToolTip = true;
            this.toolStripMenuItemDeleteFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemDeleteFile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemDeleteFile.Image = global::PutioManager.Properties.Resources.Close_Window_icon1;
            this.toolStripMenuItemDeleteFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemDeleteFile.Name = "toolStripMenuItemDeleteFile";
            this.toolStripMenuItemDeleteFile.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemDeleteFile.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemDeleteFile.Text = "F";
            this.toolStripMenuItemDeleteFile.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemDeleteFile.ToolTipText = "Delete File";
            this.toolStripMenuItemDeleteFile.Click += new System.EventHandler(this.toolStripMenuItemDeleteFile_Click);
            // 
            // toolStripMenuItemRefresh
            // 
            this.toolStripMenuItemRefresh.AutoSize = false;
            this.toolStripMenuItemRefresh.AutoToolTip = true;
            this.toolStripMenuItemRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemRefresh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemRefresh.Image = global::PutioManager.Properties.Resources.Refresh_icon;
            this.toolStripMenuItemRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemRefresh.Name = "toolStripMenuItemRefresh";
            this.toolStripMenuItemRefresh.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemRefresh.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemRefresh.Text = "F";
            this.toolStripMenuItemRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemRefresh.ToolTipText = "Refresh Folder";
            this.toolStripMenuItemRefresh.Click += new System.EventHandler(this.toolStripMenuItemRefresh_Click);
            // 
            // toolStripMenuItemCancelDownload
            // 
            this.toolStripMenuItemCancelDownload.AutoSize = false;
            this.toolStripMenuItemCancelDownload.AutoToolTip = true;
            this.toolStripMenuItemCancelDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemCancelDownload.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemCancelDownload.Image = global::PutioManager.Properties.Resources.cancelfile;
            this.toolStripMenuItemCancelDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemCancelDownload.Name = "toolStripMenuItemCancelDownload";
            this.toolStripMenuItemCancelDownload.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemCancelDownload.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemCancelDownload.Text = "F";
            this.toolStripMenuItemCancelDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemCancelDownload.ToolTipText = "Cancel Download";
            this.toolStripMenuItemCancelDownload.Click += new System.EventHandler(this.toolStripMenuItemCancelDownload_Click);
            // 
            // toolStripMenuItemCancelAll
            // 
            this.toolStripMenuItemCancelAll.AutoSize = false;
            this.toolStripMenuItemCancelAll.AutoToolTip = true;
            this.toolStripMenuItemCancelAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemCancelAll.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemCancelAll.Image = global::PutioManager.Properties.Resources.Close_Window_icon1;
            this.toolStripMenuItemCancelAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemCancelAll.Name = "toolStripMenuItemCancelAll";
            this.toolStripMenuItemCancelAll.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemCancelAll.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemCancelAll.Text = "F";
            this.toolStripMenuItemCancelAll.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemCancelAll.ToolTipText = "Cancel Download";
            this.toolStripMenuItemCancelAll.Click += new System.EventHandler(this.toolStripMenuItemCancelAll_Click);
            // 
            // toolStripMenuItemTransfer
            // 
            this.toolStripMenuItemTransfer.AutoSize = false;
            this.toolStripMenuItemTransfer.AutoToolTip = true;
            this.toolStripMenuItemTransfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemTransfer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemTransfer.Image = global::PutioManager.Properties.Resources.Add_icon;
            this.toolStripMenuItemTransfer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemTransfer.Name = "toolStripMenuItemTransfer";
            this.toolStripMenuItemTransfer.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemTransfer.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemTransfer.Text = "F";
            this.toolStripMenuItemTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemTransfer.ToolTipText = "New Transfer";
            this.toolStripMenuItemTransfer.Click += new System.EventHandler(this.toolStripMenuItemTransfer_Click);
            // 
            // toolStripMenuItemCancelTransfer
            // 
            this.toolStripMenuItemCancelTransfer.AutoSize = false;
            this.toolStripMenuItemCancelTransfer.AutoToolTip = true;
            this.toolStripMenuItemCancelTransfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemCancelTransfer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemCancelTransfer.Image = global::PutioManager.Properties.Resources.Close_Window_icon;
            this.toolStripMenuItemCancelTransfer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemCancelTransfer.Name = "toolStripMenuItemCancelTransfer";
            this.toolStripMenuItemCancelTransfer.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemCancelTransfer.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemCancelTransfer.Text = "F";
            this.toolStripMenuItemCancelTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemCancelTransfer.ToolTipText = "Cancel Transfer";
            this.toolStripMenuItemCancelTransfer.Click += new System.EventHandler(this.toolStripMenuItemCancelTransfer_Click);
            // 
            // toolStripMenuItemRefreshTransfers
            // 
            this.toolStripMenuItemRefreshTransfers.AutoSize = false;
            this.toolStripMenuItemRefreshTransfers.AutoToolTip = true;
            this.toolStripMenuItemRefreshTransfers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemRefreshTransfers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemRefreshTransfers.Image = global::PutioManager.Properties.Resources.Refresh_icon;
            this.toolStripMenuItemRefreshTransfers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemRefreshTransfers.Name = "toolStripMenuItemRefreshTransfers";
            this.toolStripMenuItemRefreshTransfers.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemRefreshTransfers.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemRefreshTransfers.Text = "F";
            this.toolStripMenuItemRefreshTransfers.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemRefreshTransfers.ToolTipText = "Refresh Transfers";
            this.toolStripMenuItemRefreshTransfers.Click += new System.EventHandler(this.toolStripMenuItemRefreshTransfers_Click);
            // 
            // toolStripMenuItemNewAutoDownload
            // 
            this.toolStripMenuItemNewAutoDownload.AutoSize = false;
            this.toolStripMenuItemNewAutoDownload.AutoToolTip = true;
            this.toolStripMenuItemNewAutoDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemNewAutoDownload.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemNewAutoDownload.Image = global::PutioManager.Properties.Resources.Add_icon;
            this.toolStripMenuItemNewAutoDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemNewAutoDownload.Name = "toolStripMenuItemNewAutoDownload";
            this.toolStripMenuItemNewAutoDownload.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemNewAutoDownload.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemNewAutoDownload.Text = "F";
            this.toolStripMenuItemNewAutoDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemNewAutoDownload.ToolTipText = "Add Auto Download";
            this.toolStripMenuItemNewAutoDownload.Click += new System.EventHandler(this.toolStripMenuItemNewAutoDownload_Click);
            // 
            // toolStripMenuItemRemoveAutoDownload
            // 
            this.toolStripMenuItemRemoveAutoDownload.AutoSize = false;
            this.toolStripMenuItemRemoveAutoDownload.AutoToolTip = true;
            this.toolStripMenuItemRemoveAutoDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemRemoveAutoDownload.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemRemoveAutoDownload.Image = global::PutioManager.Properties.Resources.Close_Window_icon;
            this.toolStripMenuItemRemoveAutoDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemRemoveAutoDownload.Name = "toolStripMenuItemRemoveAutoDownload";
            this.toolStripMenuItemRemoveAutoDownload.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemRemoveAutoDownload.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemRemoveAutoDownload.Text = "F";
            this.toolStripMenuItemRemoveAutoDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemRemoveAutoDownload.ToolTipText = "Remove Auto Download";
            this.toolStripMenuItemRemoveAutoDownload.Click += new System.EventHandler(this.toolStripMenuItemRemoveAutoDownload_Click);
            // 
            // toolStripMenuItemCheckAutoDownloads
            // 
            this.toolStripMenuItemCheckAutoDownloads.AutoSize = false;
            this.toolStripMenuItemCheckAutoDownloads.AutoToolTip = true;
            this.toolStripMenuItemCheckAutoDownloads.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemCheckAutoDownloads.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemCheckAutoDownloads.Image = global::PutioManager.Properties.Resources.Refresh_icon;
            this.toolStripMenuItemCheckAutoDownloads.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemCheckAutoDownloads.Name = "toolStripMenuItemCheckAutoDownloads";
            this.toolStripMenuItemCheckAutoDownloads.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemCheckAutoDownloads.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemCheckAutoDownloads.Text = "F";
            this.toolStripMenuItemCheckAutoDownloads.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemCheckAutoDownloads.ToolTipText = "Check Auto Downloads";
            this.toolStripMenuItemCheckAutoDownloads.Click += new System.EventHandler(this.toolStripMenuItemCheckAutoDownloads_Click);
            // 
            // toolStripMenuItemDownloads
            // 
            this.toolStripMenuItemDownloads.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItemDownloads.AutoSize = false;
            this.toolStripMenuItemDownloads.AutoToolTip = true;
            this.toolStripMenuItemDownloads.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemDownloads.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemDownloads.Image = global::PutioManager.Properties.Resources.Folder_Download_icon;
            this.toolStripMenuItemDownloads.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemDownloads.Name = "toolStripMenuItemDownloads";
            this.toolStripMenuItemDownloads.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemDownloads.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemDownloads.Text = "D";
            this.toolStripMenuItemDownloads.ToolTipText = "Downloads";
            this.toolStripMenuItemDownloads.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // toolStripMenuItemFiles
            // 
            this.toolStripMenuItemFiles.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItemFiles.AutoSize = false;
            this.toolStripMenuItemFiles.AutoToolTip = true;
            this.toolStripMenuItemFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemFiles.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemFiles.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemFiles.Image")));
            this.toolStripMenuItemFiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemFiles.Name = "toolStripMenuItemFiles";
            this.toolStripMenuItemFiles.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemFiles.Size = new System.Drawing.Size(48, 48);
            this.toolStripMenuItemFiles.Text = "F";
            this.toolStripMenuItemFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItemFiles.ToolTipText = "Files & Folders";
            this.toolStripMenuItemFiles.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DimGray;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 48);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 462);
            this.panelMain.TabIndex = 1;
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "Putio Manager";
            this.notifyIconMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMain_MouseDoubleClick);
            // 
            // PutioManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 510);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(766, 549);
            this.Name = "PutioManager";
            this.Text = "Putio Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PutioManager_FormClosing);
            this.Load += new System.EventHandler(this.FormPutioManager_Load);
            this.Resize += new System.EventHandler(this.PutioManager_Resize);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDownloads;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTransfers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFiles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAutoDownloads;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDownload;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTransfer;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZipDownload;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRefresh;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteFile;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancelDownload;
        public System.Windows.Forms.MenuStrip menuStripMain;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRefreshTransfers;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancelTransfer;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewAutoDownload;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveAutoDownload;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCheckAutoDownloads;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancelAll;
    }
}

