using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Author class
    /// </summary>
    [MetadataTypeAttribute(typeof(AuthorMetadata))]
    public partial class Author
    {
        /// <summary>
        /// Author ID (primary key)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Birth Name
        /// </summary>
        public string BirthName { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Birth Date
        /// </summary>
        public Nullable<DateTime> BirthDate { get; set; }

        /// <summary>
        /// Place Of Birth
        /// </summary>
        public string Birthplace { get; set; }

        /// <summary>
        /// Nationality
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// Date of death
        /// </summary>
        public Nullable<DateTime> DateofDeath { get; set; }

        /// <summary>
        /// Photograph
        /// </summary>
        public string Photograph { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Books navigation property
        /// </summary>
        public virtual List<Book> Books { get; set; }
   }
}
