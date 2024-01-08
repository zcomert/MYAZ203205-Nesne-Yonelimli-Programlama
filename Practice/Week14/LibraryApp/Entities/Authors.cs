namespace Entities;

public class Authors
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    // Nullable
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public ICollection<Books> Books { get; set; }
}