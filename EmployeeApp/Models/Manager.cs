namespace EmployeeApp.Models;

public class Manager : Employee
{
    public Manager(int id, string firstName, string lastName) 
        : base(id, firstName, lastName)
    {

    }
    public Manager()
    {
        
    }

    public string Position { get; set; }
    public void GetHire(){
        System.Console.WriteLine("Get Hire has been called.");
    }

    public override void Work()
    {
        for (int i = 10; i >= 0 ; i--)
        {
            System.Console.WriteLine(i);
        }
        base.Work();
    }
}