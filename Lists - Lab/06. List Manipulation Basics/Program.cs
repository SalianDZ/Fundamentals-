using System.Globalization;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
	string[] input = Console.ReadLine().Split();

	if (input[0] == "end")
	{
		break;
	}
	else if (input[0] == "Add")
	{
		int currentNumber = int.Parse(input[1]);
		numbers.Add(currentNumber);
	}
	else if (input[0] == "Remove")
	{
		int number = int.Parse(input[1]);
		numbers.Remove(number);
	}
	else if (input[0] == "RemoveAt")
	{
		int index = int.Parse(input[1]);
		numbers.RemoveAt(index);
	}
	else if (input[0] == "Insert")
	{
		int number = int.Parse(input[1]);
		int index = int.Parse(input[2]);
		numbers.Insert(index, number);
	}
}
Console.WriteLine(String.Join(" ", numbers));