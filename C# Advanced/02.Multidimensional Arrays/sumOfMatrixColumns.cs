using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = parameters[0];
            int cols = parameters[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(" ");

                for (int col = 0; col < matrix.GetLongLength(1); col++)
                {
                    matrix[row, col] = int.Parse(lineParts[col]);
                }
            }

            for (int col = 0; col < matrix.GetLongLength(1); col++)
            {
                int colSum = 0;
                for (int row = 0; row < matrix.GetLongLength(0); row++)
                {
                    colSum += matrix[row, col];
                    
                }
                Console.WriteLine(colSum);
                colSum = 0;
                
            }
        }
    }
}
