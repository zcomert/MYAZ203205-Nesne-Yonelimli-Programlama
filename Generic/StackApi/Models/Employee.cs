namespace StackApi.Models;

public class Employee
{
    public int Id { get; set; }
    public String FirstName { get; set; } = string.Empty;
    public String LastName { get; set; } = string.Empty;
    public String FullName => String.Concat(FirstName, " ", LastName.ToUpper());
    public DateTime AtCreated {get; set; } = DateTime.Now;
}