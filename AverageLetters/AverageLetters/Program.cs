using System;
/**
* 09/01/2019
* CSC 253
* Dilshod Sadiev
* Average Number of Letters
*/
namespace AverageLetters
{
    class Program
    {
        static int letters;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence > ");
            int words = CoutWord(Console.ReadLine());
            Console.WriteLine($"\nThe sentence has {words} { ((words == 1) ? "word" : "words")}.");
            Console.WriteLine($"And average number of letters in each word is {((letters != 0) ? (letters /words):0)}.");
            Console.Write("\nPress any key to exit ...");
            Console.ReadLine();
        }

        static int CoutWord(string txt)
        {
            int i = 0;
            int words = txt == "".Trim() ? 0 : 1;

            while (txt.Trim().Length > i)
            {
                if (txt[i] == ' ' || txt[i] == '\t' || txt[i] == '\n')
                {
                    words++;
                }
                else
                {
                    letters++;
                }
                i++;
            }
            return words;
        }
    }
}
