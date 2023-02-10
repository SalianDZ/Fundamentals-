List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string[] command = Console.ReadLine().Split();

	if (command[0] == "end")
	{
		break;
	}
	else if (command[0] == "Delete")
	{
		int element = int.Parse(command[1]);
		int v = numbers.RemoveAll(x => x == element);
	}
	else if (command[0] == "Insert")
	{
		int element = int.Parse(command[1]);
		int position = int.Parse(command[2]);

		numbers.Insert(position, element);
	}
}

Console.WriteLine(string.Join(" ", numbers));