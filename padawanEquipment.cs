using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	The amount of money Ivan Cho has – the floating-point number in the range[0.00…1, 000.00]
            //•	The count of students – integer in the range[0…100]
            //•	The price of lightsabers for a single saber – the floating - point number in the range[0.00…100.00]
            //•	The price of robes for a single robe – the floating - point number in the range[0.00…100.00]
            //•	The price of belts for a single belt – the floating - point number in the range[0.00…100.00]

            // •	If the calculated price of the equipment is less or equal to the money Ivan Cho has:
            // o   
            //•	If the calculated price of the equipment is more than the money Ivan Cho has:
            // o   
            //•	All prices must be rounded to two digits after the decimal point.


            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double needMoney = 0;
            

            needMoney = (lightPrice *(lightPrice * 10 / 100 + students)) + robesPrice * students + beltsPrice * students;
            if (students%6==0)
            {
                needMoney -= beltsPrice;
            }

            if (money > needMoney)
            {
                money -= needMoney;
                Console.WriteLine($"The money is enough - it would cost {needMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {needMoney - money}lv more.");
            }

        }
    }
}
