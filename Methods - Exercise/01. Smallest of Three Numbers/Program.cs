using System;
namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            GetMinNumber(first, second, third);
        }

        private static void GetMinNumber(int first, int second, int third)
        {
            int min = Math.Min(first, (Math.Min(second, third)));
            Console.WriteLine(min);
        }
    }
}