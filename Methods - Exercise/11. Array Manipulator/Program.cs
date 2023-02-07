using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _11._Array_Manipulator
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
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else
                {
                    if (command.StartsWith("exchange"))
                    {
                        int index = int.Parse(command.Split().Last());
                        if (index >= numbers.Length || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        int firstDigit = 0; 

                        for (int i = 0; i < index + 1; i++)
                        {
                            firstDigit = numbers[0];
                            for (int j = 0; j < numbers.Length - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Length - 1] = firstDigit;
                        }

                    }
                    else if (command.StartsWith("max"))
                    {
                        if (command.EndsWith("even"))
                        {
                            int greatestEvenNumberIndex = 0;
                            int greatestEvenNumber = int.MinValue;
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] >= greatestEvenNumber && numbers[i] % 2 == 0)
                                {
                                    greatestEvenNumber = numbers[i];
                                    greatestEvenNumberIndex = i;
                                }
                            }
                            if (greatestEvenNumber == int.MinValue)
                            {
                                Console.WriteLine("No matches");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine(greatestEvenNumberIndex);
                                continue;
                            }
                        }
                        else if (command.EndsWith("odd"))
                        {
                            int greatestOddNumberIndex = 0;
                            int greatestOddNumber = int.MinValue;
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] >= greatestOddNumber && numbers[i] % 2 != 0)
                                {
                                    greatestOddNumberIndex = i;
                                    greatestOddNumber = numbers[i];
                                }
                            }
                            if (greatestOddNumber == int.MinValue)
                            {
                                Console.WriteLine("No matches");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine(greatestOddNumberIndex);
                                continue;
                            }
                        }
                    }
                    else if (command.StartsWith("min"))
                    {
                        if (command.EndsWith("even"))
                        {
                            int smallestEvenNumberIndex = 0;
                            int smallestEvenNumber = int.MaxValue;
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] <= smallestEvenNumber && numbers[i] % 2 == 0)
                                {
                                    smallestEvenNumberIndex = i;
                                    smallestEvenNumber = numbers[i];
                                }
                            }
                            if (smallestEvenNumber == int.MaxValue)
                            {
                                Console.WriteLine("No matches");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine(smallestEvenNumberIndex);
                                continue;
                            }
                        }
                        else if (command.EndsWith("odd"))
                        {
                            int smallestOddNumberIndex = 0;
                            int smallestOddNumber = int.MaxValue;
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] <= smallestOddNumber && numbers[i] % 2 != 0)
                                {
                                    smallestOddNumberIndex = i;
                                    smallestOddNumber = numbers[i];
                                }
                            }
                            if (smallestOddNumber == int.MaxValue)
                            {
                                Console.WriteLine("No matches");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine(smallestOddNumberIndex);
                                continue;
                            }
                        }
                    }
                    else if (command.StartsWith("first"))
                    {
                        string countAsString = Regex.Match(command, @"\d+").Value;
                        int count = Int32.Parse(countAsString);
                        List<int> firstEvenNumbers = new List<int>();
                        List<int> firstOddNumbers = new List<int>();
                        if (count > numbers.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        int counter = 0;

                        if (command.EndsWith("even"))
                        {
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] % 2 == 0)
                                {
                                    counter++;
                                    firstEvenNumbers.Add(numbers[i]);
                                }
                                if (counter == count)
                                {
                                    break;
                                }
                            }
                            if (counter > 0)
                            {
                                Console.WriteLine($"[{string.Join(", ", firstEvenNumbers)}]");
                            }
                            else
                            {
                                Console.WriteLine("[]");
                                continue;
                            }
                        }
                        else if (command.EndsWith("odd"))
                        {
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] % 2 != 0)
                                {
                                    counter++;
                                    firstOddNumbers.Add(numbers[i]);
                                }
                                if (counter == count)
                                {
                                    break;
                                }
                            }
                            if (counter > 0)
                            {
                                Console.WriteLine($"[{string.Join(", ", firstOddNumbers)}]");
                            }
                            else
                            {
                                Console.WriteLine("[]");
                                continue;
                            }
                        }
                    }
                    else if (command.StartsWith("last"))
                    {
                        string countAsString = Regex.Match(command, @"\d+").Value;
                        int count = Int32.Parse(countAsString);
                        int counter = 0;

                        List<int> lastEvenNumbers = new List<int>();
                        List<int> lastOddNumbers = new List<int>();

                        if (count > numbers.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }

                        if (command.EndsWith("even"))
                        {
                            for (int i = numbers.Length - 1; i >= 0; i--)
                            {
                                if (numbers[i] % 2 == 0)
                                {
                                    counter++;
                                    lastEvenNumbers.Add(numbers[i]);
                                }
                                if (counter == count)
                                {
                                    break;
                                }
                            }
                            lastEvenNumbers.Reverse();
                            if (counter > 0)
                            {
                                Console.WriteLine($"[{string.Join(", ", lastEvenNumbers)}]");
                            }
                            else
                            {
                                Console.WriteLine("[]");
                                continue;
                            }
                        }
                        else if (command.EndsWith("odd"))
                        {
                            for (int i = numbers.Length - 1; i >= 0; i--)
                            {
                                if (numbers[i] % 2 != 0)
                                {
                                    counter++;
                                    lastOddNumbers.Add(numbers[i]);
                                }
                                if (counter == count)
                                {
                                    break;
                                }
                            }
                            lastOddNumbers.Reverse();
                            if (counter > 0)
                            {
                                Console.WriteLine($"[{string.Join(", ", lastOddNumbers)}]");
                            }
                            else
                            {
                                Console.WriteLine("[]");
                                continue;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}