using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> partyVisitors = new HashSet<string>();
            List<string> regularGuests = new List<string>();
            List<string> VIPGuests = new List<string>();

            while (true)
            {
                string visitors = Console.ReadLine();
                if (visitors.Length == 8 || visitors=="PARTY")
                {
                    if (visitors =="PARTY")
                    {
                        break;
                    }
                    partyVisitors.Add(visitors);
                }
            }
            while (true)
            {
                string guest = Console.ReadLine();
                if (guest=="END")
                {
                    break;
                }
                if (partyVisitors.Contains(guest))
                {
                    partyVisitors.Remove(guest);
                }
            }

            foreach (var item in partyVisitors)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (char.IsDigit(item[0]))
                    {
                        VIPGuests.Add(item);
                        break;
                    }
                    else
                    {
                        regularGuests.Add(item);
                        break;
                    }
                }
            }

            int allDidNorCum = regularGuests.Count + VIPGuests.Count;

            Console.WriteLine(allDidNorCum);

            if (VIPGuests.Count>0)
            {
                foreach (var item in VIPGuests)
                {
                    Console.WriteLine(item);
                }
            }
            if (regularGuests.Count>0)
            {
                foreach (var item in regularGuests)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
