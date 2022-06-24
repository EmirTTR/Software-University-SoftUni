using System;

namespace UniqueElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            
            int count = 0;
     
            for (int i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (array[i]==array[j])
                    {
                        count++;
                        isDuplicate=true;
                        break;
                    }
                }

                if (count==1)
                {
                    count = 0;
                }
                else if (isDuplicate)
                {
                    Console.WriteLine(array[i]);
                    
                }
            }

            Console.WriteLine();
        }
    }
}
