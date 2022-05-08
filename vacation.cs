using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Students – if the group is bigger than or equal to 30 people you should reduce the total price by 15 %
            //•	Business – if the group is bigger than or equal to 100 people 10 of them can stay for free.
            //•	Regular – if the group is bigger than or equal to 10 and less than or equal to 20 reduce the total price by 5 %




            int numPeoples = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double priceForSingle = 0;
            double bigPrice = 0;
            double totalPrice = 0;
            if (numPeoples>=0)
            {
                if (group == "Students")
                {
                    if (day == "Friday")
                    {
                        priceForSingle = 8.45;

                        if (numPeoples >= 30)
                        {
                            bigPrice = priceForSingle * numPeoples;
                            totalPrice = bigPrice - (bigPrice * 15 / 100);
                        }
                        else
                        {
                            totalPrice = priceForSingle * numPeoples;
                        }

                    }
                    if (day == "Saturday")
                    {
                        priceForSingle = 9.80;

                        if (numPeoples >= 30)
                        {
                            bigPrice = priceForSingle * numPeoples;
                            totalPrice = bigPrice - (bigPrice * 15 / 100);
                        }
                        else
                        {
                            totalPrice = priceForSingle * numPeoples;
                        }
                    }
                    if (day == "Sunday")
                    {
                        priceForSingle = 10.46;

                        if (numPeoples >= 30)
                        {
                            bigPrice = priceForSingle * numPeoples;
                            totalPrice = bigPrice - (bigPrice * 15 / 100);
                        }
                        else
                        {
                            totalPrice = priceForSingle * numPeoples;
                        }
                    }

                }


                if (group == "Business")
                {
                    if (day == "Friday")
                    {
                        priceForSingle = 10.90;

                        if (numPeoples >= 100)
                        {
                            bigPrice = priceForSingle * numPeoples;
                            totalPrice = bigPrice - (10 * priceForSingle);
                        }
                        else
                        {
                            totalPrice = priceForSingle * numPeoples;
                        }
                    }
                    if (day == "Saturday")
                    {
                        priceForSingle = 15.60;

                        if (numPeoples >= 100)
                        {
                            bigPrice = priceForSingle * numPeoples;
                            totalPrice = bigPrice - (10 * priceForSingle);
                        }
                        else
                        {
                            totalPrice = priceForSingle * numPeoples;
                        }
                    }
                    if (day == "Sunday")
                    {
                        priceForSingle = 16;

                        if (numPeoples >= 100)
                        {
                            bigPrice = priceForSingle * numPeoples;
                            totalPrice = bigPrice - (10 * priceForSingle);
                        }
                        else
                        {
                            totalPrice = priceForSingle * numPeoples;
                        }
                    }

                }


                if (group == "Regular")
                {
                    if (day == "Friday")
                    {
                        priceForSingle = 15;

                        if (numPeoples >= 10 && numPeoples <= 20)
                        {
                            bigPrice = priceForSingle * numPeoples;
                            totalPrice = bigPrice - (bigPrice * 5 / 100);
                        }
                        else
                        {
                            totalPrice = priceForSingle * numPeoples;
                        }
                    }
                    if (day == "Saturday")
                    {
                        priceForSingle = 20;

                        if (numPeoples >= 10 && numPeoples <= 20)
                        {
                            bigPrice = priceForSingle * numPeoples;
                            totalPrice = bigPrice - (bigPrice * 5 / 100);
                        }
                        else
                        {
                            totalPrice = priceForSingle * numPeoples;
                        }
                    }
                    if (day == "Sunday")
                    {
                        priceForSingle = 22.50;

                        if (numPeoples >= 10 && numPeoples <= 20)
                        {
                            bigPrice = priceForSingle * numPeoples;
                            totalPrice = bigPrice - (bigPrice * 5 / 100);
                        }
                        else
                        {
                            totalPrice = priceForSingle * numPeoples;
                        }
                    }

                }
                Console.WriteLine($"Total price: {totalPrice:f2}");

            }
        }
    }
}
