using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            if (rows<2 || rows>12)
            {
                return;
            }
            int[][] matrix = new int[rows][];
            int count = 0;
            int subtract = 0;
            int firstLenght = 0;
            

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                matrix[row] = line.Split(new char[] { ' ' }).Select(int.Parse).ToArray();
            }
            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                count++;
                if (count != 1)
                {

                }
                else if (matrix[row].Length == matrix[row + 1].Length && count == 1)
                {
                    firstLenght = matrix[row].Length;
                    foreach (var item in matrix[row])
                    {
                        matrix[0][row] *= 2;
                        row++;
                    }
                    row = 0;
                }
                else if (matrix[row].Length != matrix[row + 1].Length && count == 1)
                {
                    firstLenght = matrix[row].Length;
                    foreach (var item in matrix[row])
                    {
                        matrix[0][row] /= 2;
                        row++;
                    }
                    row = 0;
                }


                if (firstLenght != matrix[matrix.Length - 1].Length && row == matrix.Length - 1)
                {
                    foreach (var item in matrix[row])
                    {
                        matrix[row][subtract] /= 2;
                        subtract++;
                    }
                    row = 0;
                    break;
                }
                else if (firstLenght == matrix[matrix.Length - 1].Length && row == matrix.Length - 1)
                {
                    foreach (var item in matrix[row])
                    {
                        matrix[row][subtract] *= 2;
                        subtract++;
                    }
                    row = 0;
                    break;
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                string[] inputParts = input.Split(" ");
                string command = inputParts[0];
                if (command == "End")
                {
                    break;
                }

                if (command == "Add")
                {
                    int row = int.Parse(inputParts[1]);
                    int col = int.Parse(inputParts[2]);
                    int value = int.Parse(inputParts[3]);
                    if (row >= 0 && row < matrix.GetLongLength(0) && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (command == "Subtract")
                {
                    int row = int.Parse(inputParts[1]);
                    int col = int.Parse(inputParts[2]);
                    int value = int.Parse(inputParts[3]);
                    if (row >= 0 && row < matrix.GetLongLength(0) && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {

                Console.Write(string.Join(" ", matrix[row]));

                Console.WriteLine();
            }


        }
    }
}
