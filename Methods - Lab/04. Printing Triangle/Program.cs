using System;
namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                InternalLoop(i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                InternalLoop(i);
            }
        }

        static void InternalLoop (int i) 
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}