MusicList musicList = new MusicList(new List<Song>(){
    new Song(1, "Music 1", new Artists(1, "Ali", "Veli", "Rock"), new Albums(1, "Album 1", DateTime.Now, "Rock"), "Rock", (float) 12.0),
    new Song(2, "Music 2", new Artists(1, "Ali", "Veli", "Rock"), new Albums(1, "Album 1", DateTime.Now, "Rock"), "Rock", (float) 2.0),
    new Song(3, "Music 3", new Artists(1, "Ali", "Veli", "Rock"), new Albums(1, "Album 1", DateTime.Now, "Rock"), "Rock", (float) 1.0),
    new Song(4, "Music 4", new Artists(1, "Ali", "Veli", "Rock"), new Albums(1, "Album 1", DateTime.Now, "Rock"), "Rock", (float) 16.0),
    new Song(5, "Song 4", new Artists(1, "Ali", "Veli", "Rock"), new Albums(1, "Album 1", DateTime.Now, "Rock"), "Rock", (float) 7.0),
});

musicList.Add(new Song(6, "Highway to Hell",
new Artists(2, "AC", "DC", "Rock"),
new Albums(1, "Album 1", DateTime.Now, "Rock"),
"Rock", (float)7.0));

foreach (var item in musicList.Sort())
{
    System.Console.WriteLine(item.ToString("title"));
}

musicList.Remove(3);

musicList.Display();