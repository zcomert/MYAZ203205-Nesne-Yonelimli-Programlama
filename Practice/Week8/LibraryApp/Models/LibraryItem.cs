
public class LibraryItem : IBooks
{
    public int Id { get; set; }
    public string Title { get; set; }
    public Authors Author { get; set; }
    public DateTime PublishYear { get; set; }
    public bool IsAvailable { get; set; }

    public LibraryItem(int ıd, string title, Authors author, DateTime publishYear, bool ısAvailable)
    {
        Id = ıd;
        Title = title;
        Author = author;
        PublishYear = publishYear;
        IsAvailable = ısAvailable;
    }

    public void Borrow()
    {
        if (IsAvailable.Equals(false))
            System.Console.WriteLine($"{Title} is not available!");
        else
            SetAvailability(false);
    }

    public void Return() => SetAvailability(true);

    public override string ToString()
    {
        return String.Format("{0} {1} {2} {3} {4}",
        Id, Title, Author.ToString(), PublishYear, IsAvailable);
    }

    public int CompareTo(LibraryItem? other)
    {
        return PublishYear.CompareTo(other.PublishYear);
    }

    public void SetAvailability(bool available)
    {
        IsAvailable = available;
    }
}