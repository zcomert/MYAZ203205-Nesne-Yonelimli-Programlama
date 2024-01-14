namespace Entities;

public class Tasks
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Status { get; set; }
    public int Priority { get; set; }

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

    public Tasks(int ıd, string title, int status, int priority, int employeeId)
    {
        Id = ıd;
        Title = title;
        Status = status;
        Priority = priority;
        EmployeeId = employeeId;
    }

    public override string ToString()
    {
        return $"{Id} {Title} {Status} {Priority} {EmployeeId}";
    }
}