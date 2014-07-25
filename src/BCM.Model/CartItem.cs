using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// CartItem class
    /// </summary>
    [MetadataTypeAttribute(typeof(CartItemMetadata))]
    public class CartItem
    {
        /// <summary>
        /// ItemId
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// CartId
        /// </summary>
        public string CartId { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// BookId
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Book navigation property
        /// </summary>
        public virtual Book Book { get; set; }
    }
}
