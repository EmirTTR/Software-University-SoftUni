using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsInQuory = int.Parse(Console.ReadLine());
            Stack<int> stackElements = new Stack<int>();

            for (int i = 0; i < elementsInQuory; i++)
            {
                string input = Console.ReadLine();
                string[] splitInput = input.Split(" ");
                string command = splitInput[0];
                if (command=="1")
                {
                    int numberToPush = int.Parse(splitInput[1].ToString());
                    stackElements.Push(numberToPush);
                }
                else if (command=="2")
                {
                    if (stackElements.Count>0)
                    {
                        stackElements.Pop();
                    }
                }
                else if (command=="3")
                {
                    foreach (var item in stackElements.OrderByDescending(x=>x))
                    {
                        Console.WriteLine(item);
                        break;
                    }
                }
                else if (command=="4")
                {
                    foreach (var item in stackElements.OrderBy(x => x))
                    {
                        Console.WriteLine(item);
                        break;
                    }
                }
            }
            if (stackElements.Count>0)
            {
                Console.WriteLine(string.Join(", ",stackElements));
            }
        }
    }
}
