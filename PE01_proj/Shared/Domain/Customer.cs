using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01_proj.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public int CustID { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get;set;}
        public string CustEmail { get; set; }
        public string CustContactNo { get; set;}
        public virtual List<Order> Orders { get; set; }
        public virtual List<Trade> Trades { get; set; }
        public virtual List<TradeDev> TradeDevs { get; set; }
    }
}
