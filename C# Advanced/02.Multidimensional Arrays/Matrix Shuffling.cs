using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cordinates = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = cordinates[0];
            int cols = cordinates[1];
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                string line = Console.ReadLine();
                string[] splitLine = line.Split(" ");

                for (int col = 0; col < matrix.GetLongLength(1); col++)
                {
                    matrix[row, col] = splitLine[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                string[] inputParts = input.Split(" ");
                string command = inputParts[0];
                if (command == "END")
                {
                    break;
                }
                if (inputParts.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int firstCordinate = int.Parse(inputParts[1]);
                int secondCordinate = int.Parse(inputParts[2]);
                int thirdCordinate = int.Parse(inputParts[3]);
                int fourthCordinate = int.Parse(inputParts[4]);
                object temp;



                if (command == "swap" && inputParts.Length == 5 && (firstCordinate >= 0 && firstCordinate <= rows-1) && (secondCordinate >= 0 && secondCordinate <= cols-1) && (thirdCordinate >= 0 && thirdCordinate<=rows-1 && fourthCordinate >=0 && fourthCordinate<=cols-1 ))
                {

                    temp = matrix[thirdCordinate, fourthCordinate];
                    matrix[thirdCordinate, fourthCordinate] = matrix[firstCordinate, secondCordinate];
                    matrix[firstCordinate, secondCordinate] = temp.ToString();

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }
                        Console.WriteLine();

                    }

                }
                else
                {
                   Console.WriteLine("Invalid input!");
                }
            }    
        }
    }
}
