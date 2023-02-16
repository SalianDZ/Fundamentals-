using System.Linq.Expressions;

List<string> products = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

while (true)
{
    string[] command = Console.ReadLine().Split().ToArray();
	if (command[0] == "Go")
	{
		break;
	}
	else if (command[0] == "Urgent")
	{
		string currentProduct = command[1];

		if (!products.Contains(currentProduct))
		{
            products.Insert(0, currentProduct);
        }
	}
	else if (command[0] == "Unnecessary")
    {
        string currentProduct = command[1];
        if (products.Contains(currentProduct))
        {
            products.Remove(currentProduct);
        }
    }
	else if (command[0] == "Correct")
	{
		string oldItem = command[1];
		string newItem = command[2];

        if (products.Contains(oldItem))
        {
			int indexOfOldItem = products.IndexOf(oldItem);
			products[indexOfOldItem] = newItem;	
        }
    }
	else if (command[0] == "Rearrange")
	{
        string currentProduct = command[1];

        if (products.Contains(currentProduct))
        {
			products.Remove(currentProduct);
			products.Add(currentProduct);
        }
    }
}
Console.WriteLine(string.Join(", ", products));
