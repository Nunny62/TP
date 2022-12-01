using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab4vr2.Repository;

namespace lab4vr2.Controllers
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