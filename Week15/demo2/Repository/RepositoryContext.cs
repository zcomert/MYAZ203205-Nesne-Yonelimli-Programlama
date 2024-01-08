using Demo2.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo2.Repository;

public class RepositoryContext :DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Meeting> Meetings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source = demo2.db;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Person>().HasData(
            new Person()
            {
                PersonId = 1,
                FirstName = "John",
                LastName = "Doe"
            },
            new Person()
            {
                PersonId = 2,
                FirstName = "Jane",
                LastName = "Doe"
            }
        );

        modelBuilder.Entity<Meeting>().HasData(
            new Meeting()
            {
                MeetingId = 1,
                Subject = "Finaller",
                Date = DateTime.Now.AddDays(3),
                Link = "#"
            }
        );

        modelBuilder.Entity<PersonInMeeting>().HasData(
            new PersonInMeeting()
            {
                Id=1,
                PersonId=1,
                MeetingId=1
            },
            new PersonInMeeting()
            {
                Id=2,
                PersonId=2,
                MeetingId=1
            });
    }
}