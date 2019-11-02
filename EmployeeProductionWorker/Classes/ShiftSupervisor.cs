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
        public static void NewShiftSupervisor()
        {
            string employeeName;
            int employeeNumber = 0;
            decimal annual = 0;
            decimal bonus = 0;

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
    }
}
