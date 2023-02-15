using System;
using System.Xml;

List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

while (true)
{
	string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

	if (input[0] == "End")
	{
		break;
	}
	else if (input[0] == "Shoot")
	{
		int index = int.Parse(input[1]);
		int power = int.Parse((input[2]));

		if (index >= 0 && index < targets.Count)
		{
			if (targets[index] - power <= 0)
			{
				targets.RemoveAt(index);
			}
			else
			{
                targets[index] -= power;
            }
		}
	}
	else if (input[0] == "Add")
	{
        int index = int.Parse(input[1]);
        int value = int.Parse((input[2]));
        if (index >= 0 && index < targets.Count)
		{
			targets.Insert(index, value);
        }
		else
		{
			Console.WriteLine("Invalid placement!");
		}
    }
	else if (input[0] == "Strike")
	{
        int index = int.Parse(input[1]);
        int radius = int.Parse((input[2]));
		int startIndex = index - radius;

		if (index - radius < 0 || index + radius > targets.Count - 1)
		{
			Console.WriteLine("Strike missed!");
		}
		else
		{
			targets.RemoveRange(startIndex, radius * 2 + 1);
		}
    }
}
Console.WriteLine(String.Join("|", targets));