int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int currentSpecialNumber = 0;
int counter = 0;
int bestCounter = 0;

for ( int i = 0; i < numbers.Length; i++)
{
	for (int j = 0 + i; j < numbers.Length - 1; j++)
	{
        if (numbers[i] == numbers[j])
        {
            counter++;
        }
		else
		{
			break;
		}
        if (numbers[i] == numbers[j + 1] && counter > bestCounter)
		{
			currentSpecialNumber = numbers[i];
			bestCounter++;
		}
	}
	counter = 0;
}
for (int i = 0; i <= bestCounter; i++)
{
	Console.Write(currentSpecialNumber + " ");
}
