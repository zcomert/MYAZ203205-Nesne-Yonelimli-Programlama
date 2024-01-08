namespace Demo2.Models;

public class Person{
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ICollection<PersonInMeeting>? PersonInMeeting { get; set; }

    public override string ToString()
    {
        return $"\t{PersonId} {FirstName} {LastName}";
    }

}