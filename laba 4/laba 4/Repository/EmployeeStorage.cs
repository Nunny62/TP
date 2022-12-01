using System;
using laba_4.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace laba_4.Repository
{
    public class EmployeeStorage
    {
        private Dictionary<int, Employee> Employees { get; } = new Dictionary<int, Employee>();

        public void Create(Employee employee)
        {
            Employees.Add(employee.EmployeeID, employee);
        }

        public Employee Read(int employeeID)
        {
            return Employees[employeeID];
        }

        public Employee Update(int employeeID, Employee newEmployee)
        {
            Employees[employeeID] = newEmployee;
            return Employees[employeeID];
        }

        public bool Delete(int employeeID)
        {
            return Employees.Remove(employeeID);
        }
    }
}