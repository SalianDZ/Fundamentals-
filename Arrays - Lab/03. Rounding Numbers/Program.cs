using System;
using System.Linq;

namespace Fundamentals_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double[] newNumbers = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                newNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {newNumbers[i]}");
            }
        }
    }
}
