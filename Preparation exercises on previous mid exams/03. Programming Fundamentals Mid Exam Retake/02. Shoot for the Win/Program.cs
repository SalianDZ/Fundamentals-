List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> shotTargets = new List<int>();

while (true)
{
    string input = Console.ReadLine();

	if (input == "End")
	{
		break;
	}
	int index = int.Parse(input);

	if (index >= 0 && index < targets.Count)
	{
        int currentNumber = targets[index];
        targets[index] = -1;
		shotTargets.Add(currentNumber);

		for (int i = 0; i < targets.Count; i++)
		{
			if (targets[i] == -1)
			{
				continue;
			}
			if (targets[i] > currentNumber)
			{
				targets[i] -= currentNumber;
			}
			else
			{
                targets[i] += currentNumber;
            }
		}
	}
}
Console.WriteLine($"Shot targets: {shotTargets.Count} -> {string.Join(" ", targets)}");