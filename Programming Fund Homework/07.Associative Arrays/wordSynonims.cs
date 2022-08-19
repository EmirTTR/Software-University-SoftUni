using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonymDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < num; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();

                if (!synonymDict.ContainsKey(word))
                {
                    synonymDict.Add(word, new List<string>());
                }
               
                synonymDict[word].Add(synonyms);
            }
            foreach (var item in synonymDict)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
