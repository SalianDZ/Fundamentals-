List<string> words = Console.ReadLine()
    .Split()
    .ToList();

Dictionary<string, int> wantedWords = new Dictionary<string, int>();

foreach (string word in words)
{ 
    string wordToLower = word.ToLower();

    if (!wantedWords.ContainsKey(wordToLower))
    {
        wantedWords.Add(wordToLower, 0);
    }

    wantedWords[wordToLower]++;
}

foreach (var word in wantedWords)
{
    if (word.Value % 2 != 0)
    {
        Console.Write(word.Key + " ");
    }
}

