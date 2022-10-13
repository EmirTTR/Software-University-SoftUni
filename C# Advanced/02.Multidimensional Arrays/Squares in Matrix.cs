using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string cordinates = Console.ReadLine();
            string[] splitCordinates = cordinates.Split(" ");
            int rows =int.Parse(splitCordinates[0]);
            int cols =int.Parse(splitCordinates[1]);
            string[,] matrix = new string[rows, cols];
            int countEqual = 0;
            List<string> word = new List<string>();
            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(" ");
                foreach (var item in lineParts)
                {
                    word.Add(item);
                }
               
                for (int col = 0; col < matrix.GetLongLength(1); col++)
                {
                    for (int i = 0; i < word.Count;)
                    {
                        matrix[row, col] = word[i].ToString();
                        word.RemoveAt(i);
                        break;
                    }
                }
                    word.Clear();
            }
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    string fist = matrix[row, col].ToString();
                    string second = matrix[row, col+1].ToString();
                    string third = matrix[row+1, col].ToString();
                    string forth = matrix[row+1, col+1].ToString();
                    if (fist==second && second==third && third==forth && forth==fist && forth==second && third==fist)
                    {
                        countEqual++;
                    }
                }
            }
            Console.WriteLine(countEqual);
        }
    }
}
