using System;
using System.Globalization;

List<string> strings = Console.ReadLine().Split().ToList();
string[] array = strings.ToArray();

while (true)
{
    string[] input = Console.ReadLine().Split();
	if (input[0] == "3:1")
	{
		break;
	}
	else if (input[0] == "merge")
	{
		int startIndex = int.Parse(input[1]);
		int endIndex = int.Parse(input[2]);

		if (startIndex < 0)
		{
			startIndex = 0;
		}
		if (startIndex > strings.Count - 1)
		{
            startIndex = strings.Count - 1;
        }
		if (endIndex > strings.Count - 1)
		{
			endIndex = strings.Count - 1;

        }

		int counter = 0;
		string combinedWords = string.Empty;

		for (int i = startIndex; i <= endIndex; i++)
		{
			combinedWords += strings[i];
			counter++;
		}
		strings.RemoveRange(startIndex, counter);
		counter = 0;
		strings.Insert(startIndex, combinedWords);
		combinedWords = string.Empty;
		array = strings.ToArray();
    }
	else if (input[0] == "divide")
	{
		int index = int.Parse(input[1]);
		int partitions = int.Parse(input[2]);

        // Divide the string at the specified index into equal-length substrings
        string[] divided = divideString(array[index], partitions);

        // Replace the original string with the divided substrings
        array = array.Take(index).Concat(divided).Concat(array.Skip(index + 1)).ToArray();
    }
}
Console.WriteLine(string.Join(" ", array));

static string[] divideString(string s, int partitions)
{
	// Calculate the length of each partition
	int partitionLength = s.Length / partitions;

	// Divide the string into equal-length partitions
	string[] divided = new string[partitions];
	for (int i = 0; i < partitions; i++)
	{
		divided[i] = s.Substring(i * partitionLength, partitionLength);
	}

	// If the string could not be exactly divided into the given number of partitions,
	// make the last partition longer to compensate
	if (s.Length % partitions != 0)
	{
		divided[partitions - 1] += s.Substring(partitions * partitionLength);
	}

	return divided;
}
