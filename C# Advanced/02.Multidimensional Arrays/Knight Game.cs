using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n<=0 || n>=30)
            {
                return;
            }
            int rows = n;
            int cols = n;
            char[,] matrix = new char[rows, cols];
            int count = 0;
            int moveRow = rows;
            int moveCol = cols;

            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLongLength(1); col++)
                {
                    foreach (var item in lineParts)
                    {
                        matrix[row, col] = item[col];
                    }
                }
            }

            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                moveRow = row;
                for (int col = 0; col < matrix.GetLongLength(1); col++)
                {
                    moveCol = col;
                    if (matrix[row,col]=='K')
                    {
                        if (matrix[moveRow+1,moveCol+2]=='K')
                        {
                            count++;
                            break;
                        }
                        else if (matrix[moveRow+2,moveCol+1]=='K')
                        {
                            count++;
                            break;
                        }
                        
                    }
                }
                    if (moveRow>1 && moveCol>1)
                    {
                        moveCol -= 1;
                        moveRow -= 1;
                    }
            }

            Console.WriteLine(count);
        }
    }
}
