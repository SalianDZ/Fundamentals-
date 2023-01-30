using System.Globalization;

int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] condensed = new int [numbers.Length];

for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = 0; j < numbers.Length - 1 - i; j++)
    {
        numbers[j] = numbers[j] + numbers[j + 1];
    }
}

Console.WriteLine(numbers[0]);
