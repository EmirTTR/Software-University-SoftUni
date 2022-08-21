using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"motes", 0 },
                {"fragments", 0 },
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();

            while (materials["motes"] < 250 && materials["fragments"] < 250 && materials["shards"] < 250)
            {
                string[] input = Console.ReadLine().Split(" ");

                //3 Motes 5 stones 5 Shards 6 leathers 255 fragments 7 Shards


                for (int i = 0; i < input.Length; i+=2)
                {
                    int elementValue = int.Parse(input[i]);
                    string element = input[i+1].ToLower();

                    if (element == "motes")
                    {
                        materials["motes"] += elementValue;
                        if (materials["motes"]>=250)
                        {
                            break;
                        }
                    }
                    else  if (element=="shards")
                    {
                        materials["shards"]+=elementValue;
                        if (materials["shards"] >= 250)
                        {
                            break;
                        }
                    }
                    else if (element == "fragments")
                    {
                        materials["fragments"] += elementValue;
                        if (materials["fragments"] >= 250)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(element))
                        {
                            junk.Add(element, 0);
                        }
                        junk[element] += elementValue;
                        continue;
                    }
                }
                if (materials["shards"] >= 250 || materials["fragments"] >= 250 || materials["motes"] >= 250)
                {
                    break;
                }
            }
                if (materials["shards"]>=250)
                {
                    Console.WriteLine("Shadowmourne obtained!");
                    materials["shards"] -= 250;
                }
                else if (materials["fragments"] >= 250)
                {
                    Console.WriteLine("Valanyr obtained!");
                    materials["fragments"] -= 250;
                }
                else if (materials["motes"] >= 250)
                {
                    Console.WriteLine("Dragonwrath obtained!");
                    materials["motes"] -= 250;
                }

            foreach (var material in materials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var trash in junk)
            {
                Console.WriteLine($"{trash.Key}: {trash.Value}");
            }
        }
    }
}
