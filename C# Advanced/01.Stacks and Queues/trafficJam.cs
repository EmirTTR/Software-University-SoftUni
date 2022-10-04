using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCarCanPast = int.Parse(Console.ReadLine());
            Queue<string> carsQueue = new Queue<string>();
            int carNum = 0;
            int passedCars = 0;

            while (true)
            {
                string car = Console.ReadLine();
                if (car!="green")
                {
                    carsQueue.Enqueue(car);
                    carNum++;
                }
                if (car=="end")
                {
                    break;
                }
                else if (car=="green")
                {
                    int carPass = numberCarCanPast;
                    
                     while (carPass>0)
                     {

                        if (carsQueue.Count>0)
                        {
                             carPass--;
                             Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                            passedCars++;
                        }
                        else
                        {
                            break;
                        }
                     }
                }
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
