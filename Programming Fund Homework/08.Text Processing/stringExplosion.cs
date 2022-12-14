using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
////////////////
namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {

            string explosionLine = Console.ReadLine();
            int power =0;

            for (int i = 0; i < explosionLine.Length; i++)
            {
                if (explosionLine[i]!='>' && power>0)
                {
                    explosionLine = explosionLine.Remove(i, 1);
                    power--;
                    i--;
                }
                else if (explosionLine[i]=='>')
                {
                    power += int.Parse(explosionLine[i + 1].ToString());
                }
            }
            
            Console.WriteLine(explosionLine);
        }
    }
}
