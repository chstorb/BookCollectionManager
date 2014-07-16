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
    
    //[DefaultEvent("AfterSelect")]
    //[System.ComponentModel.ComplexBindingProperties("DataSource", "DataMember")]
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

            this.treeView1.Nodes.Clear();

            string key = String.Empty;
            string parentKey = String.Empty;
            string text = String.Empty;

            Dictionary<string, TreeNode> nodesDictionary = new Dictionary<string, TreeNode>();
            TreeNode treeNode = null;

            var categories = from c in this.DbContext.Categories
                             orderby c.ParentCategoryID, c.Name 
                             select c;
            
            IList<Category> listCategories = categories.ToList();

            foreach (Category category in listCategories )
            {
                key = category.ID.ToString();
                parentKey = category.ParentCategoryID.ToString();
                text = category.Name;

                if (String.IsNullOrEmpty(parentKey) || (parentKey.Equals("-1")))
                {
                    treeNode = this.treeView1.Nodes.Add(key, text);
                    treeNode.Tag = key;
                    nodesDictionary.Add(key, treeNode);
                }
                else
                {
                    treeNode = nodesDictionary[parentKey].Nodes.Add(key, text);
                    treeNode.Tag = key;
                    nodesDictionary.Add(key, treeNode);
                }
            }
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

