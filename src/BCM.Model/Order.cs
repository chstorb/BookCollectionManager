using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Model
{
    using System.ComponentModel.DataAnnotations;
    
    /// <summary>
    /// Order class
    /// </summary>
    [MetadataTypeAttribute(typeof(OrderMetadata))]
    public partial class Order
    {
        /// <summary>
        /// Order Id (primary key)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Order date
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Payment transaction id
        /// </summary>
        public string PaymentTransactionId { get; set; }

        /// <summary>
        /// Has been shipped
        /// </summary>
        public bool HasBeenShipped { get; set; }

        /// <summary>
        /// Order details navigation property
        /// </summary>
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
