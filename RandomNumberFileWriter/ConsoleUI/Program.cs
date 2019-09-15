using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 09/14/2019
* CSC 253
* Dilshod Sadiev
* Random Number File Writer
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers;
            string txt="";
            string filePath = $"{Directory.GetCurrentDirectory()}\\mynewfile.txt";
            Random rand = new Random();

            Console.Write("How many random numbers save in a new file? ");
            while (!int.TryParse(Console.ReadLine(),out numbers))
            {
                Console.WriteLine("Not a valid number!");
            }

            for (int i = 0; i < numbers; i++)
            {
                txt += rand.Next(1,100) + (i!=numbers-1?",":"");
            }
            
            File.WriteAllText(filePath, txt);
            Console.WriteLine($"\n{numbers } - numbers have been saved in the file\n'{filePath}'");
            Console.WriteLine("\nPress any key to exit ...");
            Console.ReadKey();
        }
    }
}
