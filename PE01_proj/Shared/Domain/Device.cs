using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01_proj.Shared.Domain
{
    public class Device : BaseDomainModel
    {
        public int DeviceID { get; set; }
        public string DevName { get; set; }
        public string DevDesc { get; set; }
        public string DevCost { get; set; }
        public string DevType { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
        public virtual List<TradeDev> TradeDevs { get; set; }
    }
}
