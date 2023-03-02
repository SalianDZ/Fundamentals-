int n = int.Parse(Console.ReadLine());
Dictionary<string, string> registrations = new Dictionary<string, string>();	

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
	string name = command[1];

	if (command[0] == "register")
	{
		string licensePlateNumber = command[2];

		if (registrations.ContainsKey(name))
		{
			Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
			continue;
		}
		registrations[name] = licensePlateNumber;
		Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
	}
	else if (command[0] == "unregister")
	{
		if (!registrations.ContainsKey(name))
		{
			Console.WriteLine($"ERROR: user {name} not found");
			continue;
		}

		registrations.Remove(name);
		Console.WriteLine($"{name} unregistered successfully");
	}
}

foreach (var (key, value) in registrations)
{
	Console.WriteLine($"{key} => {value}");
}