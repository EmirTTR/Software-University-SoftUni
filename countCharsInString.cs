using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<char, int> charDict = new Dictionary<char, int>();

            for (int i = 0; i < words.Count; i++)
            {
                string word = string.Empty;
                word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    char chart = word[j];
                    if (!charDict.ContainsKey(chart))
                    {
                        charDict.Add(chart,0);
                    }
                    charDict[chart]++;

                }
            }
            foreach (var chaR in charDict)
            {
                Console.WriteLine($"{chaR.Key} -> {chaR.Value}");
            }

        }
    }
}
