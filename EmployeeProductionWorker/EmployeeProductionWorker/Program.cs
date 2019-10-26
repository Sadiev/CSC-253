using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

/**
* 10/25/2019
* CSC 253
* Dilshod Sadiev
* ShiftSupervisor Class / Employee and ProductionWorker Classes
*/

namespace EmployeeProductionWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewProductionWorker();
            NewShiftSupervisor();

            Console.WriteLine("\nPress any key to exit ...");
            Console.ReadLine();
        }

        private static void NewShiftSupervisor()
        {
            string employeeName;
            int employeeNumber = 0;
            decimal annual = 0;
            decimal bonus=0;

            Console.Write("Enter an employee name > ");
            employeeName = Console.ReadLine();

            Console.Write("Enter an employee number > ");
            while (!int.TryParse(Console.ReadLine(), out employeeNumber))
            {
                Console.Write("Enter a valid number > ");
            }
            Console.Write("Enter an annual salary > ");
            while (!decimal.TryParse(Console.ReadLine(), out annual))
            {
                Console.Write("Not a valid salary. Try again > ");
            }
            Console.Write("Enter an annual bonus > ");
            while (!decimal.TryParse(Console.ReadLine(), out bonus))
            {
                Console.Write("Not a valid bonus. Try again > ");
            }
            ShiftSupervisor supervisor = new ShiftSupervisor(annual, bonus, employeeName, employeeNumber);
            Console.WriteLine($"\nName: {supervisor.EmployeeName}\nEmployee number: {supervisor.EmployeeNumber}\nAnnual salary: {supervisor.AnnualSalary}\nAnnual bonus: {supervisor.AnnualBonus}");
        }

        private static void NewProductionWorker()
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
