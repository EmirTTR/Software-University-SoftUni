using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int parametersOfMatrix = int.Parse(Console.ReadLine());
            int rows = parametersOfMatrix;
            int  cols = parametersOfMatrix;
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(' ');

                for (int col = 0; col < matrix.GetLongLength(1); col++)
                {
                    foreach (var part in lineParts)
                    {
                        matrix[row, col] = part[col].ToString();
                    }
                    
                }
            }
            char search = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLongLength(1); col++)
                {
                    char letter = matrix[row,col][0];
                    
                    if (letter==search)
                    {
                        int rowNum = row;
                        int colNum = col;
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{search} does not occur in the matrix");
            
        }
    }
}
