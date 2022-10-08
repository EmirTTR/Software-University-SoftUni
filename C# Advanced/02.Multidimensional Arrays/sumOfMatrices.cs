using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] needNums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int row = needNums[0];
            int col = needNums[1];
            int[,] table =  new int[row,col];
            int sum = 0;
            

            for (int rows = 0; rows <table.GetLongLength(0); rows++)
            {
                    string colsLine = Console.ReadLine();
                    string[] splitColsLine = colsLine.Split(", ");
                for (int cols = 0; cols < table.GetLongLength(1); cols++)
                {
                    table[rows, cols] = int.Parse(splitColsLine[cols]);
                    
                }
                
            }
            foreach (var num in table)
            {
                sum += num;
            }

            Console.WriteLine(table.GetLongLength(0));
            Console.WriteLine(table.GetLongLength(1));
            Console.WriteLine(sum);

        }
    }
}
