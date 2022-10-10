using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            if (rows<=0)
            {
                return;
            }
            int cols = rows;
            int[,] table = new int[rows,cols];

            for (int row = 0; row < table.GetLongLength(0); row++)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(" ");

                for (int col = 0; col < table.GetLongLength(1); col++)
                {
                    table[row, col] = int.Parse(lineParts[col]);
                }
            }

            for (int row = 0; row < table.GetLongLength(0); row++)
            {
                int sumDiagonal = 0;

                for (int col = 0; col < table.GetLongLength(1); col++)
                {
                    sumDiagonal = table[row, col] + table[row + 1, col + 1] + table[row + 2, col + 2];
                    Console.WriteLine(sumDiagonal);
                    return;
                    
                }
            }
        }
    }
}
