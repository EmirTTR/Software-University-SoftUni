using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;
            int counter = 0;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }
            userName = Console.ReadLine();
            while (userName!=password)
            {
                if (counter==4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                
                Console.WriteLine($"Incorrect password. Try again.");
                userName = Console.ReadLine();
                counter++;
            }
            Console.WriteLine($"User {userName} logged in." );
        }
    }
}
