using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
///////
namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            StringBuilder onlyLetter = new StringBuilder();
            string word = Console.ReadLine();
            
            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[i]!=word[i+1])
                {
                    onlyLetter.Append(word[i]);
                }
            }
            onlyLetter.Append(word[word.Length - 1]);
            Console.WriteLine(onlyLetter);
            
        }
    }
}
