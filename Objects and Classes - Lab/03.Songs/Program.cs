using System.Collections.Generic;
using System.Linq;

int numberOfSongs = int.Parse(Console.ReadLine());
List<Song> songList = new List<Song>();

for (int i = 0; i < numberOfSongs; i++)
{
    string[] info = Console.ReadLine().Split("_"); 

    string typeList = info[0];
    string songName = info[1];
    string songDuration = info[2];

    Song song = new Song();

    song.TypeList = typeList;
    song.Name = songName;
    song.Duration = songDuration;

    songList.Add(song);
}

string searchedTypeList = Console.ReadLine();

if (searchedTypeList == "all")
{
    foreach (var song in songList)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach (var song in songList)
    {
        if (song.TypeList == searchedTypeList)
        {
            Console.WriteLine(song.Name);
        }
    }
}

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Duration { get; set; }
}using System.Collections.Generic;
using System.Linq;

int numberOfSongs = int.Parse(Console.ReadLine());
List<Song> songList = new List<Song>();

for (int i = 0; i < numberOfSongs; i++)
{
    string[] info = Console.ReadLine().Split("_"); 

    string typeList = info[0];
    string songName = info[1];
    string songDuration = info[2];

    Song song = new Song();

    song.TypeList = typeList;
    song.Name = songName;
    song.Duration = songDuration;

    songList.Add(song);
}

string searchedTypeList = Console.ReadLine();

if (searchedTypeList == "all")
{
    foreach (var song in songList)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach (var song in songList)
    {
        if (song.TypeList == searchedTypeList)
        {
            Console.WriteLine(song.Name);
        }
    }
}

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Duration { get; set; }
}