string text = Console.ReadLine();
Console.WriteLine(String.Join("", text.Where(char.IsDigit)));
Console.WriteLine(String.Join("", text.Where(char.IsLetter)));
Console.WriteLine(String.Join("", text.Where(x => !char.IsDigit(x) && !char.IsLetter(x))));
