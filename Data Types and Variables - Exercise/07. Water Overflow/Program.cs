using System;
namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            

            for (int i = 0; i < n; i++)
            {
                int currentCapacity = int.Parse(Console.ReadLine());

                if (currentCapacity > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    sum += currentCapacity;
                    capacity -= currentCapacity;
                }
            }
            Console.WriteLine(sum);
        }
    }
}