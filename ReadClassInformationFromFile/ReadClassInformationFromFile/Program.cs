using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 09/21/2019
* CSC 253
* Dilshod Sadiev
* Read Class Information From File
*/

namespace ReadClassInformationFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in ReadFile.LoadFile())
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Age);
                Console.WriteLine();
            }
            Console.Write("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
