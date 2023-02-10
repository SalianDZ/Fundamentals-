List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCapacity = int.Parse(Console.ReadLine());

while (true)
{
    string[] input = Console.ReadLine().Split();

	if (input[0] == "end")
	{
		break;
	}
	else if (input[0] == "Add")
	{
		int passengers = int.Parse(input[1]);
		wagons.Add(passengers);
	}
	else if (input.Length == 1)
	{
		int passengers = int.Parse(input[0]);

		for (int i = 0; i < wagons.Count; i++)
		{
			if (wagons[i] + passengers <= maxCapacity)
			{
				wagons[i] += passengers;
				break;
			}
			else
			{
				continue;
			}
		}
	}
}

Console.WriteLine(String.Join(" ", wagons));