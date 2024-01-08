namespace Entities;

public class Books
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime PublishDate { get; set; }
    public int Quantity { get; set; }

    public ICollection<Authors> Authors { get; set; }
}
