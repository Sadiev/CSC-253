using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

/**
* 05/01/2019
* CSC 153
* Dilshod Sadiev
* Employee Class
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");

            Employee emp2 = new Employee("Mark Jones", 39119);
            emp2.Department = "IT";
            emp2.Position = "Programmer";

            Employee emp3 = new Employee();
            emp3.Name = "Joy Rogers";
            emp3.IdNumber = 81774;
            emp3.Department = "Manufacturing";
            emp3.Position = "Engineer";

            Console.WriteLine($"{"Name",-15}{"ID Number",-15}{"Department",-15}{"Position"}");
            Console.WriteLine(("").PadRight(60, '-'));
            Console.WriteLine($"{emp1.Name,-15}{emp1.IdNumber, -15}{emp1.Department, -15}{emp1.Position}");
            Console.WriteLine($"{emp2.Name, -15}{emp2.IdNumber, -15}{emp2.Department,-15}{emp2.Position}");
            Console.WriteLine($"{emp3.Name, -15}{emp3.IdNumber, -15}{emp3.Department,-15}{emp3.Position}");
            Console.ReadLine();
        }
    }
}
