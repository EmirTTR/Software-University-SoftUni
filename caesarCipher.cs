using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            int positionChar = 3;
            StringBuilder complete = new StringBuilder();

                for (int j = 0; j < words.Length; j++)
                {
                    char chart = words[j];
                    int sumChart = chart;
                    int fulChar = sumChart + positionChar;
                    char megaChar = (char)fulChar;
                    complete.Append(megaChar);
                    
                }
            
            Console.WriteLine(string.Join("",complete));
        }
    }
}
