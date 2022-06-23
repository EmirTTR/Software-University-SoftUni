using System;
using System.Linq;

namespace Print_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] array = new int[numbers];


            for (int i = 0; i < numbers; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[0]==0)
                {
                    array[0] = 1;
                }
                Console.Write($"{array[i]} ");
            }
        }
    }
}
