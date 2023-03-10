using System.Text;

string word = Console.ReadLine();
StringBuilder sb = new StringBuilder();

for (int i = 1; i < word.Length; i++)
{
    char previousChar = word[i - 1];

	if (previousChar == word[i])
	{
		continue;
	}
	else
	{
		sb.Append(previousChar);
	}
}
sb.Append(word[word.Length - 1]);
Console.WriteLine(sb);