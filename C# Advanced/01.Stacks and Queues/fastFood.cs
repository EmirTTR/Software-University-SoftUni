using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quontityOfFood = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] sequenceOfOrders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> foodQueue = new Queue<int>(sequenceOfOrders);
            Console.WriteLine(foodQueue.Max());

            while (foodQueue.Count > 0)
            {
                int order = foodQueue.Peek();
                sum += order;
                if (sum <= quontityOfFood)
                {
                    foodQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", foodQueue)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
