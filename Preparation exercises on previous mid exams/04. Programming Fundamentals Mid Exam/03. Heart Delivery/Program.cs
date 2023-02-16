List<int> numbers = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int length = 0;
int startingIndex = 0;
int currentIndex = 0;

while (true)
{
    string[] command = Console.ReadLine().Split().ToArray();

    if (command[0] == "Love!")
	{
		break;
	}
	else
	{
		length = int.Parse(command[1]);
        currentIndex = startingIndex + length;

        if (currentIndex > numbers.Count - 1)
		{
			currentIndex = 0;
		}
	}

	if (numbers[currentIndex] > 0)
	{
		numbers[currentIndex] -= 2;
		if (numbers[currentIndex] <= 0)
		{
			Console.WriteLine($"Place {currentIndex} has Valentine's day.");
		}
	}
	else if (numbers[currentIndex] <= 0)
	{
		Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
	}
	startingIndex = currentIndex;
}
Console.WriteLine($"Cupid's last position was {currentIndex}.");

int zeroCounter = 0;
int onesCounter = 0;
foreach (var item in numbers)
{
	if (item <= 0)
	{
		zeroCounter++;
	}
	else
	{
		onesCounter++;
	}
}

if (zeroCounter == numbers.Count)
{
	Console.WriteLine("Mission was successful.");
}
else
{
	Console.WriteLine($"Cupid has failed {onesCounter} places.");
}

