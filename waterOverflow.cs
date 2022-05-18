using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int waterTank =255;
            int sum = 0;
            
                for (int i = 0; i < times; i++)
                {
                 
                   
                   int needWater = int.Parse(Console.ReadLine());

                    if (sum + needWater > waterTank)
                    {
                        Console.WriteLine($"Insufficient capacity!");
                    }
                    else
                    {
                        sum += needWater;
                    }         
                }
                  Console.WriteLine(sum);    
        }
    }
}
