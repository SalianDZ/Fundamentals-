using System;
namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int addResult = AddNumbers(firstNum, secondNum);
            int subtractionResult = SubtractNumbers(addResult, thirdNum);
            Console.WriteLine(subtractionResult);
        }

        static int AddNumbers(int firstNum, int secondNum)
        { 
            int result = firstNum + secondNum;
            return result;
        }

        static int SubtractNumbers(int addResult, int thirdNumber) 
        {
            int result = addResult - thirdNumber;
            return result;
        }
    }
}