using System;

namespace DublicateElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            int count =  0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int count7 = 0;
            int count8 = 0;
            int count9 = 0;

            for (int i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == 0)
                {
                    count++;
                    if (count >= 2)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                if (array[i] == 1)
                {
                    count1++;
                    if (count1>=2)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                if (array[i] == 2)
                {
                    count2++;
                    if (count2 >= 2)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                if (array[i] == 3)
                {
                    count3++;
                    if (count3 >= 2)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                if (array[i] == 4)
                {
                    count4++;
                    if (count4 >= 2)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                if (array[i] == 5)
                {
                    count5++;
                    if (count5 >= 2)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                if (array[i] == 6)
                {
                    count6++;
                    if (count6 >= 2)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                if (array[i] == 7)
                {
                    count7++;
                    if (count7 >= 2)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                if (array[i] == 8)
                {
                    count8++;
                    if (count8 >= 2)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                if (array[i] == 9)
                {
                    count9++;
                    if (count9 >= 2)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                
            }
        }
    }
}
