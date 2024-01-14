namespace Entities;

public class Employee
{
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get => FirstName + " " + LastName; }

    public ICollection<Tasks>? Tasks { get; set; }

    public Employee()
    {
        Tasks = new List<Tasks>();
    }

    public Employee(int Id, string firstName, string lastName) : this()
    {
        this.Id = Id;
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        Tasks.ToList().ForEach(task=>Console.WriteLine(task.ToString()));
        return $"{Id} {FullName}";
    }
}