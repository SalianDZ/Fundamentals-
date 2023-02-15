int initialEnergy = int.Parse(Console.ReadLine());
int counter = 0;

while (true)
{
	if (initialEnergy < 0)
	{
        Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {initialEnergy} energy");
        break;
	}
    string input = Console.ReadLine();

    if (input == "End of battle")
	{
        Console.WriteLine($"Won battles: {counter}. Energy left: {initialEnergy}");
        break;
	}
    else
    {
        int distance = int.Parse(input);
        if (initialEnergy - distance < 0)
        {
            Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {initialEnergy} energy");
            break;
        }
        else
        {
            counter++;
            initialEnergy -= distance;
            if (counter % 3 == 0)
            {
                initialEnergy += counter;
            }
        }
    }
}
