using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (ApplicationContext db = new ApplicationContext())
            {
                var orders = db.Order.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order u in orders)
                {
                    Console.WriteLine(u.IDOrder + " - " + u.IDEmployee + " - " + u.IDClient + " - " + u.IDDelivery + " - " + u.IDMaking_an_order + " - " + u.Payment_type + " - " + u.Order_cost + " - " + u.Order_status);
                }
            }
            
            using (ApplicationContext db = new ApplicationContext())
            {
                Order test = new Order { IDOrder = 6, IDEmployee = 2, IDClient = 3, IDDelivery = 2, IDMaking_an_order = 1, Payment_type = "Онлайн", Order_cost = 5000, Order_status = "В пути"};
                db.Order.Add(test);
                db.SaveChanges();
                var orders = db.Order.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order u in orders)
                {
                    Console.WriteLine(u.IDOrder + " - " + u.IDEmployee + " - " + u.IDClient + " - " + u.IDDelivery + " - " + u.IDMaking_an_order + " - " + u.Payment_type + " - " + u.Order_cost + " - " + u.Order_status);
                }

            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Order upduser = (from Order in db.Order where Order.IDOrder == 6 select Order).First();
                if (upduser != null)
                {
                    upduser.Order_cost = upduser.Order_cost * 2;
                    db.SaveChanges();
                }
                var orders = db.Order.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order u in orders)
                {
                    Console.WriteLine(u.IDOrder + " - " + u.IDEmployee + " - " + u.IDClient + " - " + u.IDDelivery + " - " + u.IDMaking_an_order + " - " + u.Payment_type + " - " + u.Order_cost + " - " + u.Order_status);
                }

            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Order deluser = (from Order in db.Order where Order.IDOrder == 6 select Order).First();
                if (deluser != null)
                {
                    db.Order.Remove(deluser);
                    db.SaveChanges();
                }
                var orders = db.Order.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order u in orders)
                {
                    Console.WriteLine(u.IDOrder + " - " + u.IDEmployee + " - " + u.IDClient + " - " + u.IDDelivery + " - " + u.IDMaking_an_order + " - " + u.Payment_type + " - " + u.Order_cost + " - " + u.Order_status);
                }

            }
        }

    }
}
