using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> numList = new List<int>();
            int count = 3;
            foreach (var item in numbers)
            {
                numList.Add(item);
            }
            numList.Sort();
            numList.Reverse();

            for (int i = 0; i < numList.Count; i++)
            {
                if (i<count)
                {
                    Console.Write(numList[i] + " ");
                }
            }

          
        }
    }
}
