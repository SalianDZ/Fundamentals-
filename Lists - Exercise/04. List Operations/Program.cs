List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string[] command = Console.ReadLine().Split();

	if (command[0] == "End")
	{
		break;
	}
	else if (command[0] == "Add")
	{
		int number = int.Parse(command[1]);

		numbers.Add(number);
	}
	else if (command[0] == "Insert")
	{
		int number = int.Parse(command[1]);
		int index = int.Parse(command[2]);
        if (index > numbers.Count - 1)
        {
			Console.WriteLine("Invalid index");
			continue;
        }
        numbers.Insert(index, number);
    }
	else if (command[0] == "Remove")
	{
		int index = int.Parse(command[1]);

        if (index > numbers.Count - 1)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
		
        numbers.RemoveAt(index);
    }
	else if (command[0] == "Shift")
	{
		if (command[1] == "right")
		{
			int count = int.Parse(command[2]);
			for (int i = 0; i < count; i++)
			{
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
		}
		else
		{
            int count = int.Parse(command[2]);

			for (int i = 0; i < count; i++)
			{
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }
	}
}

Console.WriteLine(String.Join(" ", numbers));