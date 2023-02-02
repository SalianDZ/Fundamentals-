using System;
namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintSum(productName, quantity);
        }

        static void PrintSum(string productName, int quantity)
        {
            double sum = 0;
            if (productName == "coffee")
            {
                sum += (quantity * 1.50);
            }
            else if (productName == "water")
            {
                sum += (quantity * 1.00);
            }
            else if (productName == "coke")
            {
                sum += (quantity * 1.40);
            }
            else if (productName == "snacks")
            {
                sum += (quantity * 2.00);
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}