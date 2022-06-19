using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dictPlayers = new Dictionary<string, double>();
            string[] racers = Console.ReadLine().Split(", ");
            foreach (var racer in racers)
            {
                if (!dictPlayers.ContainsKey(racer))
                {
                    dictPlayers[racer] = 0;
                }
            }
            double maxLenth = double.MinValue;
            int number = 0;

            while (true)
            {
                string word = Console.ReadLine();
                if (word=="end of race")
                {
                    break;
                }
                string name = string.Empty;
                double sum = 0;
                Regex regex = new Regex(@"[A-Za-z]");

                MatchCollection matches = regex.Matches(word);

                foreach (Match match in matches)
                {
                    name += match.Value;
                }
                if (dictPlayers.ContainsKey(name))
                {
                    MatchCollection matchingNumbers = Regex.Matches(word, @"[0-9]");
                    foreach (Match num in matchingNumbers)
                    {
                        sum += double.Parse(num.Value);
                    }
                        dictPlayers[name] += sum;
                }
            }
         
            dictPlayers = dictPlayers.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            int count = 1;
            foreach (var finish in dictPlayers)
            {
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {finish.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {finish.Key}");
                }
                else if (count == 3)
                {
                    Console.WriteLine($"3rd place: {finish.Key}");
                }
                else
                {
                    break;
                }
                count++;
            }
        }
    }
}
