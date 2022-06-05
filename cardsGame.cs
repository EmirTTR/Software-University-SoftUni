using System;
using System.Collections.Generic;
using System.Linq;

namespace _006.Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int sum = 0;

            while (deck1.Count!=0 || deck2.Count!=0)
            {
                if (deck1.Count==0 && deck2.Count==0)
                {
                    return;
                }
                if (deck1.Count==0)
                {
                    sum = deck2.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    return;
                }
                else if (deck2.Count==0)
                {
                    sum = deck1.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    return;
                }
              
                if (deck1[0] > deck2[0])
                {
                    deck1.Add(deck1[0]);
                    deck1.Add(deck2[0]);
                    deck1.Remove(deck1[0]);
                    deck2.Remove(deck2[0]);
                }
                else if (deck2[0] > deck1[0])
                {
                    deck2.Add(deck2[0]);
                    deck2.Add(deck1[0]);
                    deck1.Remove(deck1[0]);
                    deck2.Remove(deck2[0]);
                }
                else if (deck1[0] == deck2[0])
                {
                    deck1.Remove(deck1[0]);
                    deck2.Remove(deck2[0]);
                }
            }
        }
    }
}
