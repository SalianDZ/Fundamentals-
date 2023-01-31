int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int leftSum = 0;
int rightSum = 0;
bool isTrue = false;
int currentIndex = 0;

for (int i = 0; i < numbers.Length; i++)
{
	leftSum = 0;
	rightSum = 0;
	currentIndex = i;
	if (i == 0)
	{
		leftSum = 0;
	}
	else
	{
        for (int j = 0; j < i; j++)
        {
            leftSum += numbers[j];
        }
    }
	
	for (int z = i + 1; z < numbers.Length; z++)
	{
		rightSum += numbers[z];
	}

    if (leftSum == rightSum)
    {
        isTrue = true;
		break;
    }
}

if (isTrue)
{
	Console.WriteLine(currentIndex);
}
else
{
	Console.WriteLine("no");
}