using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// OrderDetail class
    /// </summary>
    [MetadataTypeAttribute(typeof(OrderDetailMetadata))]
    public partial class OrderDetail
    {
        /// <summary>
        /// Order detail id (primary key)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Order id (foreign key)
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Book id (foreign key)
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        public int Quantity { get; set; }
        
        /// <summary>
        /// List/unit price 
        /// </summary>
        public Nullable<double> ListPrice { get; set; }
    }
}
