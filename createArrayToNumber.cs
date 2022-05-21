using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            while (num.Length>1)
            {
               int[] condenced = new int[num[num.Length - 1]];

                for (int left = 0; left < num.Length-1; left++)
                {

                    for (int right = left+1; right < num.Length; right++)
                    {

                        num[i] += condenced[i];
                        int[] condenced1 = condenced;
                        condenced1[i] = num[i] + num[i + 1];
                        sum += condenced1[i];
                    }

                }
            }
                      Console.WriteLine(sum);
                 
        }
    }
}
