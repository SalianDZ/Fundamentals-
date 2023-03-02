Dictionary<string, int> ores = new Dictionary<string, int>();

while (true)
{
    string ore = Console.ReadLine();
	if (ore == "stop")
	{
		break;
	}
	int oreValue = int.Parse(Console.ReadLine());

	if (!ores.ContainsKey(ore))
	{
		ores[ore] = oreValue;
	}
	else
	{
		ores[ore] += oreValue;
	}
}

foreach (var (key, value) in ores)
{
	Console.WriteLine($"{key} -> {value}");
}