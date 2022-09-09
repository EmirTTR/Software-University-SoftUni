using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];

            for (int i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The Even elements are:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write($"{array[i]} ");
                    
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"The Odd elements are:");
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] % 2 != 0)
                {
                    Console.Write($"{array[i]} ");

                }
            }
            
        }
    }
}
