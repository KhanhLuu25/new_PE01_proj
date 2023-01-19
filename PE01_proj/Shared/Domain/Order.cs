using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01_proj.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public int OrderID { get; set; }
        public DateTime OrdDateTime { get; set; }
        public int TotalPrice { get; set; }
        public int Orderquantity { get; set; }
        public int StaffID { get; set; }
        public virtual Staff Staffs { get; set; }
        public int CustID { get; set; }
        public virtual Customer Customers { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
        public virtual List<Payment> Payments { get; set; }



    }
}
