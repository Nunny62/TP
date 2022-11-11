using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Practice2
{
    public class Order
    {
        [Key]
        public int IDOrder { get; set; }

        public int IDEmployee { get; set; }

        public int IDClient { get; set; }

        public int IDDelivery { get; set; }

        public int IDMaking_an_order { get; set; }

        public string Payment_type { get; set; }

        public decimal? Order_cost { get; set; }

        public string Order_status { get; set; }

    }
}


