List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> result = new List<int>();

for (int i = 0; i < numbers.Count / 2; i++)
{
    int currentSum = numbers[i] + numbers[numbers.Count - 1 - i];
    result.Add(currentSum);
}
if (numbers.Count % 2 != 0)
{
    Console.WriteLine(string.Join(" ", result) + " " + numbers[numbers.Count / 2]);
}
else
{
    Console.WriteLine(string.Join(" ", result));
}