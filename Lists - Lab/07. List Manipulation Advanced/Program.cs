using System.Globalization;
using System.Reflection;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
bool isChanged = false;

while (true)
{
    string[] input = Console.ReadLine().Split();

    if (input[0] == "end")
    {
        break;
    }
    else if (input[0] == "Add")
    {
        int currentNumber = int.Parse(input[1]);
        numbers.Add(currentNumber);
        isChanged = true;
    }
    else if (input[0] == "Remove")
    {
        int number = int.Parse(input[1]);
        numbers.Remove(number);
        isChanged = true;
    }
    else if (input[0] == "RemoveAt")
    {
        int index = int.Parse(input[1]);
        numbers.RemoveAt(index);
        isChanged = true;
    }
    else if (input[0] == "Insert")
    {
        int number = int.Parse(input[1]);
        int index = int.Parse(input[2]);
        numbers.Insert(index, number);
        isChanged = true;
    }
    else if (input[0] == "Contains")
    {
        int number = int.Parse(input[1]);
        bool isFound = numbers.Contains(number);
        if (isFound)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (input[0] == "PrintEven")
    {
        Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 == 0)));
    }
    else if (input[0] == "PrintOdd")
    {
        Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 != 0)));
    }
    else if (input[0] == "GetSum")
    {
        Console.WriteLine(numbers.Sum()); ;
    }
    else if (input[0] == "Filter")
    {
        string condition = input[1];
        int number = int.Parse(input[2]);
        if (condition == "<")
        {
            Console.WriteLine(String.Join(" ", numbers.Where(x => x < number)));
        }
        else if (condition == ">")
        {
            Console.WriteLine(String.Join(" ", numbers.Where(x => x > number)));
        }
        else if (condition == ">=")
        {
            Console.WriteLine(String.Join(" ", numbers.Where(x => x >= number)));
        }
        else if (condition == "<=")
        {
            Console.WriteLine(String.Join(" ", numbers.Where(x => x <= number)));
        }
    }
}

if (isChanged)
{
    Console.WriteLine(String.Join(" ", numbers));
}