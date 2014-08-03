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
    /// BookMetadata class
    /// </summary>
    [Table(Constants.TablePrefix + "Book")]
    public sealed class BookMetadata
    {
        private BookMetadata() { }

        [Display(Name = "Title", ResourceType = typeof(Resources.Resources))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "FieldRequired")]
        public string Title { get; set; }

        [Display(Name = "CopyrightYear", ResourceType = typeof(Resources.Resources))]
        public int CopyrightYear { get; set; }

        [Display(Name = "ISBNNumber", ResourceType = typeof(Resources.Resources))]
        public string ISBNNumber { get; set; }

        [Display(Name = "PublishingCompany", ResourceType = typeof(Resources.Resources))]
        public string PublishingCompany { get; set; }

        [Display(Name = "PublisherName", ResourceType = typeof(Resources.Resources))]
        public string PublisherName { get; set; }

        [Display(Name = "PublishingYear", ResourceType = typeof(Resources.Resources))]
        public int PublishingYear { get; set; }

        [Display(Name = "PlaceOfPublication", ResourceType = typeof(Resources.Resources))]
        public string PlaceOfPublication { get; set; }

        [Column(TypeName="nvarchar(max)")]
        [Display(Name = "Language", ResourceType = typeof(Resources.Resources))]
        public string Language { get; set; }

        [Display(Name = "VolumeNumber", ResourceType = typeof(Resources.Resources))]
        public int VolumeNumber { get; set; }

        [Display(Name = "EditionNumber", ResourceType = typeof(Resources.Resources))]
        public int EditionNumber { get; set; }

        [Display(Name = "CoverType", ResourceType = typeof(Resources.Resources))]
        public string CoverType { get; set; }

        [Display(Name = "Pages", ResourceType = typeof(Resources.Resources))]
        public int Pages { get; set; }

        [Display(Name = "Location", ResourceType = typeof(Resources.Resources))]
        public string Location { get; set; }

        [Display(Name = "Notes", ResourceType = typeof(Resources.Resources))]
        public string Notes { get; set; }

        [Display(Name = "PurchasePrice", ResourceType = typeof(Resources.Resources))]
        [DataType(DataType.Currency)]
        public decimal PurchasePrice { get; set; }

        [Display(Name = "DatePurchased", ResourceType = typeof(Resources.Resources))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> DatePurchased { get; set; }

        [Display(Name = "ListPrice", ResourceType = typeof(Resources.Resources))]
        [DataType(DataType.Currency)]
        public decimal ListPrice { get; set; }
    }
}
