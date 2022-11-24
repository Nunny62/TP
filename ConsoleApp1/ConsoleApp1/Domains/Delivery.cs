using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Domains
{
    public class Delivery
    {
        public int IDDelivery { get; set; }

        public string Type_of_delivery { get; set; }

        public string Delivery_time { get; set; }

        public decimal? Cost { get; set; }

    }
}
