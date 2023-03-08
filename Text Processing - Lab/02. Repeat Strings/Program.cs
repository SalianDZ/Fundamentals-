string[] words = Console.ReadLine().Split();
string result = string.Empty;

foreach (var word in words)
{
    int wordLenght = word.Length;
	for (int i = 0; i < wordLenght; i++)
	{
		result += word;
	}
}
Console.WriteLine(result);