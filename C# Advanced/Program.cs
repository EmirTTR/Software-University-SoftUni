using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> numbersStack = new Stack<int>();
            foreach (var number in numbers)
            {
                numbersStack.Push(number);
            }

            while (true)
            {
                string input = Console.ReadLine();
                string[] splitInput = input.Split(" ");
                string command = splitInput[0].ToLower();
                if (command=="end")
                {
                    break;
                }
                else if (command=="add")
                {
                    int firstNum = int.Parse(splitInput[1]);
                    int secondNum = int.Parse(splitInput[2]);
                    numbersStack.Push(firstNum);
                    numbersStack.Push(secondNum);
                }
                else if (command=="remove")
                {
                    int numbersToRemove = int.Parse(splitInput[1]);
                    if (numbersToRemove<numbersStack.Count)
                    {
                        for (int i = 0; i < numbersToRemove; i++)
                        {
                            numbersStack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {numbersStack.Sum()}");
        }
    }
}
