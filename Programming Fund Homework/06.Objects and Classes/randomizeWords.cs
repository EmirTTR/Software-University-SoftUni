using System;
using System.Linq;
/////////////////
namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();
/////////
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int swap = rnd.Next(words.Length);
                string temp = words[i];
                words[i] = words[swap];
                words[swap] = temp;
            }
            Console.WriteLine(string.Join("\n",words));
        }
    }
}
