using System.Linq;

while (true)
{
    string currentWord = Console.ReadLine();
	List<char> reversedWord = new List<char>();

	if (currentWord == "end")
	{
		break;
	}

	for (int i = 0; i < currentWord.Length; i++)
	{
		reversedWord.Insert(0 , currentWord[i]);
	}

	Console.WriteLine($"{currentWord} = {string.Join("", reversedWord)}");
}
