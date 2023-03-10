using System.Text;

string[] path = Console.ReadLine().Split("\\");
string[] nameAndExtension = path[path.Length - 1].Split('.');
string name = nameAndExtension[0];
string extension = nameAndExtension[1];

StringBuilder sb = new StringBuilder();
sb.AppendLine($"File name: {name}");
sb.AppendLine($"File extension: {extension}");

Console.WriteLine(sb);
