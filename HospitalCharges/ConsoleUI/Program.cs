/**
* 08/24/2019
* CSC 253
* Dilshod Sadiev
* Hospital Charges
*/
using System;

namespace ConsoleUI
{
    class Program
    {
        const decimal COST= 350;
        static void Main(string[] args)
        {
            Console.WriteLine($"\nTotal charges is ${CalcTotalCharges(CalcStayCharges(), CalcMiscCharges())}");
        }

        private static decimal CalcTotalCharges(decimal stayCharges, decimal miscCharges)
        {
            return stayCharges + miscCharges;
        }

        static decimal CalcStayCharges()
        {
            ushort days = 0;
            Console.Write("Enter the number of days spent in the hospital > ");
            while (!ushort.TryParse(Console.ReadLine(), out days))
            {
                Console.Write("Not a valid number. Please try again > ");
            }
            return days*COST;
        }

        static decimal CalcMiscCharges()
        {
            return InputAmount("Enter the amount of medication charges > ")+
                   InputAmount("Enter the amount of surgical charges > ")+
                   InputAmount("Enter the amount of lab fees > ")+
                   InputAmount("Enter the amount of physical rehabilitation charges > ");
        }
        static decimal InputAmount(string txt)
        {
            decimal amount = 0;
            Console.Write(txt);
            while (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.Write("Not a valid amount. Please try again > ");
            }
            return amount;
        }
    }
}
