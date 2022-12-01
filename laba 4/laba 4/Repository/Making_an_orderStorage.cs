using System;
using laba_4.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace laba_4.Repository
{
    public class Making_an_orderStorage
    {
        private Dictionary<int, Making_an_order> Making_an_orders { get; } = new Dictionary<int, Making_an_order>();

        public void Create(Making_an_order making_an_order)
        {
            Making_an_orders.Add(making_an_order.Making_an_orderID, making_an_order);
        }

        public Making_an_order Read(int making_an_orderID)
        {
            return Making_an_orders[making_an_orderID];
        }
        
        public Making_an_order Update(int making_an_orderID, Making_an_order newMaking_an_order)
        {
            Making_an_orders[making_an_orderID] = newMaking_an_order;
            return Making_an_orders[making_an_orderID];
        }

        public bool Delete(int making_an_orderID)
        {
            return Making_an_orders.Remove(making_an_orderID);
        }
    }
}