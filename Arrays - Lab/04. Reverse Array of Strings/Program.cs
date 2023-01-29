using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write($"{words[i]} ");
            }
        }
    }
}