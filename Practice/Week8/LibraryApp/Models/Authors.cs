public class Authors
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get => FirstName + " " + LastName; }

    public override string ToString()
    {
        return $"{Id} {FullName}";
    }
}