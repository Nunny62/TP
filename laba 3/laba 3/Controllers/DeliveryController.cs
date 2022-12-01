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
    [Route("/delivery")]
    public class DeliveryController : ControllerBase
    {
        [HttpPut]
        public Delivery Create(Delivery delivery)
        {
            Storage.DeliveryStorage.Create(delivery);
            return delivery;
        }

        [HttpGet]
        public Delivery Read(int deliveryId)
        {
            return Storage.DeliveryStorage.Read(deliveryId);
        }

        [HttpPost]
        public Delivery Update(int deliveryId, Delivery newDelivery)
        {
            return Storage.DeliveryStorage.Update(deliveryId, newDelivery);
        }

        [HttpDelete]
        public bool Delete(int deliveryId)
        {
            return Storage.DeliveryStorage.Delete(deliveryId); ;
        }
    }
}
