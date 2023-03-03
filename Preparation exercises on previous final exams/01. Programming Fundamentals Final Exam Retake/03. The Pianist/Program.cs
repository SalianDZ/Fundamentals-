Dictionary<string, PieceInfo> pieces = new Dictionary<string, PieceInfo>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split("|", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string currentPiece = input[0];
    string currentComposer = input[1];
    string currentKey = input[2];

    if (!pieces.ContainsKey(currentPiece))
    {
        pieces[currentPiece] = new PieceInfo(currentComposer, currentKey);
    }
}

while (true)
{
    string[] input = Console.ReadLine()
        .Split("|", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (input[0] == "Stop")
    {
        break;
    }
    else if (input[0] == "Add")
    {
        string currentPiece = input[1];
        string currentComposer = input[2];
        string currentKey = input[3];

        if (pieces.ContainsKey(currentPiece))
        {
            Console.WriteLine($"{currentPiece} is already in the collection!");
            continue;
        }

        pieces[currentPiece] = new PieceInfo(currentComposer, currentKey);
        Console.WriteLine($"{currentPiece} by {currentComposer} in {currentKey} added to the collection!");
    }
    else if (input[0] == "Remove")
    {
        string currentPiece = input[1];

        if (!pieces.ContainsKey(currentPiece))
        {
            Console.WriteLine($"Invalid operation! {currentPiece} does not exist in the collection.");
            continue;
        }
        pieces.Remove(currentPiece);
        Console.WriteLine($"Successfully removed {currentPiece}!");
    }
    else if (input[0] == "ChangeKey")
    {
        string currentPiece = input[1];
        string currentKey = input[2];

        if (!pieces.ContainsKey(currentPiece))
        {
            Console.WriteLine($"Invalid operation! {currentPiece} does not exist in the collection.");
            continue;
        }

        pieces[currentPiece].Key = currentKey;
        Console.WriteLine($"Changed the key of {currentPiece} to {currentKey}!");
    }

}

//"{Piece} -> Composer: {composer}, Key: {key}"

foreach (var piece in pieces)
{
    Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
}

public class PieceInfo
{
    public PieceInfo(string composer, string key)
    {
        Composer = composer;
        Key = key;
    }

    public string Composer { get; set; }

    public string Key { get; set; }
}