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

        public static void NewProductionWorker()
        {
            string employeeName;
            int employeeNumber = 0;
            int shift = 0;
            decimal hourlyPayRate;

            Console.Write("Enter an employee name > ");
            employeeName = Console.ReadLine();

            Console.Write("Enter an employee number > ");
            while (!int.TryParse(Console.ReadLine(), out employeeNumber))
            {
                Console.Write("Enter a valid number > ");
            }

            Console.Write("Enter a shift > ");
            while (!int.TryParse(Console.ReadLine(), out shift))
            {
                Console.Write("Enter a valid shift > ");
            }

            Console.Write("Enter an hourly pay rate > ");
            while (!decimal.TryParse(Console.ReadLine(), out hourlyPayRate))
            {
                Console.Write("Not a valid hourly pay rate. Try again > ");
            }

            ProductionWorker epw = new ProductionWorker(shift, hourlyPayRate, employeeName, employeeNumber);

            Console.WriteLine($"\nEmployee name: {epw.EmployeeName}\nEmployee number: {epw.EmployeeNumber}\n" +
                              $"Shift: {epw.Shift}\nHourly pay rate: ${epw.HourlyPayRate}");
        }
    }
}
