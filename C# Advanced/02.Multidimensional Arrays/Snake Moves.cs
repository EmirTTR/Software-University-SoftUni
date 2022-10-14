using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cordinates = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = cordinates[0];
            int cols = cordinates[1];
            string snake = Console.ReadLine();
            char[,] matrix = new char[rows, cols];
            Queue<char> myQueue = new Queue<char>();
            int count = 0;
            int capacity = rows * cols;

            for (int i = 0; i < snake.Length; i++)
            {
                myQueue.Enqueue(snake[i]);
                count++;

                if (count==capacity)
                {
                    break;
                }
                if (i==snake.Length-1)
                {
                    i = -1;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                if (row%2==0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = myQueue.Dequeue();
                    }
                }
                else if (row%2!=0)
                {
                    for (int col = cols - 1; col > -1; col--)
                    {
                        matrix[row, col] = myQueue.Dequeue();
                    }
                }
            }

            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLongLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
