using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> inputIndex = new Stack<int>();
            string ready = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    int open = i;
                    inputIndex.Push(open);
                    
                }
                if (input[i]==')')
                {
                    int open = inputIndex.Pop();
                    int close = i;
                    ready = input.Substring(open,close - open + 1);
                    Console.WriteLine(ready);
                }

            }
        }
    }
}
