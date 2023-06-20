Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
string[] wordsWithDefinition = Console.ReadLine()
    .Split(" | ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < wordsWithDefinition.Length; i++)
{
    string[] currentWord = wordsWithDefinition[i]
        .Split(": ", StringSplitOptions.RemoveEmptyEntries);

    string currentWordName = currentWord[0];
    string currentWordDefinition = currentWord[1];

    if (!words.ContainsKey(currentWordName))
    {
        words[currentWordName] = new List<string>();
        words[currentWordName].Add(currentWordDefinition);
        continue;
    }

    words[currentWordName].Add(currentWordDefinition);
}

string[] examWords = Console.ReadLine()
    .Split(" | ", StringSplitOptions.RemoveEmptyEntries);

List<string> examWordsList = new List<string>();
foreach (string word in examWords)
{ 
    examWordsList.Add(word);
}

string command = Console.ReadLine();

if (command == "Test")
{
    foreach (var word in examWordsList)
    {
        if (words.ContainsKey(word))
        {
            Console.WriteLine($"{word}:");

            foreach (var item in words[word])
            {
                Console.WriteLine($" -{item}");
            }
        }
    }
}
else if (command == "Hand Over")
{
    Console.WriteLine(String.Join(" ", words.Keys));
}