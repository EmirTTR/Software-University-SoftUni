using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTimes = int.Parse(Console.ReadLine());
            HashSet<string> uniqueElemenst = new HashSet<string>();

            for (int i = 0; i < nTimes; i++)
            {
                string[] elements = Console.ReadLine().Split(" ");
                for (int j = 0; j < elements.Length; j++)
                {
                    uniqueElemenst.Add(elements[j]);
                }
            }
            foreach (var item in uniqueElemenst.OrderBy(x=>x))
            {
                Console.Write(item + " ");
            }
        }
    }
}
