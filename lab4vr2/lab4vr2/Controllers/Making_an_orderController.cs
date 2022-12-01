﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab4vr2.Repository;

namespace lab4vr2.Controllers
{
    [ApiController]
    [Route("/making_an_order")]
    public class Making_an_orderController : ControllerBase
    {
        [HttpPut]
        public Making_an_order Create(Making_an_order making_an_order)
        {
            Storage.Making_an_orderStorage.Create(making_an_order);
            return making_an_order;
        }

        [HttpGet]
        public Making_an_order Read(int making_an_orderId)
        {
            return Storage.Making_an_orderStorage.Read(making_an_orderId);
        }

        [HttpPost]
        public Making_an_order Update(int making_an_orderId, Making_an_order newMaking_an_order)
        {
            return Storage.Making_an_orderStorage.Update(making_an_orderId, newMaking_an_order);
        }

        [HttpDelete]
        public bool Delete(int making_an_orderId)
        {
            return Storage.Making_an_orderStorage.Delete(making_an_orderId); ;
        }
    }
}
