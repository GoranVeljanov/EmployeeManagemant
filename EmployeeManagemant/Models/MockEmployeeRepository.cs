﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagemant.Models
{

    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@mail.com" },
                new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@mail.com" },
                new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@mail.com" }
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e=> e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}