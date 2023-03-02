Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

while (true)
{
    string[] currentCourse = Console.ReadLine()
        .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (currentCourse[0] == "end")
    {
        break;
    }

    string courseName = currentCourse[0];
    string currentUser = currentCourse[1];

    if (!courses.ContainsKey(courseName))
    {
        courses[courseName] = new List<string>();
    }
    courses[courseName].Add(currentUser);
}

foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");
    for (int i = 0; i < course.Value.Count; i++)
    {
        Console.WriteLine($"-- {course.Value[i]}");
    }
}