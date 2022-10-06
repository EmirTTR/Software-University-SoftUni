using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequenceOfClothes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothesStack = new Stack<int>(sequenceOfClothes);

            if (sequenceOfClothes.Length>50)
            {
                return;
            }
            foreach (var item in sequenceOfClothes.Where(x=>x<0 || x>20))
            {
                return;
            }
            if (rackCapacity<0 || rackCapacity>20)
            {
                return;
            }
            foreach (var item in sequenceOfClothes.Where(x=>x>rackCapacity))
            {
                return;
            }
            int numRacks = 1;
            int sum = 0;

            while (clothesStack.Count > 0)
            {
                int clothPrice = clothesStack.Peek();
                sum += clothPrice;
                if (sum <= rackCapacity)
                {

                    clothesStack.Pop();
                }
                else
                {
                    numRacks++;
                    sum = 0;
                }
            }
            
            Console.WriteLine(numRacks);
        }
    }
}
