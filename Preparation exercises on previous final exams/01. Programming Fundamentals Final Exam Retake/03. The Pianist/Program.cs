int n = int.Parse(Console.ReadLine());
Dictionary<string, PieceInformation> pieces = new Dictionary<string, PieceInformation>();

for (int i = 0; i < n; i++)
{
    string[] currentPiece = Console.ReadLine()
        .Split("|", StringSplitOptions.RemoveEmptyEntries);

    string currentPieceName = currentPiece[0];

    if (!pieces.ContainsKey(currentPieceName))
    {
        string composer = currentPiece[1];
        string key = currentPiece[2];
        pieces[currentPieceName] = new PieceInformation(composer, key);
    }
}

while (true)
{
    string[] command = Console.ReadLine()
        .Split("|", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "Stop")
    {
        break;
    }
    else if (command[0] == "Add")
    {
        string pieceName = command[1];
        string composer = command[2];
        string key = command[3];
        if (pieces.ContainsKey(pieceName))   
        {
            Console.WriteLine($"{pieceName} is already in the collection!");
            continue;
        }

        pieces[pieceName] = new PieceInformation(composer, key);
        Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
    }
    else if (command[0] == "Remove")
    {
        string pieceName = command[1];

        if (pieces.ContainsKey(pieceName))
        {
            pieces.Remove(pieceName);
            Console.WriteLine($"Successfully removed {pieceName}!");
            continue;
        }

        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
    }
    else if (command[0] == "ChangeKey")
    {
        string pieceName = command[1];
        string newKey = command[2];

        if (pieces.ContainsKey(pieceName))
        {
            pieces[pieceName].Key = newKey;
            Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
            continue;
        }

        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
    }
}

foreach (var piece in pieces)
{
    Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
}



class PieceInformation
{
    public PieceInformation(string composer, string key)
    {
        Composer = composer;
        Key = key;
    }

    public string Composer { get; set; }

    public string Key { get; set; }    
}