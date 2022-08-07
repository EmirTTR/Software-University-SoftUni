using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int sum = 0;
            int count = 0;
            int countBomb = 0;


            int p = 1;
            int bomB = bomb[0];
            int indexOfBomb =numbers.IndexOf(bomB);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]==bomb[0])
                {
                    count++;
                }
            }

            while (p <= bomb[1])
            {
                p++;
                if (countBomb==bomb[0])
                {
                    break;
                }
                numbers.RemoveAt(indexOfBomb - 1);
                numbers.RemoveAt(indexOfBomb + 1);
                if (countBomb==bomb[0])
                {
                    if (p!=bomb[1])
                    {
                        break;
                    }
                }
                indexOfBomb =numbers[bomb[0]];
                countBomb++;
                p--;

            }

            if (countBomb <= bomb[0])
            {
                if (p != bomb[1])
                {
                }

                int f = 1;
                while (f <= count)
                {
                    f++;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == bomb[0])
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }
                }
            }

            sum = numbers.Sum();
            Console.WriteLine(sum);
        }
        
    }
}
