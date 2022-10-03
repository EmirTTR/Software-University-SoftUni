using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int numForElimination = int.Parse(Console.ReadLine());
            Queue<string> pleyarsQueue = new Queue<string>();
            foreach (var kid in players)
            {
                pleyarsQueue.Enqueue(kid);
            }
            while (pleyarsQueue.Count > 1)
            {
                for (int i = 0; i < numForElimination - 1; i++)
                {

                    string nextKid = pleyarsQueue.Dequeue();
                    pleyarsQueue.Enqueue(nextKid);
                }
                Console.WriteLine($"Removed {pleyarsQueue.Dequeue()}");

            }
            Console.WriteLine($"Last is {string.Join("",pleyarsQueue)}");
        }
    }
}
