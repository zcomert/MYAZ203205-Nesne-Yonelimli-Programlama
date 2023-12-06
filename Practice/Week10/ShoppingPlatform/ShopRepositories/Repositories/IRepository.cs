namespace ShopRepositories.Repositories;

public interface IRepository<T>
{
    public List<T> GetAll();
    public T GetOne(int id);
    public void Post(T item);
    public void Update(int id, T item);
    public void Delete();
    public void DeleteOne(int id);
}
