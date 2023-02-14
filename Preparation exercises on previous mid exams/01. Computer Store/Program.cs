using System;
namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            double currentPrice = 0;
            double taxes = 0;

            while (input != "special" && input != "regular")
            {
                currentPrice = double.Parse(input);

                if (currentPrice > 0)
                {
                    sum += currentPrice;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
                input = Console.ReadLine();
            }

            if (input == "regular")
            {
                if (sum > 0)
                {
                    taxes = sum * 0.20;
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {sum:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {(sum + taxes):f2}$");
                }
                else
                {
                    Console.WriteLine("Invalid order!");
                }
            }
            else if (input == "special")
            {
                if (sum > 0)
                {
                    taxes = sum * 0.20;
                    double totalSum = sum + taxes;
                    double sumPlusDiscount = totalSum - (totalSum * 0.10);
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {sum:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {(sumPlusDiscount):f2}$");
                }
                else
                {
                    Console.WriteLine("Invalid order!");
                }
            }

        }
    }
}