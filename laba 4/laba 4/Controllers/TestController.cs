using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using laba_4.Domains;
using laba_4.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace laba_4.Controllers
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