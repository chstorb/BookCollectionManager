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
    /// OrderDetailMetadata class
    /// </summary>
    [Table(Constants.TablePrefix + "OrderDetail")]
    public sealed class OrderDetailMetadata
    {
        private OrderDetailMetadata() { }
    }
}
