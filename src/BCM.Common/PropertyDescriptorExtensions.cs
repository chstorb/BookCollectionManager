using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Common
{
    using System.ComponentModel;
    using System.Xml.Linq;

    public static class PropertyDescriptorExtensions
    {
        public static bool SupportsComparable(this PropertyDescriptor property)
        {
            Type t = property.PropertyType;
            return (t.GetInterface("IComparable") != null)
                || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }

        public static bool SupportsStringComparer(this PropertyDescriptor property)
        {
            Type t = property.PropertyType;
            return (t.Equals(typeof(XNode)) || t.IsSubclassOf(typeof(XNode)));
        }
        
        public static bool IsSortable(this PropertyDescriptor property)
        {
            return property.SupportsComparable() || property.SupportsStringComparer();
        }
    }
}
