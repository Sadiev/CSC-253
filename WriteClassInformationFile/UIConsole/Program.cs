using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteFileLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Person person = new Person();
            int age = 0;
            Console.Write("Enter first name > ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter last name > ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Age > ");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Not a valid Age. Try again.");
            }
            person.Age = age;
            WriteFile.CreateFile(person);

            Console.Write("Input 'add' to add a new person or 'Enter' to exit > ");
            if (Console.ReadLine().ToLower() == "add")
                Run();
        }
    }
}
