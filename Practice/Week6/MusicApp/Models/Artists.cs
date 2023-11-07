public class Artists
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Genre { get; set; }
    
    public Artists()
    {
        
    }

    public Artists(int ıd, string firstName, string lastName, string genre)
    {
        Id = ıd;
        FirstName = firstName;
        LastName = lastName;
        Genre = genre;
    }
}