using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Reflection.Extensions
{
    using System.Reflection;

    /// <summary>
    /// AssemblyExtensions class
    /// </summary>
    public static class AssemblyExtensions
    {
        public static string About(this Assembly assembly)
        {
            string about = String.Empty;
            AssemblyProductAttribute productAttribute = assembly.GetCustomAttributes(
                typeof(AssemblyProductAttribute), true).FirstOrDefault() as AssemblyProductAttribute;
            if (productAttribute != null)
            {
                about = productAttribute.Product.ToString();
            }
            Version version = assembly.GetName().Version;
            if (version != null)
            {
                if (about.Length > 0)
                {
                    about = String.Format("{0} {1}.{2}.{3}", about, version.Major, version.Minor, version.Build);
                }
                else
                {
                    about = String.Format("Version {1}.{2}.{3}", version.Major, version.Minor, version.Build);
                }
            }
            return about;
        }
    }
}
