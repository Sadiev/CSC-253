using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 11/12/2019
* CSC 253
* Dilshod Sadiev
* Tuition Increase
*/
namespace TuitionIncreaseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tuition = 6000m;
            const byte INCREASE = 2;
            int year = 2020;

            do
            {
                tuition = Tuition.Increase(tuition, INCREASE);
                Console.WriteLine("The tuition for {0} is {1:C}", year, tuition);
                year++;
            } while (year <= 2024);

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
    public class Tuition
    {
        public static decimal Increase(decimal tuition, byte inc)
        {
            return tuition + (tuition * inc / 100);
        }
    }
}
