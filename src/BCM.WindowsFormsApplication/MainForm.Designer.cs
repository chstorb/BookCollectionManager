namespace BCM.WindowsFormsApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainerNav = new System.Windows.Forms.SplitContainer();
            this.buttonSelectBooks = new System.Windows.Forms.Button();
            this.buttonSelectCategories = new System.Windows.Forms.Button();
            this.buttonSelectAuthors = new System.Windows.Forms.Button();
            this.panelStartup = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.fileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filePrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePrintPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.editSelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsCustomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.helpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.treeViewAuthors = new BCM.WindowsFormsApplication.TreeViewAuthors();
            this.treeViewCategories = new BCM.WindowsFormsApplication.TreeViewCategories();
            this.treeViewBooks = new BCM.WindowsFormsApplication.TreeViewBooks();
            this.bookList = new BCM.WindowsFormsApplication.BookList();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNav)).BeginInit();
            this.splitContainerNav.Panel1.SuspendLayout();
            this.splitContainerNav.Panel2.SuspendLayout();
            this.splitContainerNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1596, 24);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1000, 19);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 19);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 68);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainerNav);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bookList);
            this.splitContainer1.Panel2.Controls.Add(this.panelStartup);
            this.splitContainer1.Size = new System.Drawing.Size(1596, 561);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainerNav
            // 
            this.splitContainerNav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerNav.IsSplitterFixed = true;
            this.splitContainerNav.Location = new System.Drawing.Point(0, 0);
            this.splitContainerNav.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerNav.Name = "splitContainerNav";
            this.splitContainerNav.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerNav.Panel1
            // 
            this.splitContainerNav.Panel1.Controls.Add(this.treeViewAuthors);
            this.splitContainerNav.Panel1.Controls.Add(this.treeViewCategories);
            this.splitContainerNav.Panel1.Controls.Add(this.treeViewBooks);
            this.splitContainerNav.Panel1.Resize += new System.EventHandler(this.splitContainerNav_Panel1_Resize);
            // 
            // splitContainerNav.Panel2
            // 
            this.splitContainerNav.Panel2.Controls.Add(this.buttonSelectBooks);
            this.splitContainerNav.Panel2.Controls.Add(this.buttonSelectCategories);
            this.splitContainerNav.Panel2.Controls.Add(this.buttonSelectAuthors);
            this.splitContainerNav.Panel2.Resize += new System.EventHandler(this.splitContainerNav_Panel2_Resize);
            this.splitContainerNav.Panel2MinSize = 150;
            this.splitContainerNav.Size = new System.Drawing.Size(284, 561);
            this.splitContainerNav.SplitterDistance = 408;
            this.splitContainerNav.SplitterIncrement = 50;
            this.splitContainerNav.TabIndex = 0;
            this.splitContainerNav.Resize += new System.EventHandler(this.splitContainerNav_Resize);
            // 
            // buttonSelectBooks
            // 
            this.buttonSelectBooks.BackgroundImage = global::BCM.WindowsFormsApplication.Properties.Resources.buttonSelectBooks_BackgroundImage;
            this.buttonSelectBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelectBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelectBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectBooks.Location = new System.Drawing.Point(0, 0);
            this.buttonSelectBooks.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectBooks.Name = "buttonSelectBooks";
            this.buttonSelectBooks.Size = new System.Drawing.Size(282, 50);
            this.buttonSelectBooks.TabIndex = 0;
            this.buttonSelectBooks.Text = "Books";
            this.buttonSelectBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSelectBooks.UseVisualStyleBackColor = false;
            this.buttonSelectBooks.Click += new System.EventHandler(this.buttonSelectBooks_Click);
            // 
            // buttonSelectCategories
            // 
            this.buttonSelectCategories.BackgroundImage = global::BCM.WindowsFormsApplication.Properties.Resources.buttonSelectCategories_BackgroundImage;
            this.buttonSelectCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelectCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSelectCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectCategories.Location = new System.Drawing.Point(0, 48);
            this.buttonSelectCategories.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectCategories.MaximumSize = new System.Drawing.Size(0, 50);
            this.buttonSelectCategories.Name = "buttonSelectCategories";
            this.buttonSelectCategories.Size = new System.Drawing.Size(0, 50);
            this.buttonSelectCategories.TabIndex = 1;
            this.buttonSelectCategories.Text = "Categories";
            this.buttonSelectCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSelectCategories.UseVisualStyleBackColor = true;
            this.buttonSelectCategories.Click += new System.EventHandler(this.buttonSelectCategories_Click);
            // 
            // buttonSelectAuthors
            // 
            this.buttonSelectAuthors.BackgroundImage = global::BCM.WindowsFormsApplication.Properties.Resources.buttonSelectAuthors_BackgroundImage;
            this.buttonSelectAuthors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelectAuthors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSelectAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectAuthors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectAuthors.Location = new System.Drawing.Point(0, 98);
            this.buttonSelectAuthors.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectAuthors.Name = "buttonSelectAuthors";
            this.buttonSelectAuthors.Size = new System.Drawing.Size(282, 50);
            this.buttonSelectAuthors.TabIndex = 2;
            this.buttonSelectAuthors.Text = "Authors";
            this.buttonSelectAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectAuthors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSelectAuthors.UseVisualStyleBackColor = true;
            this.buttonSelectAuthors.Click += new System.EventHandler(this.buttonSelectAuthors_Click);
            // 
            // panelStartup
            // 
            this.panelStartup.BackColor = System.Drawing.SystemColors.Info;
            this.panelStartup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelStartup.Location = new System.Drawing.Point(25, 18);
            this.panelStartup.Margin = new System.Windows.Forms.Padding(4);
            this.panelStartup.Name = "panelStartup";
            this.panelStartup.Size = new System.Drawing.Size(265, 122);
            this.panelStartup.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 1);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.menuStripMain);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelMain);
            this.splitContainer2.Size = new System.Drawing.Size(1596, 66);
            this.splitContainer2.SplitterDistance = 29;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 2;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1596, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNewToolStripMenuItem,
            this.fileOpenToolStripMenuItem,
            this.toolStripSeparator,
            this.fileSaveToolStripMenuItem,
            this.fileSaveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.filePrintToolStripMenuItem,
            this.filePrintPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // fileNewToolStripMenuItem
            // 
            this.fileNewToolStripMenuItem.Enabled = false;
            this.fileNewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileNewToolStripMenuItem.Image")));
            this.fileNewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileNewToolStripMenuItem.Name = "fileNewToolStripMenuItem";
            this.fileNewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileNewToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.fileNewToolStripMenuItem.Text = "&New";
            // 
            // fileOpenToolStripMenuItem
            // 
            this.fileOpenToolStripMenuItem.Enabled = false;
            this.fileOpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileOpenToolStripMenuItem.Image")));
            this.fileOpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            this.fileOpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpenToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.fileOpenToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(168, 6);
            // 
            // fileSaveToolStripMenuItem
            // 
            this.fileSaveToolStripMenuItem.Enabled = false;
            this.fileSaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileSaveToolStripMenuItem.Image")));
            this.fileSaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileSaveToolStripMenuItem.Name = "fileSaveToolStripMenuItem";
            this.fileSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSaveToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.fileSaveToolStripMenuItem.Text = "&Save";
            // 
            // fileSaveAsToolStripMenuItem
            // 
            this.fileSaveAsToolStripMenuItem.Enabled = false;
            this.fileSaveAsToolStripMenuItem.Name = "fileSaveAsToolStripMenuItem";
            this.fileSaveAsToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.fileSaveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // filePrintToolStripMenuItem
            // 
            this.filePrintToolStripMenuItem.Enabled = false;
            this.filePrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filePrintToolStripMenuItem.Image")));
            this.filePrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filePrintToolStripMenuItem.Name = "filePrintToolStripMenuItem";
            this.filePrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.filePrintToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.filePrintToolStripMenuItem.Text = "&Print";
            // 
            // filePrintPreviewToolStripMenuItem
            // 
            this.filePrintPreviewToolStripMenuItem.Enabled = false;
            this.filePrintPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filePrintPreviewToolStripMenuItem.Image")));
            this.filePrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filePrintPreviewToolStripMenuItem.Name = "filePrintPreviewToolStripMenuItem";
            this.filePrintPreviewToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.filePrintPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUndoToolStripMenuItem,
            this.editRedoToolStripMenuItem,
            this.toolStripSeparator3,
            this.editCutToolStripMenuItem,
            this.editCopyToolStripMenuItem,
            this.editPasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.editSelectAllToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // editUndoToolStripMenuItem
            // 
            this.editUndoToolStripMenuItem.Enabled = false;
            this.editUndoToolStripMenuItem.Name = "editUndoToolStripMenuItem";
            this.editUndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.editUndoToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.editUndoToolStripMenuItem.Text = "&Undo";
            // 
            // editRedoToolStripMenuItem
            // 
            this.editRedoToolStripMenuItem.Enabled = false;
            this.editRedoToolStripMenuItem.Name = "editRedoToolStripMenuItem";
            this.editRedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.editRedoToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.editRedoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(166, 6);
            // 
            // editCutToolStripMenuItem
            // 
            this.editCutToolStripMenuItem.Enabled = false;
            this.editCutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editCutToolStripMenuItem.Image")));
            this.editCutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCutToolStripMenuItem.Name = "editCutToolStripMenuItem";
            this.editCutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.editCutToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.editCutToolStripMenuItem.Text = "&Cut";
            // 
            // editCopyToolStripMenuItem
            // 
            this.editCopyToolStripMenuItem.Enabled = false;
            this.editCopyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editCopyToolStripMenuItem.Image")));
            this.editCopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCopyToolStripMenuItem.Name = "editCopyToolStripMenuItem";
            this.editCopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.editCopyToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.editCopyToolStripMenuItem.Text = "C&opy";
            // 
            // editPasteToolStripMenuItem
            // 
            this.editPasteToolStripMenuItem.Enabled = false;
            this.editPasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editPasteToolStripMenuItem.Image")));
            this.editPasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPasteToolStripMenuItem.Name = "editPasteToolStripMenuItem";
            this.editPasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.editPasteToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.editPasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(166, 6);
            // 
            // editSelectAllToolStripMenuItem
            // 
            this.editSelectAllToolStripMenuItem.Enabled = false;
            this.editSelectAllToolStripMenuItem.Name = "editSelectAllToolStripMenuItem";
            this.editSelectAllToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.editSelectAllToolStripMenuItem.Text = "&Select all";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsCustomizeToolStripMenuItem,
            this.toolsSettingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Enabled = false;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // toolsCustomizeToolStripMenuItem
            // 
            this.toolsCustomizeToolStripMenuItem.Enabled = false;
            this.toolsCustomizeToolStripMenuItem.Name = "toolsCustomizeToolStripMenuItem";
            this.toolsCustomizeToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.toolsCustomizeToolStripMenuItem.Text = "&Customize";
            // 
            // toolsSettingsToolStripMenuItem
            // 
            this.toolsSettingsToolStripMenuItem.Enabled = false;
            this.toolsSettingsToolStripMenuItem.Name = "toolsSettingsToolStripMenuItem";
            this.toolsSettingsToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.toolsSettingsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentToolStripMenuItem,
            this.helpIndexToolStripMenuItem,
            this.helpFindToolStripMenuItem,
            this.toolStripSeparator5,
            this.helpAboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpContentToolStripMenuItem
            // 
            this.helpContentToolStripMenuItem.Enabled = false;
            this.helpContentToolStripMenuItem.Name = "helpContentToolStripMenuItem";
            this.helpContentToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.helpContentToolStripMenuItem.Text = "&Content";
            // 
            // helpIndexToolStripMenuItem
            // 
            this.helpIndexToolStripMenuItem.Enabled = false;
            this.helpIndexToolStripMenuItem.Name = "helpIndexToolStripMenuItem";
            this.helpIndexToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.helpIndexToolStripMenuItem.Text = "&Index";
            // 
            // helpFindToolStripMenuItem
            // 
            this.helpFindToolStripMenuItem.Enabled = false;
            this.helpFindToolStripMenuItem.Name = "helpFindToolStripMenuItem";
            this.helpFindToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.helpFindToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(127, 6);
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.helpAboutToolStripMenuItem.Text = "Inf&o...";
            this.helpAboutToolStripMenuItem.Click += new System.EventHandler(this.helpAboutToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMain.Controls.Add(this.labelInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1596, 35);
            this.panelMain.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelInfo.Location = new System.Drawing.Point(8, 7);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(188, 17);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Book Collection Manager";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeViewAuthors
            // 
            this.treeViewAuthors.DbContext = null;
            this.treeViewAuthors.Location = new System.Drawing.Point(49, 279);
            this.treeViewAuthors.Margin = new System.Windows.Forms.Padding(5);
            this.treeViewAuthors.Name = "treeViewAuthors";
            this.treeViewAuthors.Size = new System.Drawing.Size(161, 111);
            this.treeViewAuthors.TabIndex = 5;
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.DbContext = null;
            this.treeViewCategories.Location = new System.Drawing.Point(49, 148);
            this.treeViewCategories.Margin = new System.Windows.Forms.Padding(5);
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.Size = new System.Drawing.Size(161, 119);
            this.treeViewCategories.TabIndex = 4;
            this.treeViewCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCategories_AfterSelect);
            // 
            // treeViewBooks
            // 
            this.treeViewBooks.DbContext = null;
            this.treeViewBooks.Location = new System.Drawing.Point(49, 17);
            this.treeViewBooks.Margin = new System.Windows.Forms.Padding(5);
            this.treeViewBooks.Name = "treeViewBooks";
            this.treeViewBooks.Size = new System.Drawing.Size(161, 123);
            this.treeViewBooks.TabIndex = 3;
            // 
            // bookList
            // 
            this.bookList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bookList.DbContext = null;
            this.bookList.Filter = null;
            this.bookList.Location = new System.Drawing.Point(25, 149);
            this.bookList.Margin = new System.Windows.Forms.Padding(5);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(265, 122);
            this.bookList.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 654);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Book Collection Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainerNav.Panel1.ResumeLayout(false);
            this.splitContainerNav.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNav)).EndInit();
            this.splitContainerNav.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem fileSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem filePrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filePrintPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem editSelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsCustomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpFindToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainerNav;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button buttonSelectAuthors;
        private System.Windows.Forms.Button buttonSelectCategories;
        private System.Windows.Forms.Button buttonSelectBooks;
        private System.Windows.Forms.Panel panelStartup;
        private BookList bookList;
        private System.Windows.Forms.Label labelInfo;
        private TreeViewAuthors treeViewAuthors;
        private TreeViewCategories treeViewCategories;
        private TreeViewBooks treeViewBooks;
    }
}

