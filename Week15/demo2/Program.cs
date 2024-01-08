using Demo2.Models;
using Demo2.Repository;
using Microsoft.EntityFrameworkCore;

var context = new RepositoryContext();

context
    .Meetings
    .Include(m => m.PersonInMeeting)
    .ThenInclude(pim => pim.Person)
    .ToList()
    .ForEach(m => System.Console.WriteLine(m));

Console.ReadLine();


static void StaticSample()
{
    var meeting = Meeting.Create()
        .SetId(1)
        .SetSubject("Finaller")
        .SetDate(DateTime.Now.AddDays(3))
        .SetLink("#");


    var person1 = new Person()
    {
        PersonId = 1,
        FirstName = "John",
        LastName = "Doe"
    };

    var person2 = new Person()
    {
        PersonId = 2,
        FirstName = "Jane",
        LastName = "Doe"
    };


    meeting.PersonInMeeting = new List<PersonInMeeting>()
{
   new PersonInMeeting(){Id=1, PersonId=1, Person=person1, MeetingId=1, Meeting = meeting},
   new PersonInMeeting(){Id=2, PersonId=2, Person=person2, MeetingId=1, Meeting = meeting}
};

    person1.PersonInMeeting = meeting.PersonInMeeting;
    person2.PersonInMeeting = meeting.PersonInMeeting;

    System.Console.WriteLine(meeting);
}

static void AddAndListPeople()
{
    var person3 = new Person()
    {
        FirstName = "Berkant",
        LastName = "Özbay"
    };

    var context = new RepositoryContext();
    context.People.Add(person3);
    context.SaveChanges();

    foreach (var person in context.People.ToList())
    {
        System.Console.WriteLine(person);
    }

    Console.ReadLine();
}

static void MeetingsWithPeople()
{
    var meeting = new Meeting()
    {
        Subject = "Bütünlemeler",
        Date = DateTime.Now.AddDays(15),
        Link = "#"
    };

    var context = new RepositoryContext();

    // context.Meetings.Add(meeting);
    // context.SaveChanges();

    context
        .Meetings
        .Include(m => m.PersonInMeeting)
        .ThenInclude(pim => pim.Person)
        .ToList()
        .ForEach(m => System.Console.WriteLine(m));

    Console.ReadLine();
}

static void AddPersonToMeeting()
{
    var context = new RepositoryContext();
    var person = context
        .People
        .Include(p => p.PersonInMeeting)
        .ThenInclude(pim => pim.Meeting)
        .SingleOrDefault(p => p.PersonId.Equals(3));

    person.PersonInMeeting
        .Add(new PersonInMeeting { PersonId = 3, MeetingId = 2 });

    context.SaveChanges();

    System.Console.WriteLine(person);
}