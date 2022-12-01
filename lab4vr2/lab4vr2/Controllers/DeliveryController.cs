using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab4vr2.Repository;

namespace lab4vr2.Controllers
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
