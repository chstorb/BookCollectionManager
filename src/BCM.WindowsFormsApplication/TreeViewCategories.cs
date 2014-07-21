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
    using BCM.DAL;
    using BCM.Model;
    
    public partial class TreeViewCategories : UserControl
    {
        #region Public Properties

        [Browsable(false)]
        public ApplicationDbContext DbContext { get; set; }

        #endregion Properties

        #region Constructor

        public TreeViewCategories()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Event Handler
        
        private void TreeViewCategories_Load(object sender, EventArgs e)
        {
            if ((this.Site != null) && (this.Site.DesignMode))
                return;

            var categories = from c in this.DbContext.Categories
                             orderby c.ParentCategoryID, c.Name 
                             select c;
            
            IList<Category> listCategories = categories.ToList();

            this.treeView1.NoParentIndicator = "-1";
            this.treeView1.KeyMember = "ID";
            this.treeView1.ParentKeyMember = "ParentCategoryID";
            this.treeView1.TextMember = "Name";
            this.treeView1.DataSource = listCategories;

            this.treeView1.ExpandAll();
        }
        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (onAfterSelect != null)
            {
                onAfterSelect(this, e);
            }
        }

        #endregion Event Handler

        #region Events

        private TreeViewEventHandler onAfterSelect;

        protected virtual void OnAfterSelect(TreeViewEventArgs e)
        {
            if (onAfterSelect != null)
            {
                onAfterSelect(this, e);
            }
        }

        [Description("Occurs after the tree node is selected.")]
        public event TreeViewEventHandler AfterSelect
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

        #endregion Events
    }
}

