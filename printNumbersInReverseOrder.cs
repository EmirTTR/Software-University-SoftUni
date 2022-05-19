using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];

            for (int i = 0; i < num; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }

            int[] reversed = new int[numbers.Length];

            for (int i = 0; i <numbers.Length; i++)
            {
                reversed[i] = numbers[numbers.Length - 1 - i];

            }

            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write(reversed[i] + " ");
            }

       

       

        
        }
    }
}
