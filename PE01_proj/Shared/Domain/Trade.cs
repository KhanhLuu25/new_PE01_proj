using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01_proj.Shared.Domain
{
    public class Trade : BaseDomainModel
    {
        public int TradeID { get; set; }
        public DateTime TradeDateTime { get; set; }
        public int TotalTradeAmount { get; set; }
        public int StaffID { get; set; }
        public virtual Staffs Staffs { get; set; }
        public int CustID { get; set; }
        public virtual Customers Customers { get; set; }
    }
}
