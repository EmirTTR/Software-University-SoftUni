using System;
using System.Linq;
///
namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] mainNumbers =Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < mainNumbers.Length; i++)
            {
                bool itIsBig = true;

                    for (int j = i+1; j < mainNumbers.Length; j++)
                    {

                        if (mainNumbers[i]<=mainNumbers[j])
                        {
                            itIsBig = false;
                        }
                  
                    }
                if (itIsBig)
                {
                    Console.Write(mainNumbers[i] + " ");
                }
            }

        }
    }
}

                                //                        using System;
                                //                        using System.Collections.Generic;
                                //                        using System.Linq;

                                //namespace ExtraExercise_TopInteger
                                //    {
                                //        class Program
                                //        {
                                //            static void Main(string[] args)
                                //            {
                                //                long[] inputArr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

                                //                for (long i = 0; i < inputArr.Length; i++)
                                //                {
                                //                    bool isItBigger = true;
                                //                    for (long j = i + 1; j < inputArr.Length; j++)
                                //                    {
                                //                        if (inputArr[i] <= inputArr[j])
                                //                        {
                                //                            isItBigger = false;
                                //                        }
                                //                    }

                                //                    if (isItBigger)
                                //                    {
                                //                        Console.Write(inputArr[i] + " ");
                                //                    }
                                //                }
                                //            }
                                //        }
                                //    }

                                //}
