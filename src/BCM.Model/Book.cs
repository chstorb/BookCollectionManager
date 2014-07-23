using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Model
{
    using BCM.Common;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Book class
    /// </summary>
    [MetadataTypeAttribute(typeof(BookMetadata))]
    public partial class Book
    {
        private readonly ObservableListSource<Author> _authors =
            new ObservableListSource<Author>();

        private readonly ObservableListSource<Category> _categories =
            new ObservableListSource<Category>();

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
        public Nullable<int> CopyrightYear { get; set; }

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
        public Nullable<int> PublishingYear { get; set; }

        /// <summary>
        /// Place of publication, usually a city, such as New York or London 
        /// </summary>
        public string PlaceOfPublication { get; set; }

        /// <summary>
        /// The volume number.
        /// </summary>
        public Nullable<int> VolumeNumber { get; set; }

        /// <summary>
        /// The edition number. 
        /// </summary>
        public Nullable<int> EditionNumber { get; set; }

        /// <summary>
        /// Cover type
        /// </summary>
        public string CoverType { get; set; }

        /// <summary>
        /// Number of pages.
        /// </summary>
        public Nullable<int> Pages { get; set; }

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
        public Nullable<decimal> PurchasePrice { get; set; }

        /// <summary>
        /// Date Purchased
        /// </summary>
        public Nullable<DateTime> DatePurchased { get; set; }

        /// <summary>
        /// List price / Unit price
        /// </summary>
        public Nullable<decimal> ListPrice { get; set; }

        /// <summary>
        /// Image Url 1
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Image Url 2
        /// </summary>
        public string ImageUrl2 { get; set; }

        /// <summary>
        /// Image Url 3
        /// </summary>
        public string ImageUrl3 { get; set; }

        /// <summary>
        /// Image Url 4
        /// </summary>
        public string ImageUrl4 { get; set; }

        /// <summary>
        /// Categories navigation property
        /// </summary>
        //public virtual List<Category> Categories { get; set; }
        public virtual ObservableListSource<Category> Categories { get { return _categories; } }

        /// <summary>
        /// Authors navigation property
        /// </summary>
        //public virtual List<Author> Authors { get; set; }
        public virtual ObservableListSource<Author> Authors { get { return _authors; } }
    }
}
