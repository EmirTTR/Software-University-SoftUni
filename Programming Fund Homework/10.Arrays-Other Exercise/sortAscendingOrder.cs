using System;
using System.Text.Json;

namespace SortInAscendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            int[] copied = new int[number];
            
            
            int[] arr1 = new int[number];
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < number; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                copied=arr1[i];
            }

            Console.WriteLine("");
            int number1 = int.Parse(Console.ReadLine());
            string[] copied1 = new string[number1];
            for (int i = 0; i < number; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arr1.Length; i <= arr2.Length; i++)
            {

                if (arr2[i] == number)
                {
                    Console.Write(arr1[i]);

                    Console.Write(arr2[i]);
                }
            }
        }
    }
}
