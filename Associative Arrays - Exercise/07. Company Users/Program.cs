using System.Reflection.Metadata;

bool isContained = false;
Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

while (true)
{
    string[] input = Console.ReadLine()
        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (input[0] == "End")
    {
        break;
    }
    string companyName = input[0];
    string employeeId = input[1];

    if (!companies.ContainsKey(companyName))
    {
        companies[companyName] = new List<string>();
    }

    //foreach (var (key, value) in companies.Where(x => x.Key == companyName))
    //{
    //    if (value.ToString() == employeeId)
    //    {
    //        isContained = true;
    //        break;
    //    }
    //}

    if (!isContained)
    {
        companies[companyName].Add(employeeId);
    }
}

foreach (var item in companies)
{
    Console.WriteLine(item.Key);
    foreach (var member in item.Value.Distinct())
    {
        Console.WriteLine($"-- {member}");
    }
}


