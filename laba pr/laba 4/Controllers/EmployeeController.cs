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
    [Route("/employee")]
    public class EmployeeController : ControllerBase
    {
        [HttpPut]
        public Employee Create(Employee employee)
        {
            Storage.EmployeeStorage.Create(employee);
            return employee;
        }

        [HttpGet]
        public Employee Read(int employeeId)
        {
            return Storage.EmployeeStorage.Read(employeeId);
        }

        [HttpPost]
        public Employee Update(int employeeId, Employee newEmployee)
        {
            return Storage.EmployeeStorage.Update(employeeId, newEmployee);
        }

        [HttpDelete]
        public bool Delete(int employeeId)
        {
            return Storage.EmployeeStorage.Delete(employeeId); ;
        }
    }
}
