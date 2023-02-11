string[] input = Console.ReadLine().Split("|");
List<int> result = new List<int>();

for (int i = input.Length - 1; i >= 0; i--)
{
    List<int> trimmedNums = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
    result.AddRange(trimmedNums);
}

Console.WriteLine(String.Join(" ", result));