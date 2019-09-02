using System;
/**
* 09/01/2019
* CSC 253
* Dilshod Sadiev
* Word Separator
*/
namespace WordSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a sentence or press ENTER to exit > ");
            Console.WriteLine(WordSeparator(Console.ReadLine()));
            Console.Write("\nPress any key to exit ...");
            Console.ReadKey();
        }

        private static string WordSeparator(string sentence)
        {
            Console.WriteLine("******************************************************");
            string result = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (i == 0 || sentence[i] == ' ')
                {
                    result += char.ToUpper(sentence[i]);
                    continue;
                }
                else if (char.IsUpper(sentence[i]))
                {
                    result += " " + char.ToLower(sentence[i]);
                }
                else
                    result += sentence[i];
            }
            return result;
        }
    }
}
