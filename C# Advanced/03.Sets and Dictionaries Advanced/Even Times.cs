using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTimes = int.Parse(Console.ReadLine());
            List<int> uniqueNumbers = new List<int>();

            for (int i = 0; i < nTimes; i++)
            {
                int number = int.Parse(Console.ReadLine());
                uniqueNumbers.Add(number);
            }

            for (int i = 0; i < uniqueNumbers.Count; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(uniqueNumbers[i]);
                    return;
                }
            }
        }
    }
}
