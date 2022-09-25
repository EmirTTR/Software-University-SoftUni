using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Stack<char> symbools = new Stack<char>();
            foreach (var characters in word)
            {
                symbools.Push(characters);
            }
            while (symbools.Count>0)
            {
                Console.Write(symbools.Pop());
            }

        }
    }
}
