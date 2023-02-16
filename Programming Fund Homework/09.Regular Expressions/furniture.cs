using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
///
namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @">>(?<item>[A-z]*)<<(?<price>[0-9]*.[0-9]+)!(?<quontity>[0-9]*)";

            string input = Console.ReadLine();
            double endPrice = 0;
            List<string> matchingList = new List<string>();
            
            while (input != "Purchase")
            {
                Match matchingItems =Regex.Match(input, pattern,RegexOptions.IgnoreCase);
                if (matchingItems.Success)
                {
                    var name = matchingItems.Groups["item"].Value;
                    double price = double.Parse(matchingItems.Groups["price"].Value);
                    int quant = int.Parse(matchingItems.Groups["quontity"].Value);
                    matchingList.Add(name);
                    endPrice += price * quant;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Bought furniture:");
            if (matchingList.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, matchingList)}");
            }
            Console.WriteLine($"Total money spend: {endPrice:F2}");
        }
    }
}
