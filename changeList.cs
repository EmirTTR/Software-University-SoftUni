using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {

             List<int> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

             string input = Console.ReadLine();

             while (input!="end")
             {
                 var split = input.Split(" ");
                 string command = split[0];

                 if (command=="Delete")
                 {
                     int number = int.Parse(split[1]);

                     for (int i = 0; i < numbers.Count; i++)
                     {
                         if (numbers[i]==number)
                         {
                             numbers.Remove(numbers[i]);
                             i--;
                         }
                     }
                 }
                 else if (command=="Insert")
                 {
                     int number = int.Parse(split[1]);
                     int index = int.Parse(split[2]);
                     
                     numbers.Insert(index,number);
                     
                 }
                 input = Console.ReadLine();
             }

             Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
