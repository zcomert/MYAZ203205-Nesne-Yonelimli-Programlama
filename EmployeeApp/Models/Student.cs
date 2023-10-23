namespace EmployeeApp.Models;

public class Student : Employee
{
    public bool IsPartTime { get; set; }

    public void DoIntern()
    {
        System.Console.WriteLine("DoIntern has been called.");
    }
    public override void Work()
    {
        for (int i = 0; i < 10; i++)
        {
            System.Console.WriteLine(i+1);
        }
        base.Work();
    }
}