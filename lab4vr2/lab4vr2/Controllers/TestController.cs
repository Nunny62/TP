using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab4vr2.Repository;

namespace lab4vr2.Controllers
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