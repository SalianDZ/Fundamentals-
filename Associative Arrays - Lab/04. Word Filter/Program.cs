string[] words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();
Console.WriteLine(string.Join(Environment.NewLine, words));