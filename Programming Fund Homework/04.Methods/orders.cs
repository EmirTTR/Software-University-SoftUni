using System;
//
namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFood = Console.ReadLine();
            double priceForFood = int.Parse(Console.ReadLine());
            foodBuy(typeOfFood,priceForFood);

        }

        static void  foodBuy(string word,double number)
        {
            double waterPrice = 1.00;
            double coffeePrice = 1.50;
            double cokePrice = 1.40;
            double snacksPrice = 2.00;

            switch (word)
            {
                case "water":
                    double waterMoney = 0;
                   waterMoney= number * waterPrice;
                    Console.WriteLine($"{waterMoney:f2}");
                    break;
                case "coffee":
                    double coffeeMoney = 0;
                   coffeeMoney = number * coffeePrice;
                    Console.WriteLine($"{coffeeMoney:f2}");
                    break;
                case "snacks":
                   double snacksMoney = 0;
                   snacksMoney=number * snacksPrice;
                    Console.WriteLine($"{snacksMoney:f2}");
                    break;
                case "coke":
                    double cokeMoney = 0;
                   cokeMoney= number * cokePrice;
                    Console.WriteLine($"{cokeMoney:f2}");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
                    ;
            }

        }
      

    }
}
