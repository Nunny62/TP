using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Domains
{
    public class Product
    {
        public int IDProduct { get; set; }

        public string Product_name { get; set; }

        public string Product_description { get; set; }

        public decimal? Price { get; set; }

        public decimal? Assessment { get; set; }

        public int? IDTest { get; set; }

    }
}
