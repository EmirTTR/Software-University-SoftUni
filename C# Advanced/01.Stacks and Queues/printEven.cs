using System;
using System.Collections.Generic;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineOfNumbers = Console.ReadLine().Split(" ");
            Queue<int> numbersQueue = new Queue<int>();

            for (int i = 0; i < lineOfNumbers.Length; i++)
            {

                int number = int.Parse(lineOfNumbers[i].ToString());
                if (number%2==0)
                {
                    numbersQueue.Enqueue(number);
                }
            }
            foreach (var item in numbersQueue)
            {
                Console.WriteLine(string.Join(", ",numbersQueue));
                break;
            }
        }
    }
}
