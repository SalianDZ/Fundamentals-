using System;
namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long startingYield = int.Parse(Console.ReadLine());
            long extractedSpice = 0;
            int daysCounter = 0;

            while (startingYield >= 100)
            {
                extractedSpice += startingYield;
                daysCounter++;
                extractedSpice -= 26;
                startingYield -= 10;
            }
            if (extractedSpice >= 26)
            {
                extractedSpice -= 26;
            }

            Console.WriteLine(daysCounter);
            Console.WriteLine(extractedSpice);
        }
    }
}