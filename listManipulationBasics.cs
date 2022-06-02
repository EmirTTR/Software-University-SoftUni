using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add { number}: add a number to the end of the list.
            //    Remove { number}: remove a number from the list.
            //    RemoveAt { index}: remove a number at a given index.
            //    Insert { number}
            //{ index}: insert a number at a given index.

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input!="end")
            {
                var split = input.Split(" ");
                string command = split[0];

                if (command=="Add")
                {
                    int number = int.Parse(split[1]);
                    numbers.Add(number);
                }
                else if (command=="Remove")
                { 
                    int number = int.Parse(split[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i]==number)
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }
                }
                else if (command=="RemoveAt")
                {
                    int index = int.Parse(split[1]);
                    if (index <= numbers.Count)
                    {


                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (i == index)
                            {
                                numbers.RemoveAt(i);
                            }
                        }
                    }
                }
                else if (command=="Insert")
                {
                    int number = int.Parse(split[1]);
                    int index = int.Parse(split[2]);
                    if (index<=numbers.Count)
                    {
                        numbers.Insert(index,number);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
