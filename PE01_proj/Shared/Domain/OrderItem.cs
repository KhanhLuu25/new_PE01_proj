using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01_proj.Shared.Domain
{
    public class OrderItem : BaseDomainModel
    {
        public int OrderItemID { get; set; }
        public int OrderQty { get; set; }
        public int OrderID { get; set; }
        public virtual Orders Orders { get; set; }

        public int DeviceID { get; set; }
        public virtual Devices Devices { get; set; }
       
    }
}
