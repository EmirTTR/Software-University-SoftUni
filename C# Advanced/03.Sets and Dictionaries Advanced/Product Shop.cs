using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,double>> shopDict = new Dictionary<string, Dictionary<string,double>>();

            while (true)
            {
                string input = Console.ReadLine();
                string[] inputParts = input.Split(", ");
                string shop = inputParts[0];
                if (shop == "Revision")
                {
                    break;
                }
                string product = inputParts[1];
                double price = double.Parse(inputParts[2]);
                
                if (!shopDict.ContainsKey(shop))
                {
                    
                    shopDict.Add(shop, new Dictionary<string, double>());
                }
                if (!shopDict[shop].ContainsKey(product))
                {

                    shopDict[shop].Add(product, 0);
                }
                shopDict[shop][product] = price;
            }

            foreach (var item in shopDict.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var prod in item.Value)
                {
                    Console.WriteLine($"Product: {prod.Key}, Price: {prod.Value}");
                }
  
            }
        }
    }
}