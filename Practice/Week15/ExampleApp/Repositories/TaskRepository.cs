using Entities;

namespace ExampleApp.Repositories;

public class TaskRepository : IRepository<Tasks>
{
    public void AddMultipleTask(List<Tasks> items)
    {
        items
        .ForEach(
            task => EmployeeRepository.GetOneEmployee(task.EmployeeId)
            .Tasks
            .Add(task)
            );
    }

    public void AddTask(Tasks item)
    {
        throw new NotImplementedException();
    }

    public List<Tasks> GetAll()
    {
        throw new NotImplementedException();
    }

    public Tasks GetOne(int id)
    {
        throw new NotImplementedException();
    }
}