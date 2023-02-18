using System;
using System.Reflection;

List<int> pirateShipStatus = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
List<int> warShipStatus = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int maximumHealth = int.Parse(Console.ReadLine());
int pirateShipSum = 0;
int warShipSum = 0;

while (true)
{
    string[] command = Console.ReadLine().Split().ToArray();

	if (command[0] == "Retire")
	{
		pirateShipSum = pirateShipStatus.Sum();
		warShipSum = warShipStatus.Sum();
		Console.WriteLine($"Pirate ship status: {pirateShipSum}");
		Console.WriteLine($"Warship status: {warShipSum}");
        break;
	}
	else if (command[0] == "Fire")
	{
		int index = int.Parse(command[1]);
		if (index >= 0 && index <= warShipStatus.Count - 1)
		{
			int damage = int.Parse(command[2]);
			warShipStatus[index] -= damage;

			if (warShipStatus[index] <= 0)
			{
				Console.WriteLine("You won! The enemy ship has sunken.");
				return;
			}
		}
	}
	else if (command[0] == "Defend")
	{
		int startIndex = int.Parse(command[1]);
		int endIndex = int.Parse(command[2]);

		if ((startIndex >= 0 && startIndex <= pirateShipStatus.Count - 1)
			&& (endIndex >= 0 && endIndex <= pirateShipStatus.Count - 1))
		{
			int damage = int.Parse(command[3]);

			for (int i = startIndex; i <= endIndex; i++)
			{
                pirateShipStatus[i] -= damage;

				if (pirateShipStatus[i] <= 0)
				{
					Console.WriteLine("You lost! The pirate ship has sunken.");
					return;
				}
            }
		}
	}
	else if (command[0] == "Repair")
	{
		int index = int.Parse(command[1]);

		if (index >= 0 && index <= pirateShipStatus.Count - 1)
		{
			int repairHealth = int.Parse(command[2]);
			pirateShipStatus[index] += repairHealth;

			if (pirateShipStatus[index] > maximumHealth)
			{
				pirateShipStatus[index] = maximumHealth;
			}
        }
	}
	else if (command[0] == "Status")
	{
		int sectionsThatNeedRepair = 0;
		for (int i = 0; i < pirateShipStatus.Count; i++)
		{
			if (pirateShipStatus[i] < (maximumHealth * 0.2))
			{
				sectionsThatNeedRepair++;

            }
		}
		Console.WriteLine($"{sectionsThatNeedRepair} sections need repair.");
	}
}
