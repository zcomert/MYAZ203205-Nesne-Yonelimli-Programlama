using Entities;

namespace ExampleApp.Repositories;

public static class EmployeeRepository
{
    private static List<Employee> list { get; set; }

    static EmployeeRepository()
    {
        list = new List<Employee>();
    }

    public static void AddEmployee(Employee employee)
    {
        employee.Id = list.Count;
        list.Add(employee);
    }

    public static void AddMultipleTask(int id, List<Tasks> tasks)
    {
        var emp = GetOneEmployee(id);
        // tasks.ForEach(task => emp.Tasks.Add(task));

        foreach (var item in tasks)
        {
            AddTask(id, item);
        }
    }

    public static void AddTask(int id, Tasks task)
    {
        if (id != task.EmployeeId)
            throw new Exception($"{task.Title} have wrong Employee Id!");
        var emp = GetOneEmployee(id);
        emp.Tasks.Add(task);
    }

    public static void ChangeStatus(int id, int taskId, int status)
    {
        var emp = GetOneEmployee(id);
        emp.Tasks.Where(task => task.Id.Equals(taskId)).Single().Status = status;
    }

    public static Employee GetOneEmployee(int id)
    {
        var emp = list.SingleOrDefault(emp => emp.Id.Equals(id));
        if (emp is null)
            throw new Exception("Employee not found!");
        return emp;
    }
}
