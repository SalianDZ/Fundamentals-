using System;
namespace _01.DaysOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[] {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[n - 1]);
            }
        }
    }
}