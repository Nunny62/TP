using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab4vr2.Repository;

namespace lab4vr2.Controllers
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
