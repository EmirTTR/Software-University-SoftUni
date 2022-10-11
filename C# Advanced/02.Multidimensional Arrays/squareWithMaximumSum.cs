using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = parameters[0];
            int cols = parameters[1];
            int[,] squareMatrix = new int[rows, cols];
            int maxOfFour = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < squareMatrix.GetLongLength(0); row++)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(", ");

                for (int col = 0; col < squareMatrix.GetLongLength(1); col++)
                {
                    squareMatrix[row, col] = int.Parse(lineParts[col]);
                }
            }

            for (int row = 0; row < squareMatrix.GetLongLength(0)-1; row++)
            {
                for (int col = 0; col < squareMatrix.GetLongLength(1)-1; col++)
                {
                    int sumOfFour = 0;
                    sumOfFour += squareMatrix[row, col] + squareMatrix[row, col + 1] + squareMatrix[row + 1, col] + squareMatrix[row + 1, col + 1];
                    if (sumOfFour>maxOfFour)
                    {
                        maxOfFour = sumOfFour;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            for (int row = maxRow; row < maxRow+2; row++)
            {
                for (int col = maxCol; col < maxCol+2; col++)
                {
                    Console.Write(squareMatrix[row,col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxOfFour);
        }
    }
}
