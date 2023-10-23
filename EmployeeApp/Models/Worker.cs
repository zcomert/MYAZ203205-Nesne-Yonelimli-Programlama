namespace EmployeeApp.Models;

public class Worker : Employee
{
    public Worker() 
    {
        System.Console.WriteLine("An instance has been created from Worker class.");
    }

    public Worker(string FirstName, string LastName) 
        : base(FirstName, LastName)
    {
        System.Console.WriteLine("Worker ctor with 2 parameter has been called.");

    }

    public Worker(int id, string FirstName, string LastName) 
        : base(id, FirstName, LastName)
    {
        System.Console.WriteLine("Worker ctor with 3 parameter has been called.");
    }
}