using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int numberOfElements = int.Parse(commands[0].ToString());
            int elementsToPop = int.Parse(commands[1].ToString());
            int elementToFind = int.Parse(commands[2].ToString());
            int minElement = int.MaxValue;
            int elementFromQueue = 0;

            Queue<int> elementsStack = new Queue<int>();
            int[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (elements.Length == numberOfElements)
            {
                foreach (var item in elements)
                {
                    elementsStack.Enqueue(item);
                }
                while (elementsToPop > 0)
                {
                    elementsToPop--;
                    elementsStack.Dequeue();
                }
                if (elementsStack.Contains(elementToFind))
                {
                    Console.WriteLine("true");
                }
                else if (!elementsStack.Contains(elementToFind))
                {
                    if (elementsStack.Count < 1)
                    {
                        Console.WriteLine("0");
                    }
                    else
                    {
                        for (int i = 0; i < elements.Length; i++)
                        {
                            elementFromQueue = int.Parse(elements[i].ToString());
                            if (elementFromQueue<minElement)
                            {
                               minElement=elementFromQueue;
                            }
                        }
                        Console.WriteLine(minElement);
                    }
                }
            }
        }
    }
}
