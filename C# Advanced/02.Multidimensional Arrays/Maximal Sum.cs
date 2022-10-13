using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cordinates = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = cordinates[0];
            int cols = cordinates[1];
            int[,] matrix = new int[rows, cols];
            int subRow = 3;
            int subCol = 3;
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(" ");

                for (int col = 0; col < matrix.GetLongLength(1); col++)
                {
                    matrix[row, col] = int.Parse(lineParts[col]);
                }
            }

            for (int row = 0; row < matrix.GetLongLength(0)-subRow+1; row++)
            {
                for (int col = 0; col < matrix.GetLongLength(1)-subCol+1; col++)
                {
                    int sum = 0;
                    for (int i = 0; i < subRow; i++)
                    {
                        for (int j = 0; j < subCol; j++)
                        {
                            sum += matrix[row + i, col + j];
                        }
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            int count = 0;
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = maxRow; row < maxRow+subRow; row++)
            {
                for (int col = maxCol; col < maxCol+subCol; col++)
                {
                    count++;
                    if (count==1)
                    {
                        Console.Write($"{ string.Join("", matrix[row, col])}");
                    }
                    else
                    {
                        Console.Write($" { string.Join("", matrix[row, col])}");
                    }
                }
                count = 0;
                Console.WriteLine();
            }

        }
    }
}
