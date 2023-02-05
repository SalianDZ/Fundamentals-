using System;
using System.Linq;
namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CheckNumber(input);
        }
        static void CheckNumber(string input)
        {
            int reversedNumber = 0;
            string reversedNumberAsString = "";
            string numberAsString = "";
            while (input != "END")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    continue;
                }
                else
                {
                    numberAsString = number.ToString();
                    char[] numberAsStringInChars = numberAsString.ToCharArray();
                    Array.Reverse(numberAsStringInChars);
                    reversedNumberAsString = new string(numberAsStringInChars);
                    reversedNumber = int.Parse(reversedNumberAsString);
                }

                if (number == reversedNumber)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }
    }
}