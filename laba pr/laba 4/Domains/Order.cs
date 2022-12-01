using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace laba_4.Domains
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public int EmployeeID { get; set; }

        public int ClientID { get; set; }

        public int DeliveryID { get; set; }

        public int Making_an_orderID { get; set; }

        public string Payment_type { get; set; }

        public decimal? Order_cost { get; set; }

        public string Order_status { get; set; }

    }
}


