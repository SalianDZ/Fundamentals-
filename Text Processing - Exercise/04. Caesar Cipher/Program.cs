string text = Console.ReadLine();
List<char> chars = new List<char>();

for (int i = 0; i < text.Length; i++)
{
    int currentCharInInt = text[i] + 3;
    char currentChar = (char) currentCharInInt;
    chars.Add(currentChar);
}

Console.WriteLine(String.Join("", chars));