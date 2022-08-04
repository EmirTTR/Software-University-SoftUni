using System;
using System.Collections.Generic;
using System.Linq;


namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            List<int> oldList = new List<int>();
            bool isCommand = true;
            while (input != "end")
            {
                var split = input.Split(" ");
                string command = split[0];
               
                if (command == "Contains" || command == "PrintEven" || command == "PrintOdd" || command == "GetSum" || command == "Filter")
                {

                    if (command == "Contains")
                    {
                        int number = int.Parse(split[1]);

                        if (numbers.Contains(number))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        isCommand = true;
                    }
                    else if (command == "PrintEven")
                    {
                        List<int> evenNumbers = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evenNumbers.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(string.Join(" ", evenNumbers));
                        isCommand = true;
                    }
                    else if (command == "PrintOdd")
                    {
                        List<int> oddNumbers = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                oddNumbers.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(string.Join(" ", oddNumbers));
                        isCommand = true;
                    }
                    else if (command == "GetSum")
                    {
                        int sumNumbers = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sumNumbers += numbers[i];

                        }

                        Console.WriteLine(sumNumbers);
                        isCommand = true;
                    }
                    else if (command == "Filter")
                    {

                        string condition = split[1];
                        int number = int.Parse(split[2]);
                        List<int> little = new List<int>();
                        List<int> big = new List<int>();
                        List<int> littleOrEven = new List<int>();
                        List<int> bigOrEven = new List<int>();

                        if (condition == "<")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < number)
                                {
                                    little.Add(numbers[i]);
                                }
                            }

                            Console.WriteLine(string.Join(" ", little));
                        }
                        else if (condition == ">")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > number)
                                {
                                    big.Add(numbers[i]);
                                }
                            }

                            Console.WriteLine(string.Join(" ", big));
                        }
                        else if (condition == "<=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= number)
                                {
                                    littleOrEven.Add(numbers[i]);
                                }
                            }

                            Console.WriteLine(string.Join(" ", littleOrEven));
                        }
                        else if (condition == ">=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= number)
                                {
                                    bigOrEven.Add(numbers[i]);
                                }
                            }

                            Console.WriteLine(string.Join(" ", bigOrEven));
                        }
                        else
                        {
                            break;
                        }

                        isCommand = true;
                    }

                    input = Console.ReadLine();
                }
                else
                {
                    return;
                }
            }

        }
    }
}
