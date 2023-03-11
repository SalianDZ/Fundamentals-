List<string> strings = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

decimal sum = 0;
int number = 0;

foreach (string currentString in strings)
{
    List<char> stringAsCharList = new List<char>();
    stringAsCharList.AddRange(currentString);

    string numberInTheString = string.Empty;
    for (int i = 0; i < stringAsCharList.Count; i++)
    {
        if (char.IsDigit(stringAsCharList[i]))
        {
            numberInTheString += stringAsCharList[i];
        }
    }
    number = int.Parse(numberInTheString);

    for (int i = 0; i < stringAsCharList.Count; i++)
    {
        int position = 0;
        if (char.IsUpper(stringAsCharList[i]) && char.IsLetter(stringAsCharList[i]))
        {
            position = stringAsCharList[i] - 64;
        }
        else if (char.IsLower(stringAsCharList[i]) && char.IsLetter(stringAsCharList[i]))
        {
            position = stringAsCharList[i] - 96;
        }

        if (i == 0)
        {
            if (char.IsUpper(stringAsCharList[0]) && char.IsLetter(stringAsCharList[0]))
            {
                if (position <= 0)
                {
                    position = 1;
                }
                sum += number / (position * 1.0m);
            }
            else if (char.IsLower(stringAsCharList[0]) && char.IsLetter(stringAsCharList[0]))
            {
                sum += number * position;
            }
            continue;
        }


        if (i == stringAsCharList.Count - 1)
        {
            if (char.IsUpper(stringAsCharList[i]) && char.IsLetter(stringAsCharList[i]))
            {
                sum -= position;
            }
            else if (char.IsLower(stringAsCharList[i]) && char.IsLetter(stringAsCharList[i]))
            {
                sum += position;
            }
        }
    }
}
Console.WriteLine($"{sum:f2}");