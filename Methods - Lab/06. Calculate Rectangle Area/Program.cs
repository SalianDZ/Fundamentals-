using System;
namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = Area(height, width);
        }

        static double Area(double height, double width) 
        { 
            double result = height * width;
            return result;
        }
    }
}