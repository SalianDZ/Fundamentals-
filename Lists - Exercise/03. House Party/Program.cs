List<string> names = new List<string>();
int commandsNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < commandsNumber; i++)
{
    string[] input = Console.ReadLine().Split();

	if (input.Length == 3)
	{
		if (names.Contains(input[0]))
		{
			Console.WriteLine($"{input[0]} is already in the list!");
		}
		else
		{
			names.Add(input[0]);
		}

	}
	else if (input.Length == 4)
	{
        if (names.Contains(input[0]))
        {
			names.Remove(input[0]);
        }
		else if (!names.Contains(input[0]))
		{
			Console.WriteLine($"{input[0]} is not in the list!");
		}
    }
}

Console.WriteLine(String.Join(System.Environment.NewLine, names));