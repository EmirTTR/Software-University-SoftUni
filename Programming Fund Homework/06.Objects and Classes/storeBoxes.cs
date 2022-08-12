using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> itemsInBox = new List<Box>();
            string input = Console.ReadLine();
            
            while (input!="end")
            {
                string[] split = input.Split();
                int serialNumber = int.Parse(split[0]);
                string itemName = split[1];
                int itemQuontity = int.Parse(split[2]);
                double itemPrice = double.Parse(split[3]);

          
                Box boxItems = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemQuantity = itemQuontity,
                    PriceForABox = itemPrice,
                    Item = itemName,
                    BoxPrice=itemQuontity*itemPrice
                    
            };
                itemsInBox.Add(boxItems);

                double boxPrice = itemPrice * itemQuontity;

                input = Console.ReadLine();
            }
            List<Box> sortedBox = itemsInBox.OrderByDescending(itemsInBox => itemsInBox.BoxPrice).ToList();


            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.PriceForABox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }
   
    class Box
    {
        public int SerialNumber { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox  { get; set; }
        public string Item  { get; set; }
        public double BoxPrice  { get; set; }

    }
}
