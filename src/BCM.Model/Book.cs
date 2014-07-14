using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Book class
    /// </summary>
    [MetadataTypeAttribute(typeof(BookMetadata))]
    public partial class Book
    {
        /// <summary>
        /// Book Id (primary key)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Book title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The year of a copyright of the book.
        /// </summary>
        public int CopyrightYear { get; set; }

        /// <summary>
        /// International Standard Book Number, the international code for identifying a particular version or printing of a book .
        /// </summary>
        public string ISBNNumber { get; set; }

        /// <summary>
        /// Name of the company, or other entity which published a work 
        /// </summary>
        public string PublishingCompany { get; set; }

        /// <summary>
        /// Name of the person which published a work 
        /// </summary>
        public string PublisherName { get; set; }

        /// <summary>
        /// Year the book was published.
        /// </summary>
        public int PublishingYear { get; set; }

        /// <summary>
        /// Place of publication, usually a city, such as New York or London 
        /// </summary>
        public string PlaceOfPublication { get; set; }

        /// <summary>
        /// The volume number.
        /// </summary>
        public int VolumeNumber { get; set; }

        /// <summary>
        /// The edition number. 
        /// </summary>
        public int EditionNumber { get; set; }

        /// <summary>
        /// Cover type
        /// </summary>
        public string CoverType { get; set; }

        /// <summary>
        /// Number of pages.
        /// </summary>
        public int Pages { get; set; }

        /// <summary>
        /// Location (Shelf number ...)
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// The purchase price
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Date Purchased
        /// </summary>
        public Nullable<DateTime> DatePurchased { get; set; }

        /// <summary>
        /// List price
        /// </summary>
        public decimal ListPrice { get; set; }

        /// <summary>
        /// Categories navigation property
        /// </summary>
        public virtual List<Category> Categories { get; set; }

        /// <summary>
        /// Authors navigation property
        /// </summary>
        public virtual List<Author> Authors { get; set; }
    }

}
