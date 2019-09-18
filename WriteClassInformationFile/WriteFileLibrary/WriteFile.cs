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
        public static void CreateFile()
        {
            try
            {
                StreamWriter outputFile;
                outputFile.WriteLine();
                outputFile.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        

    }
}
