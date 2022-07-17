using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {

            string arr1 = Console.ReadLine();
            string arr2 = Console.ReadLine();
            string[] first = arr1.Split();
            string[] second = arr2.Split();

            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < first.Length; j++)
                {

                    if (second[i] == first[j])
                    {
                        Console.Write(second[i] + " ");
                    }
                }
            }
            Console.Write("");


            //string input1 = Console.ReadLine();
            //string input2 = Console.ReadLine();

            //string[] arr1 = input1.Split();
            //string[] arr2 = input2.Split();


            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    for (int j = 0; j < arr1.Length; j++)
            //    {
            //        if (arr2[i] == arr1[j])
            //        {
            //            Console.Write(arr2[i] + " ");
            //        }


            //    }
            //}

            //Console.WriteLine();
        }
    }
}
