using System;
namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (action == "add")
            {
                GetNumbersAdded(firstNum, secondNum);
            }
            else if (action == "multiply")
            {
                GetNumbersMultiplied(firstNum, secondNum);
            }
            else if (action == "subtract")
            {
                GetNumbersSubtracted(firstNum, secondNum);
            }
            else if (action == "divide")
            {
                GetNumbersDivived(firstNum, secondNum);
            }
        }
        
        static void GetNumbersAdded(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            Console.WriteLine(result);
        }

        static void GetNumbersMultiplied(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            Console.WriteLine(result);
        }

        static void GetNumbersSubtracted(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            Console.WriteLine(result);
        }

        static void GetNumbersDivived(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;
            Console.WriteLine(result);
        }
    }
}