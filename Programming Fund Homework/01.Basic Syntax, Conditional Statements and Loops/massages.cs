using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            string word=String.Empty;
            string a = "a";
            string b = "b";
            string c = "c";
            string d = "d";
            string e = "e";
            string f = "f";
            string g = "g";
            string h = "h";
            string i = "i";
            string j = "j";
            string k = "k";
            string l = "l";
            string m = "m";
            string n = "n";
            string o = "o";
            string p = "p";
            string q = "q";
            string r = "r";
            string s = "s";
            string t = "t";
            string u = "u";
            string v = "v";
            string w = "w";
            string x = "x";
            string y = "y";
            string z = "z";
            string space = " ";

            //•	a b c   •	d e f   •	g h i   •	j k  l •	m n  o •	p q  r s	•	t u v   •	w x  y z

            for (int index = 1; index <= iterations; index++)
            {
                string letter = Console.ReadLine();

                if (letter == "2" || letter == "22" || letter == "222")
                {
                    if (letter == "2")
                    {
                        word += a;
                    }

                    if (letter == "22")
                    {
                        word += b;
                    }

                    if (letter == "222")
                    {
                        word += c;
                    }
                }

                if (letter == "3" || letter == "33" || letter == "333")
                {
                    if (letter == "3")
                    {
                        word += d;
                    }

                    if (letter == "33")
                    {
                        word += e;
                    }

                    if (letter == "333")
                    {
                        word += f;
                    }
                }

                if (letter == "4" || letter == "44" || letter == "444")
                {
                    if (letter == "4")
                    {
                        word += g;
                    }

                    if (letter == "44")
                    {
                        word += h;
                    }

                    if (letter == "444")
                    {
                        word += i;
                    }
                }

                if (letter == "5" || letter == "55" || letter == "555")
                {
                    if (letter == "5")
                    {
                        word += j;
                    }

                    if (letter == "55")
                    {
                        word += k;
                    }

                    if (letter == "555")
                    {
                        word += l;
                    }
                }

                if (letter == "6" || letter == "66" || letter == "666")
                {
                    if (letter == "6")
                    {
                        word += m;
                    }

                    if (letter == "66")
                    {
                        word += n;
                    }

                    if (letter == "666")
                    {
                        word += o;
                    }
                }

                if (letter == "7" || letter == "77" || letter == "777" || letter == "7777")
                {
                    if (letter == "7")
                    {
                        word += p;
                    }

                    if (letter == "77")
                    {
                        word += q;
                    }

                    if (letter == "777")
                    {
                        word += r;
                    }

                    if (letter == "7777")
                    {
                        word += s;
                    }
                }

                if (letter == "8" || letter == "88" || letter == "888")
                {
                    if (letter == "8")
                    {
                        word += t;
                    }

                    if (letter == "88")
                    {
                        word += u;
                    }

                    if (letter == "888")
                    {
                        word += v;
                    }

                }

                if (letter == "9" || letter == "99" || letter == "999" || letter == "9999")
                {
                    if (letter == "9")
                    {
                        word += w;
                    }

                    if (letter == "99")
                    {
                        word += x;
                    }

                    if (letter == "999")
                    {
                        word += y;
                    }

                    if (letter == "9999")
                    {
                        word += z;
                    }
                }

                if (letter == "0")
                {

                    word += space;

                }
            }

            Console.Write(word);
        }
    }

}