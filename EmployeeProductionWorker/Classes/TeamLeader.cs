using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class TeamLeader: ProductionWorker
    {
        public decimal MonthlyBonus { get; set; }
        public int TrainingHours { get; set; }
        public int TrainingAttended { get; set; }
        public TeamLeader(decimal monthlyBonus, int trainingHours, int trainingAttended, int shift, decimal hourlyPayRate, string employeeName, int employeeNumber)
            :base(shift, hourlyPayRate, employeeName, employeeNumber)
        {
            MonthlyBonus = monthlyBonus;
            TrainingHours = trainingHours;
            TrainingAttended = trainingAttended;
        }
        public static void NewTeamLeader()
        {
            string employeeName;
            int shift;
            decimal hourlyPayRate;
            decimal monthlyBonus;
            int trainingHours;
            int trainingAttended;
            int employeeNumber;

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
                Console.Write("Not a valid salary. Try again > ");
            }
            

            Console.Write("Enter an hourly pay rate > ");
            while (!decimal.TryParse(Console.ReadLine(), out hourlyPayRate))
            {
                Console.Write("Not a valid hourly pay rate. Try again > ");
            }

            Console.Write("Enter a monthly bonus > ");
            while (!decimal.TryParse(Console.ReadLine(), out monthlyBonus))
            {
                Console.Write("Not a valid monthly bonus. Try again > ");
            }

            Console.Write("Enter the required number of training hours > ");
            while (!int.TryParse(Console.ReadLine(), out trainingHours))
            {
                Console.Write("Not a valid number. Try again > ");
            }

            Console.Write("Enter the number of training hours that the team leader has attended > ");
            while (!int.TryParse(Console.ReadLine(), out trainingAttended))
            {
                Console.Write("Not a valid number. Try again > ");
            }
            TeamLeader teamLeader = new TeamLeader(monthlyBonus, trainingHours, trainingAttended, shift, hourlyPayRate, employeeName, employeeNumber);

            Console.WriteLine($"\nEmployee name: {teamLeader.EmployeeName}\nEmployee number: {teamLeader.EmployeeNumber}\n" +
                              $"Shift: {teamLeader.Shift}\nHourly pay rate: ${teamLeader.HourlyPayRate}"+
                              $"\nMonthly bonus: {teamLeader.MonthlyBonus}\nRequired number of training hours: {teamLeader.TrainingHours}"+
                              $"\nNumber of training hours that the team leader has attended: {teamLeader.TrainingAttended}");
        }
    }
}
