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
            //string filePath = $"{Directory.GetCurrentDirectory()}\\mynewfile.txt";
            try
            {
                //if (!File.Exists(filePath))
                StreamReader inputFile;
                inputFile = File.OpenText("mynewfile.txt");
                //string txt = File.ReadAllText(filePath);
                string[] nums = inputFile.ReadLine().Split(',');
                inputFile.Close();
                foreach (var item in nums)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Total: {nums.Length}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
                       
            Console.ReadLine();
        }
    }
}
