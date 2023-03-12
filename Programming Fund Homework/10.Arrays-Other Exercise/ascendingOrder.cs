using System;
/
namespace AscendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int minNum = int.MaxValue;
            int[] reversed = new int[num];
            

            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minNum)
                {
                    minNum = arr[i];
                        arr[i] = minNum;
                        reversed[num] = arr[i];

                }
            }

            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write($"{reversed[i]} ");
            }
        }
    }
}
