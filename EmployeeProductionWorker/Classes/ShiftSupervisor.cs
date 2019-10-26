using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ShiftSupervisor : Employee
    {
        public ShiftSupervisor(decimal annualSalary, decimal annualBonus, string employeeName, int employeeNumber) : base(employeeName, employeeNumber)
        {
            AnnualSalary = annualSalary;
            AnnualBonus = annualBonus;           
        }
        public decimal AnnualSalary { get; set; }
        public decimal AnnualBonus { get; set; }
    }
}
