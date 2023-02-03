using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string givenOperator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            double sum = OperationBetweenNumbers(firstNumber, givenOperator, secondNumber);
            Console.WriteLine(sum);

        }

        static double OperationBetweenNumbers(double firstNumber, string givenOperator, double secondNumber)
        {
            double sum = 0;
            if (givenOperator == "+")
            {
                sum = firstNumber + secondNumber;
            }
            else if (givenOperator == "-")
            {
                sum = firstNumber - secondNumber;
            }
            else if (givenOperator == "*")
            {
                sum = firstNumber * secondNumber;
            }
            else if (givenOperator == "/")
            {
                sum = firstNumber / secondNumber;
            }

            return sum;
        }
    }
}