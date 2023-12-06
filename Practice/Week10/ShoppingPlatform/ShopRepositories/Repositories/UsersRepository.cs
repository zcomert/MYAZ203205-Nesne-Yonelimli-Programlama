using ShopEntities.Models;

namespace ShopRepositories.Repositories;

public class UsersRepository : IRepository<Users>
{
    private List<Users> users;

    public UsersRepository(List<Users> users)
    {
        this.users = users;
    }

    public void Delete()
    {
        users.Clear();
    }

    public void DeleteOne(int id)
    {
        var item = GetOne(id);
        if (item == null)
            return;
        users.Remove(item);
    }

    public List<Users> GetAll()
    {
        return users;
    }

    public Users GetOne(int id)
    {
        return users
        .Where(user => user.Id.Equals(id))
        .SingleOrDefault();
    }

    public void Post(Users item)
    {
        if (item == null)
            return;
        users.Add(item);
    }

    public void Update(int id, Users item)
    {
        if (item == null || id == null)
            return;

        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].Id.Equals(id))
            {
                users[i] = item;
                return;
            }
        }
    }
}