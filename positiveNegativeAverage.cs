using System;
using System.Diagnostics.CodeAnalysis;

namespace PositiveNegativeAverige
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int positiveCount = 0;
            int negativeCount = 0;
            int positiveAverige = 0;
            int negativeAverige = 0;

            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
              
                if (arr[i]<0)
                {
                    negativeAverige += arr[i];
                    negativeCount++;
                }

                if (arr[i]>0)
                {
                    positiveAverige += arr[i];
                    positiveCount++;
                }
            }

            Console.WriteLine($"Average number positive is: {positiveAverige/positiveCount} ");
            Console.WriteLine("");
            Console.WriteLine($"Average number negatives is: {negativeAverige/negativeCount} ");
        }
    }
}
