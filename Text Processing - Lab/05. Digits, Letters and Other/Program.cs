string word = Console.ReadLine();
string digits = string.Empty;
string letters = string.Empty;
string symbols = string.Empty;

for (int i = 0; i < word.Length; i++)
{
	if (word[i] >= '0' && word[i] <= '9')
	{
		digits += word[i];
	}
	else if ((word[i] >= 'a' && word[i] <= 'z')
		|| (word[i] >= 'A' && word[i] <= 'Z'))
	{
		letters += word[i];
	}
	else
	{
		symbols += word[i];
	}
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(symbols);