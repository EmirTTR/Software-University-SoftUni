using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

                    //•	0 - 2 – baby; 
                    //•	3 - 13 – child; 
                    //•	14 - 19 – teenager;
                    //•	20 - 65 – adult;
                    //•	>= 66 – elder; 
                    //•	All the values are inclusive.//•	



            if (age>=0 && age<3)
            {
                Console.WriteLine("baby");
            }
            else if (age<14)
            {
                Console.WriteLine("child");
            }
            else  if (age<20)
            {
                Console.WriteLine("teenager");
            }
            else if (age<66)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
