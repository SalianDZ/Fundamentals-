using System;
using System.Linq;

List<string> subjects = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();


while (true)
{
    string[] inputCommand = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
    if (inputCommand[0] == "course start")
    {
        break;
    }
    else if (inputCommand[0] == "Add")
    {
        string lessonTitle = inputCommand[1];
        if (!subjects.Contains(lessonTitle))
        {
            subjects.Add(lessonTitle);
        }
    }
    else if (inputCommand[0] == "Insert")
    {
        string lessonTitle = inputCommand[1];
        int index = int.Parse(inputCommand[2]);

        if (index < 0 || index > subjects.Count - 1)
        {
            continue;
        }

        if (!subjects.Contains(lessonTitle))
        {
            subjects.Insert(index, lessonTitle);
        }
    }
    else if (inputCommand[0] == "Remove")
    {
        string lessonTitle = inputCommand[1];
        if (subjects.Contains(lessonTitle) && subjects.Contains($"{lessonTitle}-Exercise"))
        {
            subjects.Remove(lessonTitle);
            subjects.Remove($"{lessonTitle}-Exercise");
        }
        else if (subjects.Contains(lessonTitle))
        {
            subjects.Remove(lessonTitle);
        }
    }
    else if (inputCommand[0] == "Swap")
    {
        string firstLessonTitle = inputCommand[1];
        string secondLessonTitle = inputCommand[2];

        if (!subjects.Contains($"{firstLessonTitle}-Exercise") && !subjects.Contains($"{secondLessonTitle}-Exercise"))
        {
            int indexOfFirstLesson = subjects.IndexOf(firstLessonTitle);
            int indexOfSecondLesson = subjects.IndexOf(secondLessonTitle);

            subjects.Insert(indexOfFirstLesson, secondLessonTitle);
            subjects.RemoveAt(indexOfFirstLesson + 1);

            subjects.Insert(indexOfSecondLesson, firstLessonTitle);
            subjects.RemoveAt(indexOfSecondLesson + 1);
        }
        else if (subjects.Contains($"{firstLessonTitle}-Exercise") && subjects.Contains($"{secondLessonTitle}-Exercise"))
        {
            int indexOfFirstLesson = subjects.IndexOf(firstLessonTitle);
            int indexOfFirstLessonExercise = subjects.IndexOf($"{firstLessonTitle}-Exercise");
            int indexOfSecondLesson = subjects.IndexOf(secondLessonTitle);
            int indexOfSecondLessonExercise = subjects.IndexOf($"{secondLessonTitle}-Exercise");

            subjects.Insert(indexOfFirstLesson, secondLessonTitle);
            subjects.RemoveAt(indexOfFirstLesson + 1);

            subjects.Insert(indexOfSecondLesson, firstLessonTitle);
            subjects.RemoveAt(indexOfSecondLesson + 1);

            subjects.Insert(indexOfFirstLessonExercise, $"{secondLessonTitle}-Exercise");
            subjects.RemoveAt(indexOfFirstLessonExercise + 1);

            subjects.Insert(indexOfSecondLessonExercise, $"{firstLessonTitle}-Exercise");
            subjects.RemoveAt(indexOfSecondLessonExercise + 1);

        }
        else if (subjects.Contains($"{firstLessonTitle}-Exercise") && !subjects.Contains($"{secondLessonTitle}-Exercise"))
        {
            int indexOfFirstLesson = subjects.IndexOf(firstLessonTitle);
            int indexOfFirstLessonExercise = subjects.IndexOf($"{firstLessonTitle}-Exercise");
            int indexOfSecondLesson = subjects.IndexOf(secondLessonTitle);
            int indexOfSecondLessonExercise = subjects.IndexOf($"{secondLessonTitle}-Exercise");

            subjects.Insert(indexOfFirstLesson, secondLessonTitle);
            subjects.RemoveAt(indexOfFirstLesson + 1);

            subjects.Insert(indexOfSecondLesson, firstLessonTitle);
            subjects.RemoveAt(indexOfSecondLesson + 1);

            subjects.Insert(indexOfSecondLesson + 1, $"{firstLessonTitle}-Exercise");
            subjects.RemoveAt(indexOfFirstLesson + 2);
        }
        else if (!subjects.Contains($"{firstLessonTitle}-Exercise") && subjects.Contains($"{secondLessonTitle}-Exercise"))
        {
            int indexOfFirstLesson = subjects.IndexOf(firstLessonTitle);
            int indexOfFirstLessonExercise = subjects.IndexOf($"{firstLessonTitle}-Exercise");
            int indexOfSecondLesson = subjects.IndexOf(secondLessonTitle);
            int indexOfSecondLessonExercise = subjects.IndexOf($"{secondLessonTitle}-Exercise");

            subjects.Insert(indexOfFirstLesson, secondLessonTitle);
            subjects.RemoveAt(indexOfFirstLesson + 1);

            subjects.Insert(indexOfSecondLesson, firstLessonTitle);
            subjects.RemoveAt(indexOfSecondLesson + 1);

            subjects.Insert(indexOfFirstLesson + 1, $"{secondLessonTitle}-Exercise");
            subjects.RemoveAt(indexOfSecondLesson + 2);
        }

    }
    else if (inputCommand[0] == "Exercise")
    {
        string lessonTitle = inputCommand[1];
        if (subjects.Contains(lessonTitle) && !subjects.Contains($"{lessonTitle}-Exercise"))
        {
            int indexOfLesson = subjects.IndexOf(lessonTitle);
            subjects.Insert(indexOfLesson + 1, $"{lessonTitle}-Exercise");
        }

        if (!subjects.Contains(lessonTitle))
        {
            subjects.Add(lessonTitle);
            subjects.Add($"{lessonTitle}-Exercise");
        }
    }
}

for (int i = 0; i < subjects.Count; i++)
{
    Console.Write($"{i + 1}.{subjects[i]}");
    Console.WriteLine();
}