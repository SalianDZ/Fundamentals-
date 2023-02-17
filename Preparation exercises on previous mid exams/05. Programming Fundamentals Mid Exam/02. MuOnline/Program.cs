int initialHealth = 100;
int initialBitcoins = 0;
int roomCounter = 0;
bool hasSurvived = true;
List<string> dungeonRooms = Console.ReadLine().Split("|").ToList();

for (int i = 0; i < dungeonRooms.Count; i++)
{
	roomCounter++;
	string[] currentCommand = dungeonRooms[i].Split(" ").ToArray();

	if (currentCommand[0] == "potion")
	{
		int commandHealth = int.Parse(currentCommand[1]);
		if (initialHealth + commandHealth > 100)
		{
            Console.WriteLine($"You healed for {100 - initialHealth} hp.");
            initialHealth = 100;
            Console.WriteLine($"Current health: {initialHealth} hp.");
        }
		else
		{
			initialHealth += commandHealth;
            Console.WriteLine($"You healed for {commandHealth} hp.");
            Console.WriteLine($"Current health: {initialHealth} hp.");
        }
	}
	else if (currentCommand[0] == "chest")
	{
		int commandBitcoins = int.Parse(currentCommand[1]);
		initialBitcoins += commandBitcoins;
		Console.WriteLine($"You found {commandBitcoins} bitcoins.");
    }
	else
	{
		string monsterName = currentCommand[0];
		int monsterAttackDamage = int.Parse(currentCommand[1]);

		if (initialHealth - monsterAttackDamage <= 0)
		{
			Console.WriteLine($"You died! Killed by {monsterName}.");
			Console.WriteLine($"Best room: {roomCounter}");
			hasSurvived = false;
			break;
        }
		else
		{
			initialHealth -= monsterAttackDamage;
			Console.WriteLine($"You slayed {monsterName}.");
        }

    }
}

if (hasSurvived)
{
	Console.WriteLine("You've made it!");
	Console.WriteLine($"Bitcoins: {initialBitcoins}");
	Console.WriteLine($"Health: {initialHealth}");
}

