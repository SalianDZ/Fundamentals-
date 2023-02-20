List<string> coffeeList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
int numberOfCommands = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfCommands; i++)
{
	string[] currentCommand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


	if (currentCommand[0] == "Include")
	{
		string coffeeName = currentCommand[1];
		coffeeList.Add(coffeeName);
	}
	else if (currentCommand[0] == "Remove")
	{
		int numberOfCoffees = int.Parse(currentCommand[2]);

		if (currentCommand[1] == "first")
		{
			int startIndex = 0;
			if (numberOfCoffees <= coffeeList.Count)
			{

                coffeeList.RemoveRange(startIndex, numberOfCoffees);
            }
        }
		else if (currentCommand[1] == "last")
		{
			int startIndex = (coffeeList.Count - 1) - (numberOfCoffees - 1);

			if (numberOfCoffees <= coffeeList.Count)
			{
                coffeeList.RemoveRange(startIndex, numberOfCoffees);
            }

		}
	}
	else if (currentCommand[0] == "Prefer")
	{
		int firstCoffeeIndex = int.Parse(currentCommand[1]);
        int secondCoffeeIndex = int.Parse(currentCommand[2]);

		if ((firstCoffeeIndex >= 0 && firstCoffeeIndex <= coffeeList.Count - 1) && (secondCoffeeIndex >= 0 && secondCoffeeIndex <= coffeeList.Count -1))
		{
			string firstCoffeeName = coffeeList[firstCoffeeIndex];
			string secondCoffeeName = coffeeList[secondCoffeeIndex];

			coffeeList[firstCoffeeIndex] = secondCoffeeName;
			coffeeList[secondCoffeeIndex] = firstCoffeeName;
        }
    }
	else if (currentCommand[0] == "Reverse")
	{
		coffeeList.Reverse();
	}
}

Console.WriteLine("Coffees:");
Console.WriteLine(string.Join(" ", coffeeList));