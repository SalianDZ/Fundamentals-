using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int counter = PrintVowels(word);
            Console.WriteLine(counter);
        }

        static int PrintVowels(string word)
        {
            char[] vowels = {'a', 'e', 'o', 'u', 'i','y', 'A', 'E', 'O', 'U', 'I', 'Y'};
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'o' || word[i] == 'u' || word[i] == 'i' || word[i] == 'A'
                    || word[i] == 'E' || word[i] == 'O' || word[i] == 'U' || word[i] == 'I')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}