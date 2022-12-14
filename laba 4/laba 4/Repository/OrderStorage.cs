using System;
using laba_4.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace laba_4.Repository
{
    public class OrderStorage
    {
        private Dictionary<int, Order> Orders { get; } = new Dictionary<int, Order>();

        public void Create(Order order)
        {
            Orders.Add(order.OrderID, order);
        }

        public Order Read(int orderID)
        {
            return Orders[orderID];
        }

        public Order Update(int orderID, Order newOrder)
        {
            Orders[orderID] = newOrder;
            return Orders[orderID];
        }

        public bool Delete(int orderID)
        {
            return Orders.Remove(orderID);
        }
    }
}