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
    /// AuthorMetadata class
    /// </summary>
    [Table(Constants.TablePrefix + "Author")]
    public sealed class AuthorMetadata
    {
        private AuthorMetadata() { }

        [Display(Name = "LastName", ResourceType = typeof(Resources.Resources))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "FieldRequired")]
        public string LastName { get; set; }

        [Display(Name = "BirthName", ResourceType = typeof(Resources.Resources))]
        public string BirthName { get; set; }

        [Display(Name = "FirstName", ResourceType = typeof(Resources.Resources))]
        public string FirstName { get; set; }

        [Display(Name = "BirthDate", ResourceType = typeof(Resources.Resources))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> BirthDate { get; set; }

        [Display(Name = "BirthPlace", ResourceType = typeof(Resources.Resources))]
        public string BirthPlace { get; set; }

        [Display(Name = "Nationality", ResourceType = typeof(Resources.Resources))]
        public string Nationality { get; set; }

        [Display(Name = "DateOfDeath", ResourceType = typeof(Resources.Resources))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> DateOfDeath { get; set; }

        [Display(Name = "Nationality", ResourceType = typeof(Resources.Resources))]
        public string Photograph { get; set; }

        [Display(Name = "Notes", ResourceType = typeof(Resources.Resources))]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}
