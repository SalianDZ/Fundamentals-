using System;
using System.Linq;

namespace Fundamentals_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }
    }
}
