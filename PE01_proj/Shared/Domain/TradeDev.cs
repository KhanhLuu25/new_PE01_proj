using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01_proj.Shared.Domain
{
    public class TradeDev : BaseDomainModel
    {
        public int TradeDevID { get; set; }
        public string TradeDevType { get; set; }
        public int TradeDecPrice { get; set; }
        public int DeviceID { get; set; }
        public virtual Device Devices { get; set; }
        public int CustID {get;set;}
        public virtual Customer Customers { get; set; }


    }
}
