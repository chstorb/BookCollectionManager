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
    /// CategoryMetadata class
    /// </summary>
    [Table(Constants.TablePrefix + "Category")]
    public sealed class CategoryMetadata
    {
        private CategoryMetadata() { }
        
        [Display(Name = "Name", ResourceType = typeof(Resources.Resources))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "FieldRequired")]
        public string Name { get; set; }

        [Display(Name = "Description", ResourceType = typeof(Resources.Resources))]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}
