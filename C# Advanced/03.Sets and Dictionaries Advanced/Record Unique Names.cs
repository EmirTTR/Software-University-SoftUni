using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();
            int numNames = int.Parse(Console.ReadLine());

            for (int i = 0; i < numNames; i++)
            {
                string name = Console.ReadLine();
                uniqueNames.Add(name);
            }
            foreach (var item in uniqueNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
