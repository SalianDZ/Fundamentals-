string[] words = Console.ReadLine().Split();
string stringOne = words[0];
string stringTwo = words[1];
CharacterMultiplier(stringOne, stringTwo);




void CharacterMultiplier(string stringOne, string stringTwo)
{
	int sum = 0;
    int minLenght = Math.Min(stringOne.Length, stringTwo.Length);
	int maxLength = Math.Max(stringOne.Length, stringTwo.Length);

	for (int i = 0; i < minLenght; i++)
	{
		sum += stringOne[i] * stringTwo[i]; 
	}


	if (maxLength == stringOne.Length)
	{
        for (int i = minLenght; i < maxLength; i++)
        {
			sum += stringOne[i];
        }
    }
	else if (maxLength == stringTwo.Length)
	{
        for (int i = minLenght; i < maxLength; i++)
        {
			sum += stringTwo[i];
        }
    }

	Console.WriteLine(sum);
}