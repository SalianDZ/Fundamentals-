List<string> phoneList = Console.ReadLine().Split(", ").ToList();

while (true)
{
    string[] currentCommand = Console.ReadLine().Split(" - ").ToArray();

	if (currentCommand[0] == "End")
	{
		break;
	}
	else if (currentCommand[0] == "Add")
	{
		string phoneName = currentCommand[1];

		if (!phoneList.Contains(phoneName))
		{
			phoneList.Add(phoneName);
		}
	}
	else if (currentCommand[0] == "Remove")
	{
        string phoneName = currentCommand[1];

        if (phoneList.Contains(phoneName))
        {
            phoneList.Remove(phoneName);
        }
    }
	else if (currentCommand[0] == "Bonus phone")
	{
		string bothPhones = currentCommand[1];
		string[] bothPhonesSeparated = bothPhones.Split(":").ToArray();
		string oldPhone = bothPhonesSeparated[0];
		string newPhone = bothPhonesSeparated[1];

		if (phoneList.Contains(oldPhone))
		{
			int indexOfOldPhone = phoneList.IndexOf(oldPhone);
			phoneList.Insert(indexOfOldPhone + 1, newPhone);
		}
    }
	else if (currentCommand[0] == "Last")
	{
		string phoneName = currentCommand[1];

		if (phoneList.Contains(phoneName))
		{
            phoneList.Remove(phoneName);
            phoneList.Add(phoneName);
        }
	}
}
Console.WriteLine(string.Join(", ", phoneList));
