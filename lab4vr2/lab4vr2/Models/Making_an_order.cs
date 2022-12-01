using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4vr2.Models
{
    public class Making_an_order
    {
        public int Making_an_orderID { get; set; }

        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public int? Quantity { get; set; }

        public decimal? Cost { get; set; }

    }
}
