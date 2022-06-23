using System;
using System.Linq;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] rev = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                rev[i] = arr[arr.Length - 1 - i];
            }

            for (int i = 0; i < rev.Length; i++)
            {
                Console.Write(rev[i] + " ");
            }
        }
    }
}
