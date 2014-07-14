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
    
    public partial class TreeViewAuthors : UserControl
    {
        #region Public Properties

        [Browsable(false)]
        public ApplicationDbContext DbContext { get; set; }

        #endregion

        public TreeViewAuthors()
        {
            InitializeComponent();
        }

        #region Event Handler

        private void TreeViewAuthors_Load(object sender, EventArgs e)
        {
            if ((this.Site != null) && (this.Site.DesignMode))
                return;

            this.treeView1.Nodes.Clear();

            //string key = String.Empty;
            //string parentKey = String.Empty;
            //string text = String.Empty;

            //Dictionary<string, TreeNode> nodesDictionary = new Dictionary<string, TreeNode>();
            //TreeNode treeNode = null;

            //foreach (Category category in this.DbContext.Categories)
            //{
            //    key = category.ID.ToString();
            //    parentKey = category.ParentCategoryID.ToString();
            //    text = category.Name;

            //    if (String.IsNullOrEmpty(parentKey) || (parentKey.Equals("-1")) )
            //    {                    
            //        treeNode = this.treeView1.Nodes.Add(key, text);
            //        treeNode.Tag = key;
            //        nodesDictionary.Add(key, treeNode);
            //    }
            //    else 
            //    {
            //        treeNode = nodesDictionary[parentKey].Nodes.Add(key, text);
            //        treeNode.Tag = key;
            //        nodesDictionary.Add(key, treeNode);
            //    }
            //}

            this.treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (onAfterSelect != null)
            {
                onAfterSelect(this, e);
            }
        }

        #endregion

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

        #endregion
    }
}
