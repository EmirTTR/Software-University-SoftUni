using System;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = int.Parse(Console.ReadLine());
            int[][] jiggedArray = new int[parameter][];

            for (int i = 0; i < parameter; i++)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(" ");
                jiggedArray[i] = new int[lineParts.Length];

                for (int j = 0; j < lineParts.Length; j++)
                {
                    jiggedArray[i][j] = int.Parse(lineParts[j]);
                }
               
            }

            while (true)
            {
                string input = Console.ReadLine();
                string[] splitInput = input.Split(" ");
                string command = splitInput[0];

                if (command=="END")
                {
                    break;
                }

                int rowIndex = int.Parse(splitInput[1]);
                int colIndex = int.Parse(splitInput[2]);
                int numberToUse = int.Parse(splitInput[3]);

                if (rowIndex<0 || rowIndex>=jiggedArray.Length || colIndex<0 || colIndex>=jiggedArray[rowIndex].Length )
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (command == "Add")
                {
                    jiggedArray[rowIndex][colIndex] += numberToUse;
                }
                else if (command=="Subtract")
                {
                    jiggedArray[rowIndex][colIndex] -= numberToUse;
                }

            }
                for (int i = 0; i < jiggedArray.Length; i++)
                {
                    for (int j = 0; j < jiggedArray[i].Length; j++)
                    {
                        Console.Write(jiggedArray[i][j] + " ");
                    }
                    Console.WriteLine();
                }
        }
    }
}
