using System;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i]>maxNum)
                {
                    maxNum = array[i];
                }

                if (array[i]<minNum)
                {
                    minNum = array[i];
                }

            }

            Console.WriteLine($"Maximum element is : {maxNum}");
            Console.WriteLine($"Minimum element is : {minNum}");
        }
    }
}
