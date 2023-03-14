using System;
using System.Collections.Generic;

name//space _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] splitNumbers = numbers.Split(" ");
            Dictionary<double, int> numbDict = new Dictionary<double, int>();

            foreach (var num in splitNumbers)
            {
                double number = double.Parse(num);
                if (!numbDict.ContainsKey(number))
                {
                    numbDict.Add(number, 0);
                }
                numbDict[number]++;
            }
            foreach (var item in numbDict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
            
        }
    }
}
