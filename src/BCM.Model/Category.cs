using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Category class
    /// </summary>
    [MetadataTypeAttribute(typeof(CategoryMetadata))]
    public partial class Category
    {
        /// <summary>
        /// Category Id (primary key)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Parent Category ID
        /// </summary>
        public int ParentCategoryID { get; set; }

        /// <summary>
        /// Books navigation property
        /// </summary>
        public List<Book> Books { get; set; }
    }
}
