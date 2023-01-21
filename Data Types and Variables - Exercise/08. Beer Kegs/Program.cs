using System;
namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beerNumber = int.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string bestModel = "";

            for (int i = 0; i < beerNumber; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * (radius * radius) * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    bestModel = model;
                }
            }
            Console.WriteLine(bestModel);
        }
    }
}