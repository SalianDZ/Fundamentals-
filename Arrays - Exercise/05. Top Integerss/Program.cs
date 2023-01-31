using System.Diagnostics.Metrics;

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int counter = 0;
int bestCounter = 0;
bool isGreater = false;

for (int i = 0; i < numbers.Length; i++)
{
	for (int j = i + 1; j < numbers.Length; j++)
	{
		if (numbers[i] > numbers[j])
		{
			counter++;
		}
		else
		{
			break;
		}
	}
	if (counter == numbers.Length - 1 - i)
	{ 
		isGreater = true;
		Console.Write(numbers[i] + " ");
	}
	isGreater = false;
	counter = 0;
}
;