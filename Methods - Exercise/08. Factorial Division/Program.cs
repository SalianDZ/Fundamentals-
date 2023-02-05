using System;
namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            double firstNumberFactorial = GetFactorial(firstNumber);
            int secondNumber = int.Parse(Console.ReadLine());
            double secondNumberFactorial = GetFactorial(secondNumber);
            double result = firstNumberFactorial / secondNumberFactorial;
            Console.WriteLine($"{result:f2}");
        }
        static int GetFactorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}