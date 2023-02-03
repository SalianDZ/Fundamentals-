using System;
namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = PowerNumber(number, power);
            Console.WriteLine(result);
        }

        private static double PowerNumber(double number, int power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}