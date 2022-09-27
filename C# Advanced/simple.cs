using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            Stack<string> sequenceStack = new Stack<string>();
            int sum = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i+1]=="+")
                {
                    int first = int.Parse(sequence[i].ToString());
                    int second = int.Parse(sequence[i+2].ToString());
                    sum = first + second;
                    sequence.RemoveAt(0);
                    sequence.RemoveAt(0);
                    sequence.RemoveAt(0);
                    sequence.Insert(0, sum.ToString());
                    i--;
                    if (sequence.Count<2)
                    {
                        break;
                    }
                }
                else if (sequence[i+1]=="-")
                {
                    int first = int.Parse(sequence[i].ToString());
                    int second = int.Parse(sequence[i + 2].ToString());
                    sum = first - second;
                    sequence.RemoveAt(0);
                    sequence.RemoveAt(0);
                    sequence.RemoveAt(0);
                    sequence.Insert(0, sum.ToString());
                    i--;
                    if (sequence.Count<2)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
