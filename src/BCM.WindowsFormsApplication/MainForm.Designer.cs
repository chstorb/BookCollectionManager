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
            this.treeViewAuthors = new BCM.WindowsFormsApplication.TreeViewAuthors();
            this.treeViewCategories = new BCM.WindowsFormsApplication.TreeViewCategories();
            this.treeViewBooks = new BCM.WindowsFormsApplication.TreeViewBooks();
            this.buttonSelectAuthors = new System.Windows.Forms.Button();
            this.buttonSelectBooks = new System.Windows.Forms.Button();
            this.buttonSelectCategories = new System.Windows.Forms.Button();
            this.bookList = new BCM.WindowsFormsApplication.BookList();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
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
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 655);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainerNav
            // 
            this.splitContainerNav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerNav.IsSplitterFixed = true;
            this.splitContainerNav.Location = new System.Drawing.Point(0, 0);
            this.splitContainerNav.Name = "splitContainerNav";
            this.splitContainerNav.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerNav.Panel1
            // 
            this.splitContainerNav.Panel1.Controls.Add(this.treeViewAuthors);
            this.splitContainerNav.Panel1.Controls.Add(this.treeViewCategories);
            this.splitContainerNav.Panel1.Controls.Add(this.treeViewBooks);
            // 
            // splitContainerNav.Panel2
            // 
            this.splitContainerNav.Panel2.Controls.Add(this.buttonSelectAuthors);
            this.splitContainerNav.Panel2.Controls.Add(this.buttonSelectBooks);
            this.splitContainerNav.Panel2.Controls.Add(this.buttonSelectCategories);
            this.splitContainerNav.Panel2MinSize = 123;
            this.splitContainerNav.Size = new System.Drawing.Size(179, 655);
            this.splitContainerNav.SplitterDistance = 509;
            this.splitContainerNav.SplitterIncrement = 50;
            this.splitContainerNav.SplitterWidth = 3;
            this.splitContainerNav.TabIndex = 0;
            this.splitContainerNav.Layout += new System.Windows.Forms.LayoutEventHandler(this.splitContainerNav_Layout);
            // 
            // treeViewAuthors
            // 
            this.treeViewAuthors.DbContext = null;
            this.treeViewAuthors.Location = new System.Drawing.Point(37, 227);
            this.treeViewAuthors.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewAuthors.Name = "treeViewAuthors";
            this.treeViewAuthors.Size = new System.Drawing.Size(121, 90);
            this.treeViewAuthors.TabIndex = 5;
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.DbContext = null;
            this.treeViewCategories.Location = new System.Drawing.Point(37, 120);
            this.treeViewCategories.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.Size = new System.Drawing.Size(121, 97);
            this.treeViewCategories.TabIndex = 4;
            this.treeViewCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCategories_AfterSelect);
            // 
            // treeViewBooks
            // 
            this.treeViewBooks.DbContext = null;
            this.treeViewBooks.Location = new System.Drawing.Point(37, 14);
            this.treeViewBooks.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewBooks.Name = "treeViewBooks";
            this.treeViewBooks.Size = new System.Drawing.Size(121, 100);
            this.treeViewBooks.TabIndex = 3;
            // 
            // buttonSelectAuthors
            // 
            this.buttonSelectAuthors.BackgroundImage = global::BCM.WindowsFormsApplication.Properties.Resources.buttonSelectAuthors_BackgroundImage;
            this.buttonSelectAuthors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelectAuthors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSelectAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectAuthors.Image = global::BCM.WindowsFormsApplication.Properties.Resources.Team_32xLG;
            this.buttonSelectAuthors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectAuthors.Location = new System.Drawing.Point(0, 59);
            this.buttonSelectAuthors.Name = "buttonSelectAuthors";
            this.buttonSelectAuthors.Size = new System.Drawing.Size(177, 41);
            this.buttonSelectAuthors.TabIndex = 2;
            this.buttonSelectAuthors.Text = "Authors";
            this.buttonSelectAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectAuthors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSelectAuthors.UseVisualStyleBackColor = true;
            this.buttonSelectAuthors.Click += new System.EventHandler(this.buttonSelectAuthors_Click);
            // 
            // buttonSelectBooks
            // 
            this.buttonSelectBooks.BackgroundImage = global::BCM.WindowsFormsApplication.Properties.Resources.buttonSelectBooks_BackgroundImage;
            this.buttonSelectBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelectBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelectBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectBooks.Image = global::BCM.WindowsFormsApplication.Properties.Resources.book_Open_16xSM;
            this.buttonSelectBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectBooks.Location = new System.Drawing.Point(0, 0);
            this.buttonSelectBooks.Name = "buttonSelectBooks";
            this.buttonSelectBooks.Size = new System.Drawing.Size(177, 41);
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
            this.buttonSelectCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectCategories.Image = global::BCM.WindowsFormsApplication.Properties.Resources.class_32xLG;
            this.buttonSelectCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectCategories.Location = new System.Drawing.Point(0, 100);
            this.buttonSelectCategories.Name = "buttonSelectCategories";
            this.buttonSelectCategories.Size = new System.Drawing.Size(177, 41);
            this.buttonSelectCategories.TabIndex = 1;
            this.buttonSelectCategories.Text = "Categories";
            this.buttonSelectCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSelectCategories.UseVisualStyleBackColor = true;
            this.buttonSelectCategories.Click += new System.EventHandler(this.buttonSelectCategories_Click);
            // 
            // bookList
            // 
            this.bookList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bookList.CategoryId = 1;
            this.bookList.DataMember = "";
            this.bookList.DataSource = null;
            this.bookList.DbContext = null;
            this.bookList.Filter = null;
            this.bookList.Location = new System.Drawing.Point(19, 121);
            this.bookList.Margin = new System.Windows.Forms.Padding(4);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(200, 100);
            this.bookList.TabIndex = 1;
            this.bookList.AfterSelect += new System.EventHandler<BCM.WindowsFormsApplication.BookSelectedEventArgs>(this.bookList_AfterSelect);
            // 
            // panelStartup
            // 
            this.panelStartup.BackColor = System.Drawing.SystemColors.Control;
            this.panelStartup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelStartup.Location = new System.Drawing.Point(19, 15);
            this.panelStartup.Name = "panelStartup";
            this.panelStartup.Size = new System.Drawing.Size(200, 100);
            this.panelStartup.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 1);
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
            this.splitContainer2.Size = new System.Drawing.Size(1008, 54);
            this.splitContainer2.SplitterDistance = 25;
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
            this.menuStripMain.Size = new System.Drawing.Size(1008, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // fileNewToolStripMenuItem
            // 
            this.fileNewToolStripMenuItem.Enabled = false;
            this.fileNewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileNewToolStripMenuItem.Image")));
            this.fileNewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileNewToolStripMenuItem.Name = "fileNewToolStripMenuItem";
            this.fileNewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileNewToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fileNewToolStripMenuItem.Text = "&New";
            // 
            // fileOpenToolStripMenuItem
            // 
            this.fileOpenToolStripMenuItem.Enabled = false;
            this.fileOpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileOpenToolStripMenuItem.Image")));
            this.fileOpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            this.fileOpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fileOpenToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(145, 6);
            // 
            // fileSaveToolStripMenuItem
            // 
            this.fileSaveToolStripMenuItem.Enabled = false;
            this.fileSaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileSaveToolStripMenuItem.Image")));
            this.fileSaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileSaveToolStripMenuItem.Name = "fileSaveToolStripMenuItem";
            this.fileSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSaveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fileSaveToolStripMenuItem.Text = "&Save";
            // 
            // fileSaveAsToolStripMenuItem
            // 
            this.fileSaveAsToolStripMenuItem.Enabled = false;
            this.fileSaveAsToolStripMenuItem.Name = "fileSaveAsToolStripMenuItem";
            this.fileSaveAsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fileSaveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // filePrintToolStripMenuItem
            // 
            this.filePrintToolStripMenuItem.Enabled = false;
            this.filePrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filePrintToolStripMenuItem.Image")));
            this.filePrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filePrintToolStripMenuItem.Name = "filePrintToolStripMenuItem";
            this.filePrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.filePrintToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.filePrintToolStripMenuItem.Text = "&Print";
            // 
            // filePrintPreviewToolStripMenuItem
            // 
            this.filePrintPreviewToolStripMenuItem.Enabled = false;
            this.filePrintPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filePrintPreviewToolStripMenuItem.Image")));
            this.filePrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filePrintPreviewToolStripMenuItem.Name = "filePrintPreviewToolStripMenuItem";
            this.filePrintPreviewToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.filePrintPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // editUndoToolStripMenuItem
            // 
            this.editUndoToolStripMenuItem.Enabled = false;
            this.editUndoToolStripMenuItem.Name = "editUndoToolStripMenuItem";
            this.editUndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.editUndoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editUndoToolStripMenuItem.Text = "&Undo";
            // 
            // editRedoToolStripMenuItem
            // 
            this.editRedoToolStripMenuItem.Enabled = false;
            this.editRedoToolStripMenuItem.Name = "editRedoToolStripMenuItem";
            this.editRedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.editRedoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editRedoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // editCutToolStripMenuItem
            // 
            this.editCutToolStripMenuItem.Enabled = false;
            this.editCutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editCutToolStripMenuItem.Image")));
            this.editCutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCutToolStripMenuItem.Name = "editCutToolStripMenuItem";
            this.editCutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.editCutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editCutToolStripMenuItem.Text = "&Cut";
            // 
            // editCopyToolStripMenuItem
            // 
            this.editCopyToolStripMenuItem.Enabled = false;
            this.editCopyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editCopyToolStripMenuItem.Image")));
            this.editCopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCopyToolStripMenuItem.Name = "editCopyToolStripMenuItem";
            this.editCopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.editCopyToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editCopyToolStripMenuItem.Text = "C&opy";
            // 
            // editPasteToolStripMenuItem
            // 
            this.editPasteToolStripMenuItem.Enabled = false;
            this.editPasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editPasteToolStripMenuItem.Image")));
            this.editPasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPasteToolStripMenuItem.Name = "editPasteToolStripMenuItem";
            this.editPasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.editPasteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editPasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
            // 
            // editSelectAllToolStripMenuItem
            // 
            this.editSelectAllToolStripMenuItem.Enabled = false;
            this.editSelectAllToolStripMenuItem.Name = "editSelectAllToolStripMenuItem";
            this.editSelectAllToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editSelectAllToolStripMenuItem.Text = "&Select all";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsCustomizeToolStripMenuItem,
            this.toolsSettingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Enabled = false;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // toolsCustomizeToolStripMenuItem
            // 
            this.toolsCustomizeToolStripMenuItem.Enabled = false;
            this.toolsCustomizeToolStripMenuItem.Name = "toolsCustomizeToolStripMenuItem";
            this.toolsCustomizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.toolsCustomizeToolStripMenuItem.Text = "&Customize";
            // 
            // toolsSettingsToolStripMenuItem
            // 
            this.toolsSettingsToolStripMenuItem.Enabled = false;
            this.toolsSettingsToolStripMenuItem.Name = "toolsSettingsToolStripMenuItem";
            this.toolsSettingsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpContentToolStripMenuItem
            // 
            this.helpContentToolStripMenuItem.Enabled = false;
            this.helpContentToolStripMenuItem.Name = "helpContentToolStripMenuItem";
            this.helpContentToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.helpContentToolStripMenuItem.Text = "&Content";
            // 
            // helpIndexToolStripMenuItem
            // 
            this.helpIndexToolStripMenuItem.Enabled = false;
            this.helpIndexToolStripMenuItem.Name = "helpIndexToolStripMenuItem";
            this.helpIndexToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.helpIndexToolStripMenuItem.Text = "&Index";
            // 
            // helpFindToolStripMenuItem
            // 
            this.helpFindToolStripMenuItem.Enabled = false;
            this.helpFindToolStripMenuItem.Name = "helpFindToolStripMenuItem";
            this.helpFindToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.helpFindToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(114, 6);
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.helpAboutToolStripMenuItem.Text = "Inf&o...";
            this.helpAboutToolStripMenuItem.Click += new System.EventHandler(this.helpAboutToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMain.Controls.Add(this.labelInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1008, 27);
            this.panelMain.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelInfo.Location = new System.Drawing.Point(6, 6);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(149, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Book Collection Manager";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStripMain;
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

