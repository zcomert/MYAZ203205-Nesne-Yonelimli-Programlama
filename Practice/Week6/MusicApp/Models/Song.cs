using System.Globalization;

public class Song : IFormattable, IComparable<Song>
{
    public int Id { get; set; }
    public string Title { get; set; }
    public Artists Artist { get; set; }
    public Albums Album { get; set; }
    public string Genre { get; set; }
    public float Duration { get; set; }

    public Song()
    {

    }

    public Song(int ıd, string title, Artists artist, Albums album, string genre, float duration)
    {
        Id = ıd;
        Title = title;
        Artist = artist;
        Album = album;
        Genre = genre;
        Duration = duration;
    }

    public string ToString(string? format = "id", IFormatProvider? formatProvider = null)
    {
        if (String.IsNullOrEmpty(format)) format = "id";
        if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

        switch (format.ToLowerInvariant())
        {
            case "id":
                return $"{Id} {Title} {Duration}";
            case "title":
                return $"{Title} {Id}  {Duration}";
            case "duration":
                return $"{Duration} {Title} {Id}";
            default:
                throw new FormatException(String.Format("The {0} format string is not supported.", format));
        }
    }

    public int CompareTo(Song? other)
    {
        return this.Title.CompareTo(other.Title);
    }

    // public int CompareTo(object? obj)
    // {
    //     var other = obj as Song;
    //     return this.Title.CompareTo(other.Title);
    // }


}