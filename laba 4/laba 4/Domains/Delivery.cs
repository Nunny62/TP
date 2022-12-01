using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4.Domains
{
    public class Delivery
    {
        public int DeliveryID { get; set; }

        public string Type_of_delivery { get; set; } = string.Empty;

        public string Delivery_time { get; set; } = string.Empty;

        public decimal? Cost { get; set; }

    }
}
