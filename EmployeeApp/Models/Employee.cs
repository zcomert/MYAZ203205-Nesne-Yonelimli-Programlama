namespace EmployeeApp.Models;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName.ToUpper();
    }
    }

    public DateTime AtCreatedDate { get; private set; }
    public Employee()
    {
        System.Console.WriteLine("An instance has been derived from Employee class.");
        AtCreatedDate = DateTime.Now;
        FirstName=string.Empty;
        LastName=string.Empty;
    }

    public Employee(int id, string firstName, string lastName) 
    : this(firstName, lastName)
    {
        System.Console.WriteLine("Employee ctor with 3 parameters has been worked.");
        Id = id; 
    }

    public Employee(string FirstName,string LastName) : this()
    {
        System.Console.WriteLine("Employee ctor with 2 parameters has been worked.");
        this.FirstName= FirstName;
        this.LastName = LastName;
    }

    public virtual void Work()
    {
        Console.WriteLine("Employee is working...");
    }
}