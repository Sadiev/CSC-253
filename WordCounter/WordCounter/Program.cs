using System;
/**
* 09/01/2019
* CSC 253
* Dilshod Sadiev
* Word Counter
*/
namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence > ");
            int words = CoutWord(Console.ReadLine());
            Console.WriteLine($"The sentence has {words} { ((words == 1) ? "word" : "words")}.");
            Console.Write("\nPress any key to exit ...");
            Console.ReadLine();
        }
        static int CoutWord(string txt)
        {
            int i = 0;
            int words=txt=="".Trim() ? 0:1;

            while (txt.Trim().Length>i)
            {
                if (txt[i] == ' ' || txt[i]=='\t' || txt[i] == '\n') words++;
                i++;
            }
            return words;
        }
    }
}
