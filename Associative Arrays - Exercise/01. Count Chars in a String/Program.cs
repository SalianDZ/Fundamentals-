string words = Console.ReadLine();
List<char> charsInWord = new List<char>(words);
Dictionary<char, int> dictionary = new Dictionary<char, int>();

for (int i = 0; i < charsInWord.Count; i++)
{
    if (charsInWord[i] == ' ')
    {
        continue;
    }
	if (!dictionary.ContainsKey(charsInWord[i]))
	{
        dictionary[charsInWord[i]] = 0;
    }

    dictionary[charsInWord[i]]++;
}

foreach (var (key, item) in dictionary)
{
    Console.WriteLine($"{key} -> {item}");
}