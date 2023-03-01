int n = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> wordsWithSynonims = new Dictionary<string, List<string>>();

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonim = Console.ReadLine();

    if (!wordsWithSynonims.ContainsKey(word))
    {
        wordsWithSynonims[word] = new List<string>();
    }

    wordsWithSynonims[word].Add(synonim);
}

foreach (var currentWord in wordsWithSynonims)
{
    Console.WriteLine($"{currentWord.Key} - {string.Join(", ", currentWord.Value)}");
}