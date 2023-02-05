using System;
namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            bool isDivisibleByEight = false;
            bool hasOddDigit = false;

            for (int i = 8; i <= n; i++)
            {
                int iCopy = i;
                string iAsString = i.ToString();
                for (int j = 0; j < iAsString.Length; j++)
                {
                    int currentDigit = iCopy % 10;
                    if (currentDigit % 2 != 0)
                    {
                        hasOddDigit = true;
                    }
                    sumOfDigits = sumOfDigits + currentDigit;
                    iCopy = iCopy / 10;
                }

                if (sumOfDigits % 8 == 0)
                {
                    isDivisibleByEight = true;
                }
                sumOfDigits = 0;

                if (isDivisibleByEight == true && hasOddDigit == true)
                {
                    Console.WriteLine(i);
                }
                hasOddDigit = false;
                isDivisibleByEight = false;
            }
        }
    }
}