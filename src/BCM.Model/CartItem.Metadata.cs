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

    [Table(Constants.TablePrefix + "CartItem")]
    public sealed class CartItemMetadata
    {
        private CartItemMetadata() { }

        [Key]
        public string ItemId { get; set; }
    }
}
