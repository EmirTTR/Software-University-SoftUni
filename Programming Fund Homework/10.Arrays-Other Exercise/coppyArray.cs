using System;

namespace copyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] firstArray = new int[num];
            int[] secondArray = new int[num];
            

            for (int i = 0; i < num; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());   
            }

            Console.WriteLine($"The elements stored in the first array are:  ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray = firstArray;
                Console.Write(firstArray[i] + " ");
            }
            secondArray = firstArray;
            Console.WriteLine("");
            Console.WriteLine($"The elements stored in the second array are:  ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i] + " ");
            }

        }
    }
}
