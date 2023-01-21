using System;
namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long m = int.Parse(Console.ReadLine());
            long y = long.Parse(Console.ReadLine());
            int targetCounter = 0;
            double halfPokePower = n * 0.5;

            while (n >= m)
            {
                n -= m;
                targetCounter++;

                if (n == halfPokePower && y != 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(targetCounter);
        }
    }
}