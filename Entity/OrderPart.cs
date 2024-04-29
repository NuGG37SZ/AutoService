using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Entity
{
    public class OrderPart
    {
        public int OrderId { get; set; }
        public int InventoryId { get; set; }
        public int Quantity { get; set; }
    }
}
