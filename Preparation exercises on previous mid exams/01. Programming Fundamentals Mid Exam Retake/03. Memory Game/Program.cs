using System.Xml;

List<string> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
int movesCounter = 0;

while (input[0] != "end")
{
    int firstIndex = int.Parse(input[0]);
    int secondIndex = int.Parse(input[1]);

    movesCounter++;

    if ((firstIndex == secondIndex) || (firstIndex < 0 || firstIndex > numbers.Count - 1) || (secondIndex < 0 || secondIndex > numbers.Count - 1))
    {
        int middleIndex = numbers.Count / 2;

        numbers.Insert(middleIndex, $"-{movesCounter}a");
        numbers.Insert(middleIndex, $"-{movesCounter}a");
        Console.WriteLine("Invalid input! Adding additional elements to the board");
        input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        continue;
    }

    if (numbers[firstIndex] == numbers[secondIndex])
    {
        Console.WriteLine($"Congrats! You have found matching elements - {numbers[firstIndex]}!");

        if (firstIndex > secondIndex)
        {
            numbers.RemoveAt(firstIndex);
            numbers.RemoveAt(secondIndex);
        }
        else
        {
            numbers.RemoveAt(secondIndex);
            numbers.RemoveAt(firstIndex);
        }
    }
    else
    {
        Console.WriteLine("Try again!");
    }

    if (numbers.Count == 0)
    {
        Console.WriteLine($"You have won in {movesCounter} turns!");
        return;
    }
    input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
}

Console.WriteLine("Sorry you lose :(");
Console.WriteLine(String.Join(" ", numbers));