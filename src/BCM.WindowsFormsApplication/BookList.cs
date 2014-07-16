using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCM.WindowsFormsApplication
{
    using BCM.Common;
    using BCM.DAL;
    using BCM.Model;
    using System.Collections.ObjectModel;
    using System.Collections;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Core;

    [System.ComponentModel.ComplexBindingProperties("DataSource", "DataMember")]
    public partial class BookList : UserControl
    {
        #region Fields

        private int categoryId = 1;

        #endregion Fields

        #region Constructor

        public BookList()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Properties
        
        public ApplicationDbContext DbContext { get; set; }

        public string Filter
        {
            get { return this.bindingSource1.Filter; }
            set { this.bindingSource1.Filter = value; }
        }
        
        public int CategoryId 
        {
            get 
            { 
                return this.categoryId; 
            } 
            set
            {
                if (value == this.categoryId)
                    return;                
                this.categoryId = value;
                this.Requery();
            }             
        }

        public object DataSource
        {
            get
            {
                return this.dataGridViewBooks.DataSource;
            }
            set
            {
                this.dataGridViewBooks.DataSource = value;
            }
        }

        public string DataMember
        {
            get
            {
                return this.dataGridViewBooks.DataMember;
            }
            set
            {
                this.dataGridViewBooks.DataMember = value;
            }
        }
        
        #endregion Properties

        #region Event Handler

        private void BookList_Load(object sender, EventArgs e)
        {
            if ((this.Site != null) && (this.Site.DesignMode))
            {
                return;
            }

            try
            {
                // Use Load to query for entities before binding to the local collection.
                // (For further information see: http://msdn.microsoft.com/en-us/data/jj592911.aspx)
                this.DbContext.Categories.Include("Books").Load();

                SortableBindingList<Book> bindingList = this.DbContext.Books.Local.ToSortableBindingList();
                this.bindingSource1.DataSource = bindingList.OrderBy(b => b.Title);

                this.bindingNavigator1.BindingSource = this.bindingSource1;

                //
                // DataGridView Books
                //
                DataGridViewColumn[] arBooks = new DataGridViewColumn[this.dataGridViewBooks.Columns.Count];
                this.dataGridViewBooks.Columns.CopyTo(arBooks, 0);
                this.dataGridViewBooks.Columns.Clear();
                this.dataGridViewBooks.DataSource = this.bindingSource1;
                for (int i = 0; i < arBooks.Length; i++)
                {
                    DataGridViewColumn col = arBooks[i];
                    this.dataGridViewBooks.Columns[i].Visible = col.Visible;
                    this.dataGridViewBooks.Columns[i].Width = col.Width;
                    this.dataGridViewBooks.Columns[i].HeaderText = col.HeaderText;
                    this.dataGridViewBooks.Columns[i].DefaultCellStyle = col.DefaultCellStyle;
                }
                //
                // Text Boxes
                //
                this.textBoxBookId.DataBindings.Add("Text", this.bindingSource1, "ID");
                this.textBoxTitle.DataBindings.Add("Text", this.bindingSource1, "Title");
                this.textBoxCopyrightYear.DataBindings.Add("Text", this.bindingSource1, "CopyrightYear");
                this.textBoxISBNNumber.DataBindings.Add("Text", this.bindingSource1, "ISBNNumber");
                this.textBoxPublishingCompany.DataBindings.Add("Text", this.bindingSource1, "PublishingCompany");
                this.textBoxPublisherName.DataBindings.Add("Text", this.bindingSource1, "PublisherName");
                this.textBoxPublishingYear.DataBindings.Add("Text", this.bindingSource1, "PublishingYear");
                this.textBoxPlaceOfPublication.DataBindings.Add("Text", this.bindingSource1, "PlaceOfPublication");
                this.textBoxVolumeNumber.DataBindings.Add("Text", this.bindingSource1, "VolumeNumber");
                this.textBoxEditionNumber.DataBindings.Add("Text", this.bindingSource1, "EditionNumber");
                this.textBoxCoverType.DataBindings.Add("Text", this.bindingSource1, "CoverType");
                this.textBoxPages.DataBindings.Add("Text", this.bindingSource1, "Pages");
                this.textBoxLocation.DataBindings.Add("Text", this.bindingSource1, "Location");
                this.textBoxPurchasePrice.DataBindings.Add("Text", this.bindingSource1, "PurchasePrice");
                this.textBoxDatePurchased.DataBindings.Add("Text", this.bindingSource1, "DatePurchased");
                this.textBoxListPrice.DataBindings.Add("Text", this.bindingSource1, "ListPrice");
                this.textBoxNotes.DataBindings.Add("Text", this.bindingSource1, "Notes");
                //
                // DataGridView Authors
                // 
                DataGridViewColumn[] arAuthors = new DataGridViewColumn[this.dataGridViewAuthors.Columns.Count];
                this.dataGridViewAuthors.Columns.CopyTo(arAuthors, 0);
                this.dataGridViewAuthors.Columns.Clear();
                this.dataGridViewAuthors.DataBindings.Add("DataSource", this.bindingSource1, "Authors");
                for (int i = 0; i < arAuthors.Length; i++)
                {
                    DataGridViewColumn col = arAuthors[i];
                    this.dataGridViewAuthors.Columns[i].Visible = col.Visible;
                    this.dataGridViewAuthors.Columns[i].Width = col.Width;
                    this.dataGridViewAuthors.Columns[i].HeaderText = col.HeaderText;
                    this.dataGridViewAuthors.Columns[i].DefaultCellStyle = col.DefaultCellStyle;
                }
                // 
                // DataGridView Categories
                //
                DataGridViewColumn[] arCategories = new DataGridViewColumn[this.dataGridViewCategories.Columns.Count];
                this.dataGridViewCategories.Columns.CopyTo(arCategories, 0);
                this.dataGridViewCategories.Columns.Clear();
                this.dataGridViewCategories.DataBindings.Add("DataSource", this.bindingSource1, "Categories");
                for (int i = 0; i < arCategories.Length; i++)
                {
                    DataGridViewColumn col = arCategories[i];
                    this.dataGridViewCategories.Columns[i].Visible = col.Visible;
                    this.dataGridViewCategories.Columns[i].Width = col.Width;
                    this.dataGridViewCategories.Columns[i].HeaderText = col.HeaderText;
                    this.dataGridViewCategories.Columns[i].DefaultCellStyle = col.DefaultCellStyle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridViewBooks.Columns[e.ColumnIndex].Name == "PublishingYear")
            {
                if (e.Value != null)
                {
                    string stringValue = e.Value.ToString();
                    if ((stringValue.Equals("0")))
                    {
                        e.Value = String.Empty;
                    }

                }
            }
        }

        private void dataGridViewBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // return if column header row is clicked
            int rowIndex = e.RowIndex;
            if(rowIndex == -1)
	            return;

            int bookId = Convert.ToInt32(this.dataGridViewBooks.Rows[rowIndex].Cells["ID"].Value);

            // Raise the event
            if (onAfterSelect != null)
            {
                BookSelectedEventArgs bookSelectedEventArgs = new BookSelectedEventArgs(bookId);
                onAfterSelect(this, bookSelectedEventArgs);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
        }

        #endregion Event Handler

        #region Events

        private EventHandler<BookSelectedEventArgs> onAfterSelect;

        protected virtual void OnAfterSelect(BookSelectedEventArgs e)
        {
            if (onAfterSelect != null)
            {
                onAfterSelect(this, e);
            }
        }

        [Description("Occurs after double clicking a row int the datagrid.")]
        public event EventHandler<BookSelectedEventArgs> AfterSelect
        {
            add
            {
                onAfterSelect += value;
            }
            remove
            {
                onAfterSelect -= value;
            }
        }

        #endregion

        #region Methods

        private void Requery()
        {
            ObservableCollection<Book> books = null;
            if (this.categoryId == 1)
            {
                var result = from b in this.DbContext.Books
                             orderby b.Title ascending
                             select b;
                books = new ObservableCollection<Book>(result.ToList());
            }
            else
            {
                var result = from c in this.DbContext.Categories.Include("Books")
                             where c.ID == this.categoryId
                             from b in c.Books
                             orderby b.Title ascending
                             select b;
                books = new ObservableCollection<Book>(result.ToList());                
            }
            this.bindingSource1.DataSource = books.ToSortableBindingList();
        }

        private void SaveChanges()
        {
            this.Validate();              
            
            // Currently, the Entity Framework doesn’t mark the entities 
            // that are removed from a navigation property (Books) as 
            // deleted in the context. 
            // The following code uses LINQ to Objects against the Local  
            // collection to find all books and marks any that do not have 
            // a Category reference as deleted. 
            // The ToList call is required because otherwise the collection 
            // will be modified by the Remove call while it is being enumerated.             
            // In most other situations you can do LINQ to Objects directly  
            // against the Local property without using ToList first. 
            foreach (Book book in this.DbContext.Books.Local.ToList())             
            {                 
                if (book.Categories.Count == 0)                 
                {
                    this.DbContext.Books.Remove(book);                 
                }             
            }

            // Save the changes to the database.             
            this.DbContext.SaveChanges();              

            // Refresh the controls to show the values                      
            // that were generated by the database.             
            this.dataGridViewBooks.Refresh();             
            this.dataGridViewAuthors.Refresh();
            this.dataGridViewCategories.Refresh();
        }

        #endregion Methods
    }
}
