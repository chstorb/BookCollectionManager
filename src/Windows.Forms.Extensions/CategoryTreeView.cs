using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Forms.Extensions
{
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
 
    /// <summary>
    /// CategoryTreeView class
    /// </summary>
    public class CategoryTreeView : TreeView
    {
        #region Fields

        private object dataSource = null;      

        private string keyMember = String.Empty;

        private string parentKeyMember = String.Empty;

        private string textMember = String.Empty;

        private string noParentIndicator = "-1";

        private CurrencyManager dataManager = null;

        #endregion Fields

        #region Properties

        [Category("Data")]
        public object DataSource 
        {
            get
            {
                return this.dataSource;   
            }
            set
            {
                if (value == null)
                {
                    this.dataSource = null;

                }
                else
                {
                    if (!((value is IList) || (value is IListSource)))
                    {
                        throw new Exception(Constants.InvalidDataSource);
                    }
                    if (value is IListSource)
                    {
                        IListSource listSource = value as IListSource;
                        if (listSource.ContainsListCollection)
                        {
                            throw new Exception(Constants.InvalidDataSource);
                        }
                    }
                    this.dataSource = value;
                    this.BindingContext = value as BindingContext;
                    this.dataManager = this.BindingContext[this.dataSource] as CurrencyManager;
                    this.AddNodes();
                }
            }
        }

        [Category("Data")]
        public string TextMember
        {
            get
            {
                return this.textMember;
            }
            set
            {
                this.textMember = value;
            }
        }

        public string ParentKeyMember 
        {
            get
            {
                return this.parentKeyMember;
            }
            set
            {
                this.parentKeyMember = value;
            }
        }

        [Category("Data")]
        public string KeyMember 
        {
            get
            {
                return this.keyMember;
            }
            set
            {
                this.keyMember = value;
            }
        }

        [Category("Data")]
        public string NoParentIndicator
        { 
            get
            {
                return this.noParentIndicator;
            }
            set
            {
                this.noParentIndicator = value;
            }
        }

        public bool HasData
        {
            get
            {
                if ((this.dataManager != null) && (this.dataManager.List != null))
                {
                    return (this.dataManager.List.Count > 0);
                }
                return false;
            }
        }

        #endregion Properties

        #region Methods

        private void AddNodes()
        {
            this.Nodes.Clear();

            if (this.HasData)
            {
                string key = String.Empty;
                string parentKey = String.Empty;
                string text = String.Empty;

                Dictionary<string, TreeNode> nodesDictionary = new Dictionary<string, TreeNode>();
                TreeNode node = null;

                PropertyDescriptor propKey = this.dataManager.GetItemProperties()[this.KeyMember];
                PropertyDescriptor propParentKey = this.dataManager.GetItemProperties()[this.ParentKeyMember];
                PropertyDescriptor propText = this.dataManager.GetItemProperties()[this.TextMember];

                foreach (object category in this.dataManager.List)
                {
                    key =  propKey.GetValue(category).ToString();
                    parentKey = propParentKey.GetValue(category).ToString();
                    text = propText.GetValue(category).ToString();

                    if (String.IsNullOrEmpty(parentKey) || (parentKey.Equals(this.NoParentIndicator)))
                    {
                        node = this.Nodes.Add(key, text);
                    }
                    else
                    {
                        node = nodesDictionary[parentKey].Nodes.Add(key, text);
                    }
                    node.Tag = key;
                    nodesDictionary.Add(key, node);
                }
            }            
        }

        #endregion Methods
    }
}
