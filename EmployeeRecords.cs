using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
 public   class EmployeeRecords
    {
           public bool AddRecords(EmployeeService service,Employee e)
        {
           return service.Add(e);
}

        public List<Employee> GetAllEmployeeRecors(EmployeeService service)
        {
            return service.GetAllEmployees();
        }
        public Employee GetEmployee(EmployeeService service ,int id)
        {
           return service.GetById(id);
        }

    }
}
