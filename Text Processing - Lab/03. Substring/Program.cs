string wordToRemove = Console.ReadLine();
string word = Console.ReadLine();

while (word.Contains(wordToRemove))
{
    int startIndex = word.IndexOf(wordToRemove);
    word = word.Remove(startIndex, wordToRemove.Length);
}

Console.WriteLine(word);