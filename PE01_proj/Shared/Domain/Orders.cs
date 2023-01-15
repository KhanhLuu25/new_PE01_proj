using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01_proj.Shared.Domain
{
    public class Orders
    {
        public int OrderID { get; set; }
        public DateTime OrdDateTime { get; set; }
        public int TotalPrice { get; set; }
        public int Orderquantity { get; set; }
        public int StaffID { get; set; }
        public virtual Staffs Staffs { get; set; }
        public int CustomerID { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
        public virtual List<Payment> Payments { get; set; }



    }
}
