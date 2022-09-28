using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> namesQueue = new Queue<string>();

            while (true)
            {
               if (name=="End")
               {
                    break;
               }
               else if (name=="Paid")
               {
                    Console.Write(string.Join("\n",namesQueue));
                    Console.WriteLine();
                    namesQueue.Clear();
               }
               else
               {
                    namesQueue.Enqueue(name);
               }
                name = Console.ReadLine();
            }
            Console.WriteLine($"{namesQueue.Count} people remaining.");
        }
    }
}
