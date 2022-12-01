using System;
using Practice2.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Practice2.Repository
{
    public class DeliveryStorage
    {
        private Dictionary<int, Delivery> Deliveries { get; } = new Dictionary<int, Delivery>();

        public void Create(Delivery delivery)
        {
            Deliveries.Add(delivery.DeliveryID, delivery);
        }

        public Delivery Read(int deliveryID)
        {
            return Deliveries[deliveryID];
        }

        public Delivery Update(int deliveryID, Delivery newDelivery)
        {
            Deliveries[deliveryID] = newDelivery;
            return Deliveries[deliveryID];
        }

        public bool Delete(int deliveryID)
        {
            return Deliveries.Remove(deliveryID);
        }
    }
}
