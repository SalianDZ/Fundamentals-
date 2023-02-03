using System;
namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int greaterValue = GetMax(a,b);
                Console.WriteLine(greaterValue);

            }
            else if (dataType == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string greaterValue = GetMax(a,b);
                Console.WriteLine(greaterValue);
            }
            else if (dataType == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char greaterValue = (char)GetMax(a, b);
                Console.WriteLine(greaterValue);
            }
        }
        static int GetMax(int a, int b)
        { 
            int greaterValue = Math.Max(a,b);
            return greaterValue;
        }
        static string GetMax(string a, string b)
        {
            int greaterValue = a.CompareTo(b);

            if (greaterValue == -1)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static int GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}