int n = int.Parse(Console.ReadLine());
Dictionary<string, HeroStats> heros = new Dictionary<string, HeroStats>();

for (int i = 0; i < n; i++)
{
    string[] heroInfo = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string heroName = heroInfo[0];
    int heroHP = int.Parse(heroInfo[1]);
    int heroMP = int.Parse(heroInfo[2]);

    if (!heros.ContainsKey(heroName))
    {
        heros[heroName] = new HeroStats(heroHP, heroMP);
    }
}

while (true)
{
    string[] commandInfo = Console.ReadLine()
        .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (commandInfo[0] == "End")
    {
        break;
    }
    else if (commandInfo[0] == "Heal")
    {
        string heroName = commandInfo[1];
        int healAmount = int.Parse(commandInfo[2]);

        if (heros[heroName].HP + healAmount > 100)
        {
            Console.WriteLine($"{heroName} healed for {100 - heros[heroName].HP} HP!");
            heros[heroName].HP = 100;
            continue;
        }

        heros[heroName].HP += healAmount;
        Console.WriteLine($"{heroName} healed for {healAmount} HP!");
    }
    else if (commandInfo[0] == "Recharge")
    {
        string heroName = commandInfo[1];
        int manaAmount = int.Parse(commandInfo[2]);

        if (heros[heroName].MP + manaAmount > 200)
        {
            Console.WriteLine($"{heroName} recharged for {200 - heros[heroName].MP} MP!");
            heros[heroName].MP = 200;
            continue;
        }

        heros[heroName].MP += manaAmount;
        Console.WriteLine($"{heroName} recharged for {manaAmount} MP!");
    }
    else if (commandInfo[0] == "TakeDamage")
    {
        string heroName = commandInfo[1];
        int damage = int.Parse(commandInfo[2]);
        string attacker = commandInfo[3];

        if (heros[heroName].HP - damage <= 0)
        {
            Console.WriteLine($"{heroName} has been killed by {attacker}!");
            heros.Remove(heroName);
            continue;
        }

        heros[heroName].HP -= damage;
        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heros[heroName].HP} HP left!");
    }
    else if (commandInfo[0] == "CastSpell")
    {
        string heroName = commandInfo[1];
        int mpNeeded = int.Parse(commandInfo[2]);
        string spellName = commandInfo[3];

        if (heros[heroName].MP < mpNeeded)
        {
            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            continue;
        }

        heros[heroName].MP -= mpNeeded;
        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heros[heroName].MP} MP!");
    }
}

foreach (var hero in heros)
{
    Console.WriteLine($"{hero.Key}");
    Console.WriteLine($"  HP: {hero.Value.HP}");
    Console.WriteLine($"  MP: {hero.Value.MP}");
}


public class HeroStats
{
    public HeroStats(int hP, int mP)
    {
        HP = hP;
        MP = mP;
    }

    public int HP { get; set; }

    public int MP { get; set; }
}