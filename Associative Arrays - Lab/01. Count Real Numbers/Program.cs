List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
SortedDictionary<int, int> orderedNumbers = new SortedDictionary<int, int>();

foreach (var number in numbers)
{
	if (!orderedNumbers.ContainsKey(number))
	{
		orderedNumbers[number] = 0;
	}

	orderedNumbers[number]++;
}

foreach (var (key, value) in orderedNumbers)
{
	Console.WriteLine($"{key} -> {value}");
}