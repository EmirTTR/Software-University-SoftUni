using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> userDict = new Dictionary<string, string>();


            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                if (info[0]=="register")
                {
                    string user = info[1];
                    string userId = info[2];

                    if (userDict.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userId}");
                    }
                    else
                    {
                        userDict.Add(user,userId);
                        Console.WriteLine($"{user} registered {userId} successfully");
                    }
                }
                else if (info[0]=="unregister")
                {
                    string user = info[1];

                    if (userDict.ContainsKey(user))
                    {
                        userDict.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }

            foreach (var user in userDict)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
