﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01_proj.Shared.Domain
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public string CardName { get; set; }
        public int CardNo { get; set; }
        public int OrderID { get; set; }
        public virtual Orders Orders { get; set; }

    }
}