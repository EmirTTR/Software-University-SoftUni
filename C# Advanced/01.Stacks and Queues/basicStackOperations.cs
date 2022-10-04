using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int numberOfElements = int.Parse(commands[0].ToString());
            int elementsToPop = int.Parse(commands[1].ToString());
            int elementToFind = int.Parse(commands[2].ToString());

            Stack<int> elementsStack = new Stack<int>();
            int[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (elements.Length==numberOfElements)
            {
                foreach (var item in elements)
                {
                    elementsStack.Push(item);
                }
                while (elementsToPop>0)
                {
                    elementsToPop--;
                    elementsStack.Pop();
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
                        foreach (var item in elementsStack.OrderByDescending(x => x > 0))
                        {
                            Console.WriteLine(item);
                            break;
                        }
                    }
                }
            }
        }
    }
}
