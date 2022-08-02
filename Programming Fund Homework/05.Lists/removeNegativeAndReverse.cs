using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> negatives = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    negatives.Add(numbers[i]);
                    negatives.Remove(numbers[i]);
                    numbers.Remove(numbers[i]);
                    i -= 1;
                    continue;
                }
            }

            numbers.Reverse();
            if (negatives.Count == numbers.Count)
            {
                Console.WriteLine("empty");
                return;
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(string.Join(" ",numbers));
                return;
            }
        }
    }
}
