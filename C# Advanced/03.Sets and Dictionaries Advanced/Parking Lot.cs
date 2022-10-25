using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> carNumbers = new List<string>();

            while (true)
            {
                string[] inputParts = input.Split(", ");
                string command = inputParts[0];
                if (command=="END")
                {
                    break;
                }
                string carNum = inputParts[1];

                if (command=="IN")
                {
                    if (!carNumbers.Contains(carNum))
                    {
                        carNumbers.Add(carNum);
                    }
                }
                else if (command=="OUT")
                {
                    if (carNumbers.Contains(carNum))
                    {
                        carNumbers.Remove(carNum);
                    }
                }
                input = Console.ReadLine();
            }

            if (carNumbers.Count<1)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in carNumbers)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
