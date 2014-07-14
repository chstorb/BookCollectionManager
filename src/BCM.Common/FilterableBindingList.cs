using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Common
{
    using System.ComponentModel;

    public class FilterableBindingList<T> : SortableBindingList<T>, IBindingListView
    {
        #region Fields

        private string filter = String.Empty;
        
        #endregion Fields

        #region Constructor

        public FilterableBindingList(IList<T> list)
            : base(list)
        {
        }
        
        #endregion Constructor

        #region IBindingListView 

        public void ApplySort(ListSortDescriptionCollection sorts)
        {
            throw new NotImplementedException();
        }

        public string Filter
        {
            get
            {
                return filter;
            }
            set
            {
                filter = value;
            }
        }

        public void RemoveFilter()
        {
            if (!String.IsNullOrEmpty(this.Filter))
            {
                this.Filter = String.Empty;
            }
        }

        public ListSortDescriptionCollection SortDescriptions
        {
            get { return null; }
        }

        public bool SupportsAdvancedSorting
        {
            get { return false; }
        }

        public bool SupportsFiltering
        {
            get { return true; }
        }

        #endregion IBindingListView
    }
}
