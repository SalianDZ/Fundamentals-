using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "end")
                {
                    break;
                }
                else if (input[0] == "swap")
                {
                    int firstIndex = int.Parse(input[1]);
                    int secondIndex = int.Parse(input[2]);

                    int firstIndexNumberFromArray = numbers[firstIndex];
                    int secondIndexNumberFromArray = numbers[secondIndex];

                    numbers[firstIndex] = secondIndexNumberFromArray;
                    numbers[secondIndex] = firstIndexNumberFromArray;
                }
                else if (input[0] == "multiply")
                {
                    int firstIndex = int.Parse(input[1]);
                    int secondIndex = int.Parse(input[2]);

                    numbers[firstIndex] = numbers[firstIndex] * numbers[secondIndex];
                }
                else if (input[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = numbers[i] - 1;
                    }
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}