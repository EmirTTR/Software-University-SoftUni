using System;
using System.Linq;

namespace AverageOfTwoGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[num1];
            int count1Arr1 = 0;
            int count2Arr1 = 0;
            int count1Arr2 = 0;
            int count2Arr2 = 0;
            int countForNum1 = 1;
            int countForNum2 = 1;
            int averageFirstGroupArr1 = 0;
            int averageSecondGroupArr1 = 0;
            int averageFirstGroupArr2 = 0;
            int averageSecondGroupArr2 = 0;

            for (int i = 0; i < num1; i++)
            {
                while (countForNum1 <= 10)
                {
                    arr1[i] = int.Parse(Console.ReadLine());
                    countForNum1++;
                }

                for (int j = arr1[i]; j < arr1.Length-1; j++)
                {
                    if (arr1[j] == arr1[0] || arr1[j] == arr1[1] ||
                        arr1[j] == arr1[2] || arr1[j] == arr1[3] || arr1[j] == arr1[4])

                    {
                        averageFirstGroupArr1 += arr1[j];
                        count1Arr1++;
                    }

                    else if (arr1[j] == arr1[5] || arr1[j] == arr1[6] || arr1[j] == arr1[7] ||
                             arr1[j] == arr1[8] || arr1[j] == arr1[9])

                    {
                        averageSecondGroupArr1 += arr1[j];
                        count2Arr1++;
                    }
                }
            }

            Console.WriteLine("");


                int num2 = int.Parse(Console.ReadLine());
                int[] arr2 = new int[num2];

                for (int i = 0; i < num2; i++)
                {
                    while (countForNum2 <= 10)
                    {
                        arr2[i] = int.Parse(Console.ReadLine());
                        countForNum2++;
                    }


                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr2[i] == arr2[0] || arr2[i] == arr2[1] || arr2[i] == arr2[2] || arr2[i] == arr2[3] ||
                            arr2[i] == arr2[4])

                        {
                            averageFirstGroupArr2 += arr2[i];
                            count1Arr2++;
                        }

                        if (arr2[i] == arr2[5] || arr2[i] == arr2[6] || arr2[i] == arr2[7] || arr2[i] == arr2[8] ||
                            arr2[i] == arr2[9])

                        {
                            averageSecondGroupArr2 += arr2[i];
                            count2Arr2++;
                        }

                        Console.WriteLine("Average for group 1 is: ");
                        Console.Write($"{averageFirstGroupArr1 / count1Arr1}, {averageSecondGroupArr1 / count2Arr1} ");
                        Console.WriteLine("");
                        Console.WriteLine("Average for group 2 is: ");
                        Console.Write($"{averageFirstGroupArr2 / count1Arr2}, {averageSecondGroupArr2 / count2Arr2} ");
                    }
                }
            
        }
    }
}
