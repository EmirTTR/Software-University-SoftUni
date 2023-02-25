using System;
using System.Collections.Generic;
using System.Linq;
///
namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTimes = int.Parse(Console.ReadLine());
            HashSet<string> nameSet = new HashSet<string>();
            Queue<string> nameQueue = new Queue<string>();


            for (int i = 0; i < nTimes; i++)
            {
                string name = Console.ReadLine();
                nameSet.Add(name);

            }

            foreach (var item in nameSet)
            {
                nameQueue.Enqueue(item);
            }
            foreach (var item in nameQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
