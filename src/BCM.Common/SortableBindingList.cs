using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Common
{
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Collections;
    using System.Reflection;
    using System.Xml.Linq;
    
    public class SortableBindingList<T> : BindingList<T>
    {
        #region Fields

        private bool isSorted = false;
        private PropertyDescriptor propertyDescriptor = null;
        private ListSortDirection sortDirection = ListSortDirection.Ascending;

        #endregion

        #region Constructor

        public SortableBindingList(IList<T> list) 
            : base(list) 
        { 
        }

        #endregion Constructor

        #region Properties

        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        protected override bool IsSortedCore
        {
            get { return this.isSorted; }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get { return this.propertyDescriptor; }
        }

        protected override ListSortDirection SortDirectionCore
        {
            get { return this.sortDirection; }
        }

        protected override bool SupportsSearchingCore
        {
            get { return true; }
        }

        #endregion Properties

        #region Methods

        protected override void RemoveSortCore()
        {
            this.isSorted = false;
            this.propertyDescriptor = null;
        }

        public override void EndNew(int itemIndex)
        {
            if ((this.IsSortedCore && itemIndex > 0) && (itemIndex == this.Count - 1))
            {
                ApplySortCore(this.SortPropertyCore, this.SortDirectionCore);
                base.EndNew(itemIndex);
            }
        }

        public void ApplySort(string propertyName, ListSortDirection direction)
        {
            PropertyDescriptor property = TypeDescriptor.GetProperties(typeof(T))[propertyName];
            if (property == null)
            {
                throw new ArgumentException(propertyName + " is not a valid property for type: " + typeof(T).Name, propertyName);
            }
            else
            {
                ApplySortCore(property, direction);
            }
        }

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            if (property.IsSortable())
            {
                List<T> items = this.Items as List<T>;
                PropertyComparer<T> propertyComparer = new PropertyComparer<T>(property, direction);
                items.Sort(propertyComparer);
                this.propertyDescriptor = property;
                this.sortDirection = direction;
                this.isSorted = true;
                this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
        }

        protected override int FindCore(PropertyDescriptor property, object key)
        {
            int count = this.Count;
            for (int i = 0; i < count; ++i)
            {
                T element = this[i];
                if (property.GetValue(element).Equals(key))
                {
                    return i;
                }
            }
            return -1;
        }

        public int Find(string propertyName, object key)
        {
            PropertyDescriptor property = TypeDescriptor.GetProperties(typeof(T))[propertyName];
            if (property == null)
            {
                throw new ArgumentException(propertyName + " is not a valid property for type: " + typeof(T).Name, propertyName);
            }
            else
            {
                return FindCore(property, key);
            }
        }
        
        #endregion
    }
}

