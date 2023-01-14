using System;
using System.Collections.Generic;
using System.Linq;
/////////////////////
namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < numPeople; i++)
            {
                List<string> names = Console.ReadLine().Split(" ").ToList();

                  if (names[2]=="going!")
                  {
                      if (!guests.Contains(names[0]))
                      {
                          guests.Add(names[0]);
                      }
                      else
                      {
                          Console.WriteLine($"{names[0]} is already in the list!");
                      }
                  }
                  else if (names[2]=="not")
                  {
                      if (guests.Contains(names[0]))
                      {
                          guests.Remove(names[0]);
                      }
                      else
                      {
                          Console.WriteLine($"{names[0]} is not in the list!");
                      }
                  }

                
            }

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
