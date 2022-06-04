using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            List<int> reverse = new List<int>();

            while (input != "End")
            {
                var split = input.Split(" ");
                string command = split[0];

                if (command == "Add")
                {
                    int num = int.Parse(split[1]);
                    numbers.Add(num);
                }
                else if (command == "Insert")
                {
                    int num = int.Parse(split[1]);
                    int index = int.Parse(split[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, num);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(split[1]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "Shift")
                {
                    string second = split[1];
                    if (second == "left")
                    {
                        int count = int.Parse(split[2]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            while (i <= count)
                            {
                                if (i == 0)
                                {
                                    i = 1;
                                }

                                i++;
                                numbers.Add(numbers[0]);
                                numbers.Remove(numbers[0]);
                            }
                        }
                    }
                    else if (second == "right")
                    {
                        int count = int.Parse(split[2]);
                        int i = 1;
                        while (i<=count)
                        {
                            i++;
                            numbers.Insert(0,numbers[numbers.Count-1]);
                            numbers.RemoveAt(numbers.Count-1);
                        }
                    }
                }
                input = Console.ReadLine();
            }

          
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
