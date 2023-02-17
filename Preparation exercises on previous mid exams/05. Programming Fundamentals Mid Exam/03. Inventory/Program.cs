using System.Net.Http.Headers;

List<string> items = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();

while (true)
{
    string[] command = Console.ReadLine().Split(" - ").ToArray();

	if (command[0] == "Craft!")
	{
		break;
	}
	else if (command[0] == "Collect")
	{
		string item = command[1];
		if (!items.Contains(item))
		{
			items.Add(item);
		}
	}
    else if (command[0] == "Drop")
    {
        string item = command[1];
        if (items.Contains(item))
        {
            items.Remove(item);
        }
    }
	else if (command[0] == "Combine Items")
	{
		string bothItems = command[1];
		string[] bothItemsSeparated = bothItems.Split(":");
		string oldItem = bothItemsSeparated[0];
		int indexOfOldItem = items.IndexOf(oldItem);
		string newItem = bothItemsSeparated[1];

        if (items.Contains(oldItem))
        {
			items.Insert(indexOfOldItem + 1, newItem);
        }
    }
	else if (command[0] == "Renew")
	{
        string item = command[1];

        if (items.Contains(item))
        {
			items.Remove(item);
            items.Add(item);
        }
    }
}
Console.WriteLine(String.Join(", ", items));