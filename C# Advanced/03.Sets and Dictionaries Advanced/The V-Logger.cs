using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggerDict = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            int followedCount = 0;

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                string vlogger = input[0];
                if (vlogger=="Statistics")
                {
                    break;
                }
                string command = input[1];
                if (command == "joined")
                {
                    if (!vloggerDict.ContainsKey(vlogger))
                    {
                        vloggerDict.Add(vlogger, new Dictionary<string, HashSet<string>>());
                        vloggerDict[vlogger].Add("followers", new HashSet<string>());
                        vloggerDict[vlogger].Add("following", new HashSet<string>());
                    }
                }
                else if (command=="followed")
                {
                    string followedVlogger = input[2];

                    if (vlogger != followedVlogger && vloggerDict.ContainsKey(vlogger) && vloggerDict.ContainsKey(followedVlogger))
                    {
                        vloggerDict[vlogger]["following"].Add(followedVlogger);
                        vloggerDict[followedVlogger]["followers"].Add(vlogger);
                    }
                }
            }

             Console.WriteLine($"The V-Logger has a total of {vloggerDict.Count} vloggers in its logs.");
            int number = 1;
            
            foreach (var item in vloggerDict.OrderByDescending(x=>x.Value["followers"].Count).ThenBy(x=>x.Value["following"].Count))
            {
                Console.WriteLine($"{number}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                if (number == 1)
                {
                    foreach (var people in item.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {people}");
                    }
                }
                number++;
            }
        }
    }
}
