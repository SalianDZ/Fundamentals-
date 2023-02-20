double neededExperience = double.Parse(Console.ReadLine());
int battlesCount = int.Parse(Console.ReadLine());
double experienceSum = 0;
int battleCounter = 0;

for (int i = 1; i <= battlesCount; i++)
{
    battleCounter++;
    int currentExperience = int.Parse(Console.ReadLine());
    experienceSum += currentExperience;

    if (i % 3 == 0)
    {
        experienceSum += currentExperience * 0.15;
    }
    if (i % 5 == 0)
    {
        experienceSum -= currentExperience * 0.10;
    }
    if (i % 15 == 0)
    {
        experienceSum += currentExperience * 0.05;
    }
    if (experienceSum >= neededExperience)
    {
        Console.WriteLine($"Player successfully collected his needed experience for {battleCounter} battles.");
        return;
    }
}
if (experienceSum < neededExperience)
{
    Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience - experienceSum:f2} more needed.");
}