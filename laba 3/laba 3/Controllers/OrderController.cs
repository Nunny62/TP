using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice2.Domains;
using Practice2.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Practice2.Controllers
{
    [ApiController]
    [Route("/order")]
    public class OrderController : ControllerBase
    {
        [HttpPut]
        public Order Create(Order order)
        {
            Storage.OrderStorage.Create(order);
            return order;
        }

        [HttpGet]
        public Order Read(int orderId)
        {
            return Storage.OrderStorage.Read(orderId);
        }

        [HttpPost]
        public Order Update(int orderId, Order newOrder)
        {
            return Storage.OrderStorage.Update(orderId, newOrder);
        }

        [HttpDelete]
        public bool Delete(int orderId)
        {
            return Storage.OrderStorage.Delete(orderId); ;
        }
    }
}
