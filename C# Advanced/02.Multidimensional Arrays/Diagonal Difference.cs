using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] matrix = new long[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            }
            long sumLeftDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                sumLeftDiagonal += matrix[row][row];
            }

            long sumRightDiagonal = 0;
            for (int row = 0, col = n - 1; row < n; row++, col--)
            {
                sumRightDiagonal += matrix[row][col];
            }
            long finalSum = sumLeftDiagonal - sumRightDiagonal;
            Console.WriteLine(Math.Abs(finalSum));
        }
    }
}
