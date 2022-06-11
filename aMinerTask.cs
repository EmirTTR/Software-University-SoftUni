using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceDict = new Dictionary<string, int>();
            int sum = 0;
            

            while (true)
            {
               string resource = Console.ReadLine();
                List<string> allResources = new List<string>();
                allResources.Add(resource);
                if (resource=="stop")
                {
                    break;
                }
               int quontity = int.Parse(Console.ReadLine());

                if (!resourceDict.ContainsKey(resource))
                {
                    resourceDict.Add(resource, quontity);
                }
                else
                {
                    quontity += resourceDict[resource];
                    resourceDict.Remove(resource);
                    resourceDict.Add(resource, quontity);
                }
              
            }
            foreach (var resoures in resourceDict)
            {
                Console.WriteLine($"{resoures.Key} -> {resoures.Value}");
            }
        }
    }
}
