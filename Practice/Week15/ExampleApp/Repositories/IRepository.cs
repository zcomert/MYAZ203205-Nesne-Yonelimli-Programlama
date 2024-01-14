using Entities;

namespace ExampleApp.Repositories;

public interface IRepository<T>
{
    public void AddTask(T item);
    public void AddMultipleTask(List<T> items);
    public T GetOne(int id);
    public List<T> GetAll();
}