using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int result= VowelsCount(word);
            Console.WriteLine(result);
        }

        static int VowelsCount(string word)
        {
                int result = 0;
            int countVowels = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char vowel = word[i];
                if (vowel == 'A' || vowel == 'a' || vowel == 'E' || vowel == 'e' ||
                    vowel == 'I' || vowel == 'i' || vowel == 'O' || vowel == 'o' || vowel == 'U' || vowel == 'u')
                {
                    countVowels++;
                }
            }
            result=countVowels;
            return result;
        }
    }
}
