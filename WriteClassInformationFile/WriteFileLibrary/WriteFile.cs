using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteFileLibrary
{
    public class WriteFile
    {
        public static void CreateFile(Person person)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("UserInformation");
                outputFile.WriteLine(person.FirstName);
                outputFile.WriteLine(person.LastName);
                outputFile.WriteLine(person.Age);
                outputFile.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error writing file UserInformation");
            }           
        }
    }
}
