using System;
using System.Linq;
///
namespace SearchEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
           
           
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The even numbers are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
