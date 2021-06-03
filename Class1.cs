using System;

namespace Payroll
{
    public class Employee
    {
        public int empid;
        public string employeename;
        public string address;
        public String EmployeeName
        {
            get
            {
                return employeename;
            }
            set
            {
                employeename = value;
            }
        }
        public int EmployeeID
        {
            get
            {
                return empid;
            }
            set
            {
                empid = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
    }
}
