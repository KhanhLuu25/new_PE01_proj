using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01_proj.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string StaffAddress { get; set; }
        public string StaffPosition { get; set; }
        public List<Order> Orders { get; set; }
        public List<Trade> Trades { get; set; }


    }
}
