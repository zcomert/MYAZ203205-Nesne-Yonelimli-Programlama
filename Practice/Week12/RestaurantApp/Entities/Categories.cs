namespace Entities;

public class Categories
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Items> Items { get; set; }

    public Categories()
    {
        Items = new List<Items>();
    }
}