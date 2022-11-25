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
    [Route("/product")]
    public class ProductController : ControllerBase
    {
        [HttpPut]
        public Product Create(Product product)
        {
            Storage.ProductStorage.Create(product);
            return product;
        }

        [HttpGet]
        public Product Read(int productId)
        {
            return Storage.ProductStorage.Read(productId);
        }

        [HttpPost]
        public Product Update(int productId, Product newProduct)
        {
            return Storage.ProductStorage.Update(productId, newProduct);
        }

        [HttpDelete]
        public bool Delete(int productId)
        {
            return Storage.ProductStorage.Delete(productId);
        }
    }
}