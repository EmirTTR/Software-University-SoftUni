using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
///////
namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"%(?<name>[A-Z][a-z]+)%<(?<item>[A-Z][a-z]+)>[^|$%.]*\|(?<quont>\d+)\|[^|$%.]*?(?<price>[0-9]+.?[0-9]+).");
            string input = Console.ReadLine();
            double endPrice = 0;
            double totalPrice = 0;
            while (input!="end of shift")
            {
                Match matching = pattern.Match(input);
                if (matching.Success)
                {
                    var name = matching.Groups["name"].Value;
                    var item = matching.Groups["item"].Value;
                    double quant = double.Parse(matching.Groups["quont"].Value);
                    double price = double.Parse(matching.Groups["price"].Value);
                    endPrice += price * quant;
                    totalPrice += endPrice;

                    Console.WriteLine($"{name}: {item} - {endPrice:f2}");
                    endPrice = 0;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
