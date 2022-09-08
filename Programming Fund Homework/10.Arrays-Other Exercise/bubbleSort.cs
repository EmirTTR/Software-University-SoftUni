using System;

namespace BubbleSort
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

            for (int i = 0; i < num-1; i++)
            {
                for (int j = i+1; j < num; j++)
                {
                    if (arr[i]>arr[j])
                    {
                        int temp = arr[i];

                        arr[i] = arr[j];

                        arr[j] = temp;
                    }
                }
            }

            foreach (var number in arr)
            {
                Console.Write(number + " ");
            }
        }
    }
}

           