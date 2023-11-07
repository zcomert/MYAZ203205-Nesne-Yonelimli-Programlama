using System.Collections;

public class MusicList : IEnumerable
{
    private List<Song> MusicItems { get; set; }

    public MusicList()
    {
        MusicItems = new List<Song>();
    }

    public MusicList(List<Song> musicItems) : this()
    {
        foreach (var item in musicItems)
        {
            Add(item);
        }
    }

    public void Add(Song item)
    {
        MusicItems.Add(item);
    }

    public Song Remove(int id)
    {
        for (int i = 0; i < MusicItems.Count; i++)
        {
            if (MusicItems[i].Id.Equals(id))
            {
                var song = MusicItems[i];
                MusicItems.Remove(song);
                // MusicItems.RemoveAt(i);
                return song;
            }
        }
        return null;
    }
    public void Update(int id, Song song)
    {
        for (int i = 0; i < MusicItems.Count; i++)
        {
            if (MusicItems[i].Id.Equals(id))
            {
                MusicItems[i] = song;
                break;
            }
        }
    }

    public List<Song> Sort()
    {
        MusicItems.Sort();
        return MusicItems;
    }

    public void Display()
    {
        foreach (var item in MusicItems)
        {
            System.Console.WriteLine(item.ToString("title"));
        }
    }

    public IEnumerator GetEnumerator()
    {
        return MusicItems.GetEnumerator();
    }
}