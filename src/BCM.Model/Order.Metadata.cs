using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Model
{
    using BCM.Common;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// OrderMetadata class
    /// </summary>
    [Table(Constants.TablePrefix + "Order")]
    public sealed class OrderMetadata
    {
        private OrderMetadata() { }
                
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Resources))]
        [StringLength(160)]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "FieldRequired")]
        public string FirstName { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Resources.Resources))]
        [StringLength(160)]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "FieldRequired")]
        public string LastName { get; set; }

        [Display(Name = "Address", ResourceType = typeof(Resources.Resources))]
        [StringLength(70)]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "FieldRequired")]
        public string Address { get; set; }

        [Display(Name = "City", ResourceType = typeof(Resources.Resources))]
        [StringLength(40)]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "FieldRequired")]
        public string City { get; set; }

        [Display(Name = "State", ResourceType = typeof(Resources.Resources))]
        [StringLength(40)]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "FieldRequired")]
        public string State { get; set; }

        [Display(Name = "PostalCode", ResourceType = typeof(Resources.Resources))]
        [StringLength(10)]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "FieldRequired")]
        public string PostalCode { get; set; }

        [Display(Name = "Country", ResourceType = typeof(Resources.Resources))]
        [StringLength(40)]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "FieldRequired")]
        public string Country { get; set; }

        [Display(Name = "Phone", ResourceType = typeof(Resources.Resources))]
        [StringLength(24)]
        public string Phone { get; set; }

        [Display(Name = "Email", ResourceType = typeof(Resources.Resources))]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email is is not valid.")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "FieldRequired")]
        public string Email { get; set; }

        [Display(Name = "Total", ResourceType = typeof(Resources.Resources))]
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public string PaymentTransactionId { get; set; }

        [ScaffoldColumn(false)]
        public bool HasBeenShipped { get; set; }
    }
}
