using System;
namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());

            double kiloMetres = metres / 1000.0;
            Console.WriteLine($"{kiloMetres:f2}");
        }
    }
}