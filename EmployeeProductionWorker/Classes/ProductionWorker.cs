using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ProductionWorker: Employee
    {
        public ProductionWorker(int shift, decimal hpr, string employeeName, int employeeNumber) 
            : base(employeeName, employeeNumber)
        {
            Shift = shift;
            HourlyPayRate = hpr;
        }
        public int Shift { get; set; }
        public decimal HourlyPayRate { get; set; }     
    }
}
