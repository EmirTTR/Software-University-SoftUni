using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTimes = int.Parse(Console.ReadLine());
            if (nTimes<0)
            {
                return;
            }
            Dictionary<string, Dictionary<string, int>> clothesDict = new Dictionary<string, Dictionary<string, int>>();
            string word = string.Empty;

            for (int i = 0; i < nTimes; i++)
            {
                string[] needed = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string color = needed[0];
                string cloth = needed[2];
                string[] splitCloth = cloth.Split(",");
                if (!clothesDict.ContainsKey(color))
                {
                    clothesDict.Add(color, new Dictionary<string, int>());

                }
                if (!clothesDict.ContainsKey(cloth))
                {
                    clothesDict[color].Add(cloth, 0);
                }
                for (int j = 0; j < splitCloth.Length; j++)
                {
                    if (!clothesDict[color].ContainsKey(splitCloth[j]))
                    {
                        clothesDict[color][splitCloth[j]] = 1;
                    }
                    else
                    {
                        clothesDict[color][splitCloth[j]] += 1;
                    }
                }
            }
            string[] secondInput = Console.ReadLine().Split(" ");
            string needColor = secondInput[0];
            string needCloth = secondInput[1];

            foreach (var item in clothesDict)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    string apendCloth = cloth.ToString();
                    for (int i = 0; i < apendCloth.Length; i++)
                    {
                        char symbol = apendCloth[i];
                        if (symbol=='[' || symbol==']')
                        {
                            continue;
                        }
                        else
                        {
                            word += apendCloth[i];
                        }
                    }
                    string[] splitCloth = word.Split(", ");
                    string first = splitCloth[0];
                    int second = int.Parse(splitCloth[1]);

                    if (first == needCloth && item.Key == needColor)
                    {
                        Console.WriteLine($"* {first} - {second} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {first} - {second}");
                    }
                    word = string.Empty;
                }
            }
        }
    }  
}