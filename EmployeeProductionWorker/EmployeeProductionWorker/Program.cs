using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

/**
* 10/23/2019
* CSC 253
* Dilshod Sadiev
* Employee and ProductionWorker Classes
*/

namespace EmployeeProductionWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeName;
            int employeeNumber=0;
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
            
            Console.WriteLine("\nPress any key to exit ...");
            Console.ReadLine();

        }
    }
}
