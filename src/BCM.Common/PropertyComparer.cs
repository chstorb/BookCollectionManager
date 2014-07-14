using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Common
{
    using System.Collections;
    using System.ComponentModel;
    using System.Reflection;
        
    public class PropertyComparer<T> : Comparer<T>
    {
        #region Fields

        private readonly PropertyDescriptor propertyDescriptor;
        private readonly ListSortDirection sortDirection;
        private readonly IComparer comparer;
        private readonly bool userStringComparer = false;

        #endregion Fields

        #region Constructor

        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            if (property.ComponentType != typeof(T))
            {
                throw new MissingMemberException(typeof(T).Name, property.Name);
            }
            if (property.SupportsComparable())
            {
                Type t = typeof(Comparer<>).MakeGenericType(property.PropertyType);
                PropertyInfo propertyInfo = t.GetProperty("Default");
                this.comparer = (IComparer)propertyInfo.GetValue(null, null);
            }
            else if (property.SupportsStringComparer())
            {
                this.comparer = StringComparer.CurrentCultureIgnoreCase;
                this.userStringComparer = true;
            }
            this.propertyDescriptor = property;
            this.sortDirection = direction;
        }

        #endregion Constructor
        
        #region ICompare

        public override int Compare(T x, T y)
        {
            object xValue = propertyDescriptor.GetValue(x);
            object yValue = propertyDescriptor.GetValue(y);

            if (userStringComparer)
            {
                xValue = xValue != null ? xValue.ToString() : null;
                yValue = yValue != null ? yValue.ToString() : null;
            }

            if (sortDirection == ListSortDirection.Ascending)
            {
                return comparer.Compare(xValue, yValue);
            }
            else
            {
                return comparer.Compare(yValue, xValue);
            }
        }

        #endregion ICompare
    }
}
