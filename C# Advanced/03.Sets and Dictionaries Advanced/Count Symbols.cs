using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> symblosList = new List<char>();
            int countSymbol = 1;

            for (int i = 0; i < input.Length; i++)
            {
                symblosList.Add(input[i]);
            }
            symblosList.Sort();

            for (int i = 0; i < symblosList.Count; i++)
            {
                char symbol = symblosList[i];
                if (i < symblosList.Count - 1)
                {
                    if (symbol == symblosList[i + 1])
                    {
                        countSymbol++;
                        continue;
                    }
                    Console.WriteLine($"{symbol}: {countSymbol} time/s");
                     
                    if (symbol!=symblosList[i+1])
                    {
                        countSymbol = 1;

                    }
                }
                else
                {
                    Console.WriteLine($"{symbol}: {countSymbol} time/s");
                }
            }
        }
    }
}
