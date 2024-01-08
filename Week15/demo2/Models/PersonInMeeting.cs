namespace Demo2.Models;

public class PersonInMeeting
{
    public int Id { get; set; }
    public int MeetingId { get; set; }
    public int PersonId { get; set; }

    public Person Person { get; set; }
    public Meeting Meeting { get; set; }
}