using System;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arrayOfNums = new int[num];
            int sumOfNums = 0;

            for (int i = 0; i < num; i++)
            {
                arrayOfNums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arrayOfNums.Length; i++)
            {
                sumOfNums += arrayOfNums[i];
            }
            Console.WriteLine(sumOfNums);
        }
    }
}
