using System;
namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();
            int number = int.Parse(numberAsString);
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int sum = evenSum * oddSum;
            return sum;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            int absoluteNumber = Math.Abs(number);

            while (absoluteNumber > 0)
            {
                int lastDigit = absoluteNumber % 10;

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit; 
                }

                absoluteNumber = absoluteNumber / 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            int absoluteNumber = Math.Abs(number);

            while (absoluteNumber > 0)
            {
                int lastDigit = absoluteNumber % 10;

                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                absoluteNumber = absoluteNumber / 10;
            }
            return sum;
        }
    }
}