using System;
using lab4vr2.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace lab4vr2.Repository
{
    public class ProductStorage
    {
        private Dictionary<int, Product> Products { get; } = new Dictionary<int, Product>();

        public void Create(Product product)
        {
            Products.Add(product.ProductID, product);
        }

        public Product Read(int productID)
        {
            return Products[productID];
        }

        public Product Update(int productID, Product newProduct)
        {
            Products[productID] = newProduct;
            return Products[productID];
        }

        public bool Delete(int productID)
        {
            return Products.Remove(productID);
        }
    }
}