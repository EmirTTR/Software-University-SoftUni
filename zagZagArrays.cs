using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //int num = int.Parse(Console.ReadLine());
            //int[] first = new int[num];
            //int[] second = new int[num];
            //for (int i = 0; i < num; i++)
            //{
            //    int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //    if (i % 2 == 0)
            //    {
            //        first[i] = number[0];
            //        second[i] = number[1];

            //    }
            //    else
            //    {
            //        second[i] = number[0];
            //        first[i] = number[1];
            //    }
            //}
            //Console.Write(string.Join(" ", first));
            //Console.WriteLine(" ");
            //Console.Write(string.Join(" ", second));



            int num = int.Parse(Console.ReadLine());
            int[] numForArr1 = new int[num];
            int[] numForArr2 = new int[num];


            for (int i = 0; i < num; i++)
            {
                int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    numForArr1[i] = number[0];
                    numForArr2[i] = number[1];
                }
                else
                {
                    numForArr2[i] = number[0];
                    numForArr1[i] = number[1];
                }


            }
            Console.Write(String.Join(" ", numForArr1));
            Console.WriteLine(" ");
            Console.Write(String.Join(" ", numForArr2));












        }
    }
}

