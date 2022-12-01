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
    [Route("/test")]
    public class TestController : ControllerBase
    {
        [HttpPut]
        public Test Create(Test test)
        {
            Storage.TestStorage.Create(test);
            return test;
        }

        [HttpGet]
        public Test Read(int testId)
        {
            return Storage.TestStorage.Read(testId);
        }

        [HttpPost]
        public Test Update(int testId, Test newTest)
        {
            return Storage.TestStorage.Update(testId, newTest);
        }

        [HttpDelete]
        public bool Delete(int testId)
        {
            return Storage.TestStorage.Delete(testId); ;
        }
    }
}