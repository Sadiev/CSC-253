using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal wholesaleCost = 0;
            byte percentage = 0;
            Console.Write("Enter an item’s wholesale cost > ");
            while (!decimal.TryParse(Console.ReadLine(),out wholesaleCost))
            {
                Console.Write("Not a valid price, please try again > ");
            }
            Console.Write("\nEnter markup percentage > ");
            while (!byte.TryParse(Console.ReadLine(), out percentage))
            {
                Console.Write("Not a valid percentage, please try again > ");
            }
            Console.WriteLine($"\nThe item’s wholesale cost is ${wholesaleCost} and its markup percentage is {percentage} percent\n" +
                              $"The item’s retail price is ${Calculate.CalculateRetail(wholesaleCost, percentage)}");
            Console.WriteLine("\nPress any key to exit ...");
            Console.ReadKey();
        }
        
    }
    public class Calculate
    {
        static public decimal CalculateRetail(decimal wholesaleCost, byte percentage)
        {
            return (wholesaleCost * percentage / 100) + wholesaleCost;
        }
    }
}
