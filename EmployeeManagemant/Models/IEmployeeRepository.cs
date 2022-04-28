﻿using System.Collections.Generic;
namespace EmployeeManagemant.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployee();

        Employee Add(Employee employee);
        
    }
}
 