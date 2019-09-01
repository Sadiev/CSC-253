using System;
using System.Collections.Generic;
using System.Linq;
/**
* 01/09/2019
* CSC 253
* Dilshod Sadiev
* Most Frequent Character
*/
namespace MostFrequentCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program determine the most frequent character in a text.");
            Console.WriteLine("Input a text or press ENTER to exit > ");
            
            Console.WriteLine($"The most frequent character in the text is '{CoutChar(Console.ReadLine())}'.");
        }

        static char CoutChar(string txt)
        {
            if (txt == "") Environment.Exit(0);
            List<char> chars = new List<char>();
            int max = 0;
            char result = ' ';
            foreach (var c in txt)
            {
                if (chars.Exists(x => x == c)) continue;
                chars.Add(c);
                int tmp = txt.Count(f => f == c);
                if (max < tmp)
                {
                    max = tmp;
                    result = c;
                }
                    
            }

            return result;
        }
    }
}
