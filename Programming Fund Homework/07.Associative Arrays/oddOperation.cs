using System;
using System.Collections.Generic;
using System.Linq;
/////////////////////
namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Dictionary<string, int> wordDict = new Dictionary<string, int>();

            foreach (var item in words)
            {
                string lowerWords = item.ToLower();

                if (wordDict.ContainsKey(lowerWords))
                {
                    wordDict[lowerWords]++;
                }
                else
                {
                    wordDict.Add(lowerWords, 1);
                }
            }
            foreach (var word in wordDict)
            {
                if (word.Value%2!=0)
                {
                    Console.Write(word.Key + " " );
                }
            }
        }
    }
}
