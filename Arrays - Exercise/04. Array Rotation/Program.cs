using System.ComponentModel.DataAnnotations;

int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int firstNumber = numbers[0];

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    for (int x = 0; x < numbers.Length - 1; x++)
    {
        numbers[x] = numbers[x + 1];
    }
    numbers[numbers.Length - 1] = firstNumber;
    firstNumber = numbers[0];
}

for (int j = 0; j < numbers.Length; j++)
{
    Console.Write(numbers[j] + " ");
}