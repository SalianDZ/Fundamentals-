using System.Security.Cryptography.X509Certificates;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
double average = numbers.Average();
List<int> greaterThanAverage = new List<int>();
int counter = 0;
int iCounter = 0;

for (int i = 0; i < numbers.Count; i++)
{
	if (numbers[i] > average)
	{
		greaterThanAverage.Add(numbers[i]);
		counter++;
	}
}

if (greaterThanAverage.Count > 0)
{
	greaterThanAverage.Sort();
	greaterThanAverage.Reverse();

	for (int i = 0; i < greaterThanAverage.Count; i++)
	{
		Console.Write(greaterThanAverage[i] + " ");
		iCounter++;
		if (iCounter == 5)
		{
			break;
		}
	}
}
else
{
	Console.WriteLine("No");
}
