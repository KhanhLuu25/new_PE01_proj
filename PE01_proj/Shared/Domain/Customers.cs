using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01_proj.Shared.Domain
{
    public class Customers
    {
        public int CustID { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get;set;}
        public string CustEmail { get; set; }
        public int CustContactNo { get; set;}
        public virtual List<Orders> Orders { get; set; }
        public virtual List<Trade> Trades { get; set; }
        public virtual List<TradeDev> TradeDevs { get; set; }
    }
}
