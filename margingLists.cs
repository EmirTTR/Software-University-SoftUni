using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> num2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < num1.Count; i++)
            {
                for (int j = 0; j < num2.Count; j++)
                {
                    while (i<num1.Count || j<num2.Count )
                    {
                        if (num1.Count <= j)
                        {
                            result.Add(num2[j]);
                            j++;
                            continue;
                        }
                        if (num2.Count <= i)
                        {
                            result.Add(num1[i]);
                            i++;
                            continue;
                        }
                        result.Add(num1[i]);
                        result.Add(num2[j]);
                        i++;
                        j++;

                    }
                    Console.WriteLine(string.Join(" ",result));
                    return;
                }

            
            }

        }
    }
}
