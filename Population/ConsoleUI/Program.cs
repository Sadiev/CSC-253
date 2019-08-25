/**
* 08/24/2019
* CSC 253
* Dilshod Sadiev
* Population
*/
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***This predicts the approximate size of a population of organisms.***\n");

            uint start = input("Please enter starting number of organisms > ");
            uint percent = input("Please enter an average of percentage daily increase > ");
            uint days = input("Please enter a number of days to multiply > ");
            double calc = start;
            Console.WriteLine("\nDay          Approximate Population");
            for (var i = 1; i <= days; i++)
            {
                Console.Write($"{i}".PadRight(13,' '));
                Console.WriteLine($"{calc}");
                calc += (calc * percent) / 100;
            }
            Console.WriteLine("\nPress any key to exit ...");
            Console.ReadKey();
        }

        static uint input(string msg)
        {
            uint input = 0;
            Console.Write(msg);
            while (!uint.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("Not a valid number. Please input a positive number > ");
            }
            return input;
        }
    }
}
