using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex datePattern = new Regex(@"(?<day>[0-9]{2})(?<sep>\.?\-?\/?)(?<month>[A-Z]{1}[a-z]{2})\k<sep>(?<year>[0-9]{4})\b");
            MatchCollection matchingDates = datePattern.Matches(input);

            foreach (Match item in matchingDates)
            {
                Console.WriteLine($"Day: {item.Groups["day"].Value}, Month: {item.Groups["month"].Value}, Year: {item.Groups["year"].Value}");
            }

        }
    }
}
