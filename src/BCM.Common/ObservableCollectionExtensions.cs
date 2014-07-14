using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BCM.Common
{
    using System.Collections.ObjectModel;

    public static class ObservableCollectionExtensions 
    {
        public static FilterableBindingList<T> ToFilterableBindingList<T>(this ObservableCollection<T> source) 
            where T : class
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            return new FilterableBindingList<T>(source.ToList());
        }

        public static SortableBindingList<T> ToSortableBindingList<T>(this ObservableCollection<T> source)
            where T : class
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            return new SortableBindingList<T>(source.ToList());
        }
    }
}
