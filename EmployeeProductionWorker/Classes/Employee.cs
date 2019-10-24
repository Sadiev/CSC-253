using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Employee
    {
        public Employee(string employeeName, int employeeNumber)
        {
            EmployeeName = employeeName;
            EmployeeNumber = employeeNumber;
        }

        public string EmployeeName { get; set; }
        public int EmployeeNumber { get; set; }
    }
}
