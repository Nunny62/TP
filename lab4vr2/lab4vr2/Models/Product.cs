using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4vr2.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Product_name { get; set; }

        public string Product_description { get; set; }

        public decimal? Price { get; set; }

        public decimal? Assessment { get; set; }

        public int? TestID { get; set; }

    }
}
