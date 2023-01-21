using System;
using System.Text;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            // Convert the string into a byte[].
            byte[] asciiBytes = Encoding.ASCII.GetBytes(value);

            if (asciiBytes[0] > 90)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}