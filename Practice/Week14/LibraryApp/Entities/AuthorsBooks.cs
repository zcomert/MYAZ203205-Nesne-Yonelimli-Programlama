namespace Entities;

public class AuthorsBooks
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public int BookId { get; set; }

    public Books Book { get; set; }
    public Authors Author { get; set; }
}