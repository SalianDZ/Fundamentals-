using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                sum += currentChar;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}