using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> numDict = new SortedDictionary<double, int>();

            foreach (var item in nums)
            {
                if (numDict.ContainsKey(item))
                {
                    numDict[item]++;
                }
                else
                {
                    numDict.Add(item, 1);
                }
            }
            foreach (var item in numDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        
        }
    }
}
