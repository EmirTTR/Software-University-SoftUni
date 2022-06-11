using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> product = new Dictionary<string, double>();
            Dictionary<int, int> quontity = new Dictionary<int,int>();
            int sum = 0;
            

            string[] input = Console.ReadLine().Split();

            while (input[0]!="buy")
            {
                
                string productName = input[0];
                double productPrice = double.Parse(input[1]);
                int producktQuontity = int.Parse(input[2]);
                
               
                if (!product.ContainsKey(productName))
                { 
                    product.Add(productName, new double[1]);
                }
                else
                {
                    double preveousQuontity = product[productName][1];
                    if (product[productName]!=productPrice)
                    {
                        product[productName] = 0;
                        product[productName] += productPrice;
                        productPrice *= producktQuontity;
                        product.Remove(productName);
                        product.Add(productName, productPrice);

                    }
                    
                }
                
                input = Console.ReadLine().Split();
            }
            foreach (var item in product)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
