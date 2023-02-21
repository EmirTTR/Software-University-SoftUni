using System;
using System.Collections.Generic;
using System.Linq;
////
namespace _05._Cities_by_continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> registerDict = new Dictionary<string, Dictionary<string, List<string>>>();
            int numInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < numInput; i++)
            {
                string input = Console.ReadLine();
                string[] splitInput = input.Split(" ");
                string continent = splitInput[0];
                string country = splitInput[1];
                string city = splitInput[2];

                if (!registerDict.ContainsKey(continent))
                {
                    registerDict.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!registerDict[continent].ContainsKey(country))
                {
                    registerDict[continent].Add(country, new List<string>());
                }
                registerDict[continent][country].Add(city);
            }

            foreach (var item in registerDict)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var countries in item.Value)
                {
                    Console.WriteLine($"  {countries.Key} -> {string.Join(", ",countries.Value)}");
                }
            }

        }
       
    }
}
