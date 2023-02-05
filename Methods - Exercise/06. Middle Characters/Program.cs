using System;
namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            GetWordMiddleChars(word);
        }
        static void GetWordMiddleChars(string word)
        {
            if (word.Length % 2 == 0)
            {
                Console.WriteLine($"{word[(word.Length / 2) - 1]}{word[word.Length / 2]}");
            }
            else
            {
                Console.WriteLine(word[(word.Length / 2)]);
            }
        }
    }
}