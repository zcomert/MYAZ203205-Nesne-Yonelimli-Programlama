namespace ShopEntities.Models;

public class Users
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Fullname => String.Concat(Firstname, " ", Lastname);
    public DateTime CreatedDate { get; set; }
}