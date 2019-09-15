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
* Random Number File Reader
*/
namespace RandomNumberFileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To read file with numbers copy it in the Application's directory and press 'Enter'.");
            Console.ReadLine();
            string filePath = $"{Directory.GetCurrentDirectory()}\\mynewfile.txt";
            try
            {
                //if (!File.Exists(filePath))
                string txt = File.ReadAllText(filePath);
                string[] nums = txt.Split(',');
                foreach (var item in nums)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Total: {nums.Length}");
            }
            catch (Exception)
            {

                Console.WriteLine($"Error the file can't be read.\nThe file has to located at the \n'{filePath}'\n\nCheck the path and run the program again.");
            }
                       
            Console.ReadLine();
        }
    }
}
