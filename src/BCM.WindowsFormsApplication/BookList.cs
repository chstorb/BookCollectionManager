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

    public partial class BookList : UserControl
    {
        int _categoryId = 1;

        public BookList()
        {
            InitializeComponent();
        }

        #region Event Handler

        private void BookList_Load(object sender, EventArgs e)
        {
            if ((this.Site != null) && (this.Site.DesignMode))
            {
                return;
            }
            this.LoadData();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            try
            {
                // User Load to query for entities before binding to the local collection.
                // (For further information see: http://msdn.microsoft.com/en-us/data/jj592911.aspx)
                this.DbContext.Categories.Include("Books").Load();

                this.bindingSource1.DataSource = this.DbContext.Books.Local.ToSortableBindingList();
                
                this.bindingNavigator1.BindingSource = this.bindingSource1;

                DataGridViewColumn[] ar = new DataGridViewColumn[this.dataGridViewBooks.Columns.Count];
                this.dataGridViewBooks.Columns.CopyTo(ar, 0);

                this.dataGridViewBooks.Columns.Clear();

                this.dataGridViewBooks.DataSource = this.bindingSource1;

                for (int i = 0; i < ar.Length; i++)
                {
                    DataGridViewColumn col = ar[i];
                    this.dataGridViewBooks.Columns[i].Visible = col.Visible;
                    this.dataGridViewBooks.Columns[i].Width = col.Width;
                    this.dataGridViewBooks.Columns[i].HeaderText = col.HeaderText;
                    this.dataGridViewBooks.Columns[i].DefaultCellStyle = col.DefaultCellStyle;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Requery()
        {
            var result = from c in this.DbContext.Categories.Include("Books")
                         where c.ID == this._categoryId
                         from b in c.Books
                         select b;

            ObservableCollection<Book> books = new ObservableCollection<Book>(result.ToList());
            this.bindingSource1.DataSource = books.ToSortableBindingList();
        }

        public void FilterByCategoryId(int categoryId)
        {
            if (this._categoryId == categoryId)
                return;

            this._categoryId = categoryId;
            this.Requery();
        }

        #endregion

        #region Public Properties

        public ApplicationDbContext DbContext { get; set; }

        public string Filter
        {
            get { return this.bindingSource1.Filter; }
            set { this.bindingSource1.Filter = value; }
        }

        #endregion

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
    }
}
