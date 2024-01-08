namespace Demo2.Models;

public class Meeting
{
    public int MeetingId { get; set; }
    public string Subject { get; set; }
    public DateTime Date { get; set; }
    public string Link { get; set; }

    public ICollection<PersonInMeeting>? PersonInMeeting { get; set; }

    public Meeting SetId(int value)
    {
        MeetingId = value;
        return this;
    }

    public Meeting SetSubject(string value)
    {
        Subject = value;
        return this;
    }

    public Meeting SetDate(DateTime value)
    {
        Date = value;
        return this;
    }

    public Meeting SetLink(string value)
    {
        Link = value;
        return this;
    }

    public static Meeting Create() => new Meeting();

    public override string ToString()
    {
        string s = "";
        foreach (var pim in this.PersonInMeeting)
        {
            s+= "\n" + pim.Person.ToString();
        }
        return $"{MeetingId} - Subject: {Subject}, Date: {Date} Link: {Link} {s}";
    }

    public Meeting()
    {

    }
}

