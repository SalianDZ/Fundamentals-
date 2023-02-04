using System;
namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            if (firstChar > secondChar)
            {
                char thirdChar = firstChar;
                firstChar = secondChar;
                secondChar = thirdChar;
            }

            for (int i = firstChar + 1; i < secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}