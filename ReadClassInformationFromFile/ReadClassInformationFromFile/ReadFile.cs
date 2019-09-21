using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadClassInformationFromFile
{
    class ReadFile
    {
        public static List<Person> LoadFile()
        {
            List<Person> persons = new List<Person>();
            try
            {
                using (StreamReader readFile = File.OpenText("UserInformation"))
                {
                    string s = "";
                    while ((s = readFile.ReadLine()) != null)
                    {
                        persons.Add(new Person { FirstName = s, LastName = readFile.ReadLine(), Age = int.Parse(readFile.ReadLine()) });
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error reading file UserInformation");
            }
            return persons;
            
        }
    }
}
