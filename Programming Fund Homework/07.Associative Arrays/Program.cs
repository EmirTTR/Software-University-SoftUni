using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyDict = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(" -> ");

            while (input[0]!="End")
            {
                string companyName = input[0];
                string employeeID = input[1];

                if (!companyDict.ContainsKey(companyName))
                {
                    companyDict.Add(companyName, new List<string>());
                    companyDict[companyName].Add(employeeID);
                }
                else
                {
                    if (!companyDict[companyName].Contains(employeeID))
                    {
                        companyDict[companyName].Add(employeeID);
                    }
                }
                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var compamy in companyDict)
             {
                Console.WriteLine(compamy.Key);
                  foreach (var employee in compamy.Value)
                  {
                     Console.Write($"-- {string.Join("\n-- ",compamy.Value)}");
                     Console.WriteLine();
                     break;
                  }
             }
           
           
        }
    }
}
