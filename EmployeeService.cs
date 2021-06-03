using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public interface EmployeeService
    {
         bool Add(Employee e);
         Employee GetById(int i);
          List<Employee> GetAllEmployees();
    }
}
