using System.ComponentModel.DataAnnotations;

string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
int numberOfCommands = int.Parse(Console.ReadLine());

string title = input[0];
string content = input[1];
string author = input[2];
Article article = new Article(title, content, author);

for (int i = 0; i < numberOfCommands; i++)
{
    string[] currentCommand = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    if (currentCommand[0] == "Edit")
    {
        article.Edit(currentCommand[1]);
    }
    else if (currentCommand[0] == "ChangeAuthor")
    {
        article.ChangeAuthor(currentCommand[1]);
    }
    else if (currentCommand[0] == "Rename")
    {
        article.Rename(currentCommand[1]);
    }
}

Console.WriteLine(article);

public class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }

    public string Content { get; set; }

    public string Author { get; set; }

    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}
