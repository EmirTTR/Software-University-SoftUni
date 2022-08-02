using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0; 
            List<string> ordered = new List<string>();
            

            for (int i = 0; i < num; i++)
            {
                
                string products = Console.ReadLine();
                ordered.Add(products);
                ordered.Sort();
            }

            for (int i = 0; i < ordered.Count; i++)
            {
                count++;
                Console.WriteLine($"{count}.{string.Join(" ",ordered[i])}");
            }
           
                
            
            
        }
    }
}
