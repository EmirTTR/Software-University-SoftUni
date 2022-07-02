using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double startMoney = double.Parse(Console.ReadLine());
            
            double remaining = startMoney;
            double outfall4Price = 39.99;
            double csOGPrice = 15.99;
            double zplinterZellPrice = 19.99;
            double honored2Price = 59.99;
            double roverWatchPrice = 29.99;
            double roverWatchOriginsPrice = 39.99;

     

            string gameType = Console.ReadLine();

            while (gameType != "Game Time")
            {

                if (gameType=="Game Time")
                {
                    return;
                }
                if (gameType == "OutFall 4")
                {
                    if (startMoney>=outfall4Price)
                    {
                        startMoney -= outfall4Price;
                        Console.WriteLine($"Bought {gameType}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameType == "CS: OG")
                {
                    if (startMoney >= csOGPrice)
                    {
                        startMoney -= csOGPrice;
                        Console.WriteLine($"Bought {gameType}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameType == "Zplinter Zell")
                {
                    if (startMoney >= zplinterZellPrice)
                    {
                        startMoney -= zplinterZellPrice;
                        Console.WriteLine($"Bought {gameType}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameType == "Honored 2")
                {
                    if (startMoney >= honored2Price)
                    {
                         startMoney -= honored2Price;
                         Console.WriteLine($"Bought {gameType}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameType == "RoverWatch")
                {
                    if (startMoney >= roverWatchPrice)
                    {
                        startMoney -= roverWatchPrice;
                        Console.WriteLine($"Bought {gameType}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (gameType == "RoverWatch Origins Edition")
                {
                    if (startMoney >= roverWatchOriginsPrice)
                    {
                        startMoney -= roverWatchOriginsPrice;
                        Console.WriteLine($"Bought {gameType}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                
                gameType = Console.ReadLine();

            }
            if (startMoney<=0)
            {
                Console.WriteLine("Out of money!");
                return;
            }

            Console.WriteLine($"Total spent: ${remaining-startMoney:f2}. Remaining: ${startMoney:f2}");
        }
    }
}

