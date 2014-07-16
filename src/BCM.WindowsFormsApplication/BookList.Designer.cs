namespace BCM.WindowsFormsApplication
{
    partial class BookList
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyrigthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishingCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishingYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceOfPublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoverType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePurchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.textBoxListPrice = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDatePurchased = new System.Windows.Forms.DateTimePicker();
            this.textBoxPurchasePrice = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.labelListPrice = new System.Windows.Forms.Label();
            this.labelDatePurchased = new System.Windows.Forms.Label();
            this.labelPurchasePrice = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.textBoxCoverType = new System.Windows.Forms.TextBox();
            this.textBoxEditionNumber = new System.Windows.Forms.TextBox();
            this.textBoxVolumeNumber = new System.Windows.Forms.TextBox();
            this.textBoxPlaceOfPublication = new System.Windows.Forms.TextBox();
            this.textBoxPublishingYear = new System.Windows.Forms.TextBox();
            this.textBoxPublisherName = new System.Windows.Forms.TextBox();
            this.textBoxPublishingCompany = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelCoverType = new System.Windows.Forms.Label();
            this.labelEditionNumber = new System.Windows.Forms.Label();
            this.labelVolumeNumber = new System.Windows.Forms.Label();
            this.labelPlaceOfPublication = new System.Windows.Forms.Label();
            this.labelPublishingYear = new System.Windows.Forms.Label();
            this.labelPublisherName = new System.Windows.Forms.Label();
            this.labelPublishingCompany = new System.Windows.Forms.Label();
            this.textBoxISBNNumber = new System.Windows.Forms.TextBox();
            this.labelISBNNumber = new System.Windows.Forms.Label();
            this.textBoxCopyrightYear = new System.Windows.Forms.TextBox();
            this.labelCopyrightYear = new System.Windows.Forms.Label();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.labelCagtegories = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxBookId = new System.Windows.Forms.TextBox();
            this.labelBookId = new System.Windows.Forms.Label();
            this.CatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.AuthorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofDeath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photograph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.CopyrigthYear,
            this.ISBNNumber,
            this.PublishingCompany,
            this.PublisherName,
            this.PublishingYear,
            this.PlaceOfPublication,
            this.VolumeNumber,
            this.EditionNumber,
            this.CoverType,
            this.Pages,
            this.Location,
            this.Notes,
            this.PurchasePrice,
            this.DatePurchased,
            this.ListPrice});
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 25;
            this.dataGridViewBooks.Size = new System.Drawing.Size(820, 240);
            this.dataGridViewBooks.TabIndex = 1;
            this.dataGridViewBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellDoubleClick);
            this.dataGridViewBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewBooks_CellFormatting);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 400;
            // 
            // CopyrigthYear
            // 
            this.CopyrigthYear.HeaderText = "CopyrigthYear";
            this.CopyrigthYear.Name = "CopyrigthYear";
            this.CopyrigthYear.Visible = false;
            // 
            // ISBNNumber
            // 
            this.ISBNNumber.HeaderText = "ISBNNumber";
            this.ISBNNumber.Name = "ISBNNumber";
            this.ISBNNumber.Visible = false;
            // 
            // PublishingCompany
            // 
            this.PublishingCompany.HeaderText = "Publishing Company";
            this.PublishingCompany.Name = "PublishingCompany";
            this.PublishingCompany.Width = 200;
            // 
            // PublisherName
            // 
            this.PublisherName.HeaderText = "Publisher Name";
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.Width = 180;
            // 
            // PublishingYear
            // 
            dataGridViewCellStyle13.NullValue = null;
            this.PublishingYear.DefaultCellStyle = dataGridViewCellStyle13;
            this.PublishingYear.HeaderText = "Publishing Year";
            this.PublishingYear.Name = "PublishingYear";
            this.PublishingYear.Width = 130;
            // 
            // PlaceOfPublication
            // 
            this.PlaceOfPublication.HeaderText = "Place Of Publication";
            this.PlaceOfPublication.Name = "PlaceOfPublication";
            this.PlaceOfPublication.Width = 180;
            // 
            // VolumeNumber
            // 
            this.VolumeNumber.HeaderText = "VolumeNumber";
            this.VolumeNumber.Name = "VolumeNumber";
            this.VolumeNumber.Visible = false;
            // 
            // EditionNumber
            // 
            this.EditionNumber.HeaderText = "EditionNumber";
            this.EditionNumber.Name = "EditionNumber";
            this.EditionNumber.Visible = false;
            // 
            // CoverType
            // 
            this.CoverType.HeaderText = "CoverType";
            this.CoverType.Name = "CoverType";
            this.CoverType.Visible = false;
            // 
            // Pages
            // 
            this.Pages.HeaderText = "Pages";
            this.Pages.Name = "Pages";
            this.Pages.Visible = false;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.Visible = false;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.Visible = false;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "PurchasePrice";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Visible = false;
            // 
            // DatePurchased
            // 
            this.DatePurchased.HeaderText = "DatePurchased";
            this.DatePurchased.Name = "DatePurchased";
            this.DatePurchased.Visible = false;
            // 
            // ListPrice
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.ListPrice.DefaultCellStyle = dataGridViewCellStyle14;
            this.ListPrice.HeaderText = "List Price";
            this.ListPrice.Name = "ListPrice";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 240);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(820, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewBooks);
            this.splitContainer1.Panel1.Controls.Add(this.bindingNavigator1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewAuthors);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxListPrice);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDatePurchased);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPurchasePrice);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNotes);
            this.splitContainer1.Panel2.Controls.Add(this.labelAuthors);
            this.splitContainer1.Panel2.Controls.Add(this.labelListPrice);
            this.splitContainer1.Panel2.Controls.Add(this.labelDatePurchased);
            this.splitContainer1.Panel2.Controls.Add(this.labelPurchasePrice);
            this.splitContainer1.Panel2.Controls.Add(this.labelNotes);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLocation);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPages);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCoverType);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxEditionNumber);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxVolumeNumber);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPlaceOfPublication);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPublishingYear);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPublisherName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPublishingCompany);
            this.splitContainer1.Panel2.Controls.Add(this.labelLocation);
            this.splitContainer1.Panel2.Controls.Add(this.labelPages);
            this.splitContainer1.Panel2.Controls.Add(this.labelCoverType);
            this.splitContainer1.Panel2.Controls.Add(this.labelEditionNumber);
            this.splitContainer1.Panel2.Controls.Add(this.labelVolumeNumber);
            this.splitContainer1.Panel2.Controls.Add(this.labelPlaceOfPublication);
            this.splitContainer1.Panel2.Controls.Add(this.labelPublishingYear);
            this.splitContainer1.Panel2.Controls.Add(this.labelPublisherName);
            this.splitContainer1.Panel2.Controls.Add(this.labelPublishingCompany);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxISBNNumber);
            this.splitContainer1.Panel2.Controls.Add(this.labelISBNNumber);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCopyrightYear);
            this.splitContainer1.Panel2.Controls.Add(this.labelCopyrightYear);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewCategories);
            this.splitContainer1.Panel2.Controls.Add(this.labelCagtegories);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTitle);
            this.splitContainer1.Panel2.Controls.Add(this.labelTitle);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxBookId);
            this.splitContainer1.Panel2.Controls.Add(this.labelBookId);
            this.splitContainer1.Size = new System.Drawing.Size(822, 575);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorId,
            this.LastName,
            this.BirthName,
            this.FirstName,
            this.BirthDate,
            this.Birthplace,
            this.Nationality,
            this.DateofDeath,
            this.Photograph,
            this.AuthorNotes});
            this.dataGridViewAuthors.Location = new System.Drawing.Point(306, 142);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.RowHeadersWidth = 25;
            this.dataGridViewAuthors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(228, 67);
            this.dataGridViewAuthors.TabIndex = 75;
            // 
            // textBoxListPrice
            // 
            this.textBoxListPrice.Location = new System.Drawing.Point(393, 101);
            this.textBoxListPrice.Name = "textBoxListPrice";
            this.textBoxListPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxListPrice.TabIndex = 74;
            // 
            // textBoxDatePurchased
            // 
            this.textBoxDatePurchased.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textBoxDatePurchased.Location = new System.Drawing.Point(393, 78);
            this.textBoxDatePurchased.Name = "textBoxDatePurchased";
            this.textBoxDatePurchased.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatePurchased.TabIndex = 73;
            // 
            // textBoxPurchasePrice
            // 
            this.textBoxPurchasePrice.Location = new System.Drawing.Point(393, 53);
            this.textBoxPurchasePrice.Name = "textBoxPurchasePrice";
            this.textBoxPurchasePrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPurchasePrice.TabIndex = 72;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(520, 29);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(290, 46);
            this.textBoxNotes.TabIndex = 71;
            // 
            // labelAuthors
            // 
            this.labelAuthors.AutoSize = true;
            this.labelAuthors.Location = new System.Drawing.Point(303, 126);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(43, 13);
            this.labelAuthors.TabIndex = 70;
            this.labelAuthors.Text = "Authors";
            // 
            // labelListPrice
            // 
            this.labelListPrice.AutoSize = true;
            this.labelListPrice.Location = new System.Drawing.Point(303, 105);
            this.labelListPrice.Name = "labelListPrice";
            this.labelListPrice.Size = new System.Drawing.Size(53, 13);
            this.labelListPrice.TabIndex = 69;
            this.labelListPrice.Text = "List Price:";
            // 
            // labelDatePurchased
            // 
            this.labelDatePurchased.AutoSize = true;
            this.labelDatePurchased.Location = new System.Drawing.Point(303, 83);
            this.labelDatePurchased.Name = "labelDatePurchased";
            this.labelDatePurchased.Size = new System.Drawing.Size(87, 13);
            this.labelDatePurchased.TabIndex = 68;
            this.labelDatePurchased.Text = "Date Purchased:";
            // 
            // labelPurchasePrice
            // 
            this.labelPurchasePrice.AutoSize = true;
            this.labelPurchasePrice.Location = new System.Drawing.Point(303, 59);
            this.labelPurchasePrice.Name = "labelPurchasePrice";
            this.labelPurchasePrice.Size = new System.Drawing.Size(82, 13);
            this.labelPurchasePrice.TabIndex = 67;
            this.labelPurchasePrice.Text = "Purchase Price:";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(518, 16);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(35, 13);
            this.labelNotes.TabIndex = 66;
            this.labelNotes.Text = "Notes";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(114, 278);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(184, 20);
            this.textBoxLocation.TabIndex = 65;
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(114, 255);
            this.textBoxPages.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(76, 20);
            this.textBoxPages.TabIndex = 64;
            // 
            // textBoxCoverType
            // 
            this.textBoxCoverType.Location = new System.Drawing.Point(114, 232);
            this.textBoxCoverType.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCoverType.Name = "textBoxCoverType";
            this.textBoxCoverType.Size = new System.Drawing.Size(184, 20);
            this.textBoxCoverType.TabIndex = 63;
            // 
            // textBoxEditionNumber
            // 
            this.textBoxEditionNumber.Location = new System.Drawing.Point(114, 211);
            this.textBoxEditionNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEditionNumber.Name = "textBoxEditionNumber";
            this.textBoxEditionNumber.Size = new System.Drawing.Size(76, 20);
            this.textBoxEditionNumber.TabIndex = 62;
            // 
            // textBoxVolumeNumber
            // 
            this.textBoxVolumeNumber.Location = new System.Drawing.Point(114, 188);
            this.textBoxVolumeNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVolumeNumber.Name = "textBoxVolumeNumber";
            this.textBoxVolumeNumber.Size = new System.Drawing.Size(76, 20);
            this.textBoxVolumeNumber.TabIndex = 61;
            // 
            // textBoxPlaceOfPublication
            // 
            this.textBoxPlaceOfPublication.Location = new System.Drawing.Point(114, 165);
            this.textBoxPlaceOfPublication.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlaceOfPublication.Name = "textBoxPlaceOfPublication";
            this.textBoxPlaceOfPublication.Size = new System.Drawing.Size(184, 20);
            this.textBoxPlaceOfPublication.TabIndex = 60;
            // 
            // textBoxPublishingYear
            // 
            this.textBoxPublishingYear.Location = new System.Drawing.Point(114, 142);
            this.textBoxPublishingYear.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPublishingYear.Name = "textBoxPublishingYear";
            this.textBoxPublishingYear.Size = new System.Drawing.Size(76, 20);
            this.textBoxPublishingYear.TabIndex = 59;
            // 
            // textBoxPublisherName
            // 
            this.textBoxPublisherName.Location = new System.Drawing.Point(114, 119);
            this.textBoxPublisherName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPublisherName.Name = "textBoxPublisherName";
            this.textBoxPublisherName.Size = new System.Drawing.Size(184, 20);
            this.textBoxPublisherName.TabIndex = 58;
            // 
            // textBoxPublishingCompany
            // 
            this.textBoxPublishingCompany.Location = new System.Drawing.Point(114, 96);
            this.textBoxPublishingCompany.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPublishingCompany.Name = "textBoxPublishingCompany";
            this.textBoxPublishingCompany.Size = new System.Drawing.Size(184, 20);
            this.textBoxPublishingCompany.TabIndex = 57;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(7, 282);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(51, 13);
            this.labelLocation.TabIndex = 56;
            this.labelLocation.Text = "Location:";
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(7, 259);
            this.labelPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(40, 13);
            this.labelPages.TabIndex = 55;
            this.labelPages.Text = "Pages:";
            // 
            // labelCoverType
            // 
            this.labelCoverType.AutoSize = true;
            this.labelCoverType.Location = new System.Drawing.Point(7, 236);
            this.labelCoverType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoverType.Name = "labelCoverType";
            this.labelCoverType.Size = new System.Drawing.Size(65, 13);
            this.labelCoverType.TabIndex = 54;
            this.labelCoverType.Text = "Cover Type:";
            // 
            // labelEditionNumber
            // 
            this.labelEditionNumber.AutoSize = true;
            this.labelEditionNumber.Location = new System.Drawing.Point(7, 215);
            this.labelEditionNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEditionNumber.Name = "labelEditionNumber";
            this.labelEditionNumber.Size = new System.Drawing.Size(82, 13);
            this.labelEditionNumber.TabIndex = 53;
            this.labelEditionNumber.Text = "Edition Number:";
            // 
            // labelVolumeNumber
            // 
            this.labelVolumeNumber.AutoSize = true;
            this.labelVolumeNumber.Location = new System.Drawing.Point(7, 192);
            this.labelVolumeNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVolumeNumber.Name = "labelVolumeNumber";
            this.labelVolumeNumber.Size = new System.Drawing.Size(85, 13);
            this.labelVolumeNumber.TabIndex = 52;
            this.labelVolumeNumber.Text = "Volume Number:";
            // 
            // labelPlaceOfPublication
            // 
            this.labelPlaceOfPublication.AutoSize = true;
            this.labelPlaceOfPublication.Location = new System.Drawing.Point(7, 169);
            this.labelPlaceOfPublication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlaceOfPublication.Name = "labelPlaceOfPublication";
            this.labelPlaceOfPublication.Size = new System.Drawing.Size(104, 13);
            this.labelPlaceOfPublication.TabIndex = 51;
            this.labelPlaceOfPublication.Text = "Place of Publication:";
            // 
            // labelPublishingYear
            // 
            this.labelPublishingYear.AutoSize = true;
            this.labelPublishingYear.Location = new System.Drawing.Point(7, 146);
            this.labelPublishingYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPublishingYear.Name = "labelPublishingYear";
            this.labelPublishingYear.Size = new System.Drawing.Size(83, 13);
            this.labelPublishingYear.TabIndex = 50;
            this.labelPublishingYear.Text = "Publishing Year:";
            // 
            // labelPublisherName
            // 
            this.labelPublisherName.AutoSize = true;
            this.labelPublisherName.Location = new System.Drawing.Point(7, 123);
            this.labelPublisherName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPublisherName.Name = "labelPublisherName";
            this.labelPublisherName.Size = new System.Drawing.Size(84, 13);
            this.labelPublisherName.TabIndex = 49;
            this.labelPublisherName.Text = "Publisher Name:";
            // 
            // labelPublishingCompany
            // 
            this.labelPublishingCompany.AutoSize = true;
            this.labelPublishingCompany.Location = new System.Drawing.Point(7, 100);
            this.labelPublishingCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPublishingCompany.Name = "labelPublishingCompany";
            this.labelPublishingCompany.Size = new System.Drawing.Size(105, 13);
            this.labelPublishingCompany.TabIndex = 48;
            this.labelPublishingCompany.Text = "Publishing Company:";
            // 
            // textBoxISBNNumber
            // 
            this.textBoxISBNNumber.Location = new System.Drawing.Point(114, 75);
            this.textBoxISBNNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxISBNNumber.Name = "textBoxISBNNumber";
            this.textBoxISBNNumber.Size = new System.Drawing.Size(184, 20);
            this.textBoxISBNNumber.TabIndex = 47;
            // 
            // labelISBNNumber
            // 
            this.labelISBNNumber.AutoSize = true;
            this.labelISBNNumber.Location = new System.Drawing.Point(7, 79);
            this.labelISBNNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelISBNNumber.Name = "labelISBNNumber";
            this.labelISBNNumber.Size = new System.Drawing.Size(75, 13);
            this.labelISBNNumber.TabIndex = 46;
            this.labelISBNNumber.Text = "ISBN-Number:";
            // 
            // textBoxCopyrightYear
            // 
            this.textBoxCopyrightYear.Location = new System.Drawing.Point(114, 52);
            this.textBoxCopyrightYear.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCopyrightYear.Name = "textBoxCopyrightYear";
            this.textBoxCopyrightYear.Size = new System.Drawing.Size(76, 20);
            this.textBoxCopyrightYear.TabIndex = 45;
            // 
            // labelCopyrightYear
            // 
            this.labelCopyrightYear.AutoSize = true;
            this.labelCopyrightYear.Location = new System.Drawing.Point(7, 56);
            this.labelCopyrightYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCopyrightYear.Name = "labelCopyrightYear";
            this.labelCopyrightYear.Size = new System.Drawing.Size(79, 13);
            this.labelCopyrightYear.TabIndex = 44;
            this.labelCopyrightYear.Text = "Copyright Year:";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatId,
            this.CategoryName,
            this.Description,
            this.ParentCategoryID});
            this.dataGridViewCategories.Location = new System.Drawing.Point(306, 231);
            this.dataGridViewCategories.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowHeadersWidth = 25;
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCategories.Size = new System.Drawing.Size(228, 67);
            this.dataGridViewCategories.TabIndex = 43;
            // 
            // labelCagtegories
            // 
            this.labelCagtegories.AutoSize = true;
            this.labelCagtegories.Location = new System.Drawing.Point(303, 217);
            this.labelCagtegories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCagtegories.Name = "labelCagtegories";
            this.labelCagtegories.Size = new System.Drawing.Size(57, 13);
            this.labelCagtegories.TabIndex = 42;
            this.labelCagtegories.Text = "Categories";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(114, 29);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(379, 20);
            this.textBoxTitle.TabIndex = 41;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(7, 33);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 40;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxBookId
            // 
            this.textBoxBookId.Location = new System.Drawing.Point(114, 5);
            this.textBoxBookId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookId.Name = "textBoxBookId";
            this.textBoxBookId.Size = new System.Drawing.Size(76, 20);
            this.textBoxBookId.TabIndex = 39;
            // 
            // labelBookId
            // 
            this.labelBookId.AutoSize = true;
            this.labelBookId.Location = new System.Drawing.Point(7, 9);
            this.labelBookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Size = new System.Drawing.Size(49, 13);
            this.labelBookId.TabIndex = 38;
            this.labelBookId.Text = "Book ID:";
            // 
            // CatId
            // 
            this.CatId.HeaderText = "ID";
            this.CatId.Name = "CatId";
            this.CatId.ReadOnly = true;
            this.CatId.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 185;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Visible = false;
            // 
            // ParentCategoryID
            // 
            this.ParentCategoryID.HeaderText = "ParentCategoryID";
            this.ParentCategoryID.Name = "ParentCategoryID";
            this.ParentCategoryID.ReadOnly = true;
            this.ParentCategoryID.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(520, 99);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 76;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AuthorId
            // 
            this.AuthorId.HeaderText = "ID";
            this.AuthorId.Name = "AuthorId";
            this.AuthorId.ReadOnly = true;
            this.AuthorId.Visible = false;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // BirthName
            // 
            this.BirthName.HeaderText = "Birth Name";
            this.BirthName.Name = "BirthName";
            this.BirthName.ReadOnly = true;
            this.BirthName.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Birth Date";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Visible = false;
            // 
            // Birthplace
            // 
            this.Birthplace.HeaderText = "Birthplace";
            this.Birthplace.Name = "Birthplace";
            this.Birthplace.ReadOnly = true;
            this.Birthplace.Visible = false;
            // 
            // Nationality
            // 
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            this.Nationality.Visible = false;
            // 
            // DateofDeath
            // 
            this.DateofDeath.HeaderText = "Date of Death";
            this.DateofDeath.Name = "DateofDeath";
            this.DateofDeath.ReadOnly = true;
            this.DateofDeath.Visible = false;
            // 
            // Photograph
            // 
            this.Photograph.HeaderText = "Photograph";
            this.Photograph.Name = "Photograph";
            this.Photograph.ReadOnly = true;
            this.Photograph.Visible = false;
            // 
            // AuthorNotes
            // 
            this.AuthorNotes.HeaderText = "Notes";
            this.AuthorNotes.Name = "AuthorNotes";
            this.AuthorNotes.ReadOnly = true;
            this.AuthorNotes.Visible = false;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "BookList";
            this.Size = new System.Drawing.Size(822, 575);
            this.Load += new System.EventHandler(this.BookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopyrigthYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishingCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishingYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceOfPublication;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoverType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePurchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListPrice;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.MaskedTextBox textBoxListPrice;
        private System.Windows.Forms.DateTimePicker textBoxDatePurchased;
        private System.Windows.Forms.MaskedTextBox textBoxPurchasePrice;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelAuthors;
        private System.Windows.Forms.Label labelListPrice;
        private System.Windows.Forms.Label labelDatePurchased;
        private System.Windows.Forms.Label labelPurchasePrice;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.TextBox textBoxCoverType;
        private System.Windows.Forms.TextBox textBoxEditionNumber;
        private System.Windows.Forms.TextBox textBoxVolumeNumber;
        private System.Windows.Forms.TextBox textBoxPlaceOfPublication;
        private System.Windows.Forms.TextBox textBoxPublishingYear;
        private System.Windows.Forms.TextBox textBoxPublisherName;
        private System.Windows.Forms.TextBox textBoxPublishingCompany;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelCoverType;
        private System.Windows.Forms.Label labelEditionNumber;
        private System.Windows.Forms.Label labelVolumeNumber;
        private System.Windows.Forms.Label labelPlaceOfPublication;
        private System.Windows.Forms.Label labelPublishingYear;
        private System.Windows.Forms.Label labelPublisherName;
        private System.Windows.Forms.Label labelPublishingCompany;
        private System.Windows.Forms.TextBox textBoxISBNNumber;
        private System.Windows.Forms.Label labelISBNNumber;
        private System.Windows.Forms.TextBox textBoxCopyrightYear;
        private System.Windows.Forms.Label labelCopyrightYear;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Label labelCagtegories;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxBookId;
        private System.Windows.Forms.Label labelBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentCategoryID;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofDeath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photograph;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorNotes;
    }
}
