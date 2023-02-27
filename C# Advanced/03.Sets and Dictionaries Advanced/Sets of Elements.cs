using System;
using System.Collections.Generic;
using System.Linq;
//
namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sSet = cordinates[0];
            int mSet = cordinates[1];
            List<int> numbersList = new List<int>();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < sSet; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < mSet; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }
            foreach (var item in firstSet)
            {
                numbersList.Add(item);
            }
        

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (secondSet.Contains(numbersList[i]))
                {
                    Console.Write(numbersList[i] + " ");
                }
            }
        }
    }
}
