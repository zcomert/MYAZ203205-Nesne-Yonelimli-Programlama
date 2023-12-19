using Entities;
using Repositories.Interfaces;
using Repositories.Services;

namespace Repositories;

public class UserRepository : IRepository<User>
{
    private List<User> users;

    public UserRepository(List<User> users)
    {
        this.users = users;
    }

    public void Delete(int id)
    {
        var item = GetOne(id);
        if (item is null)
            return;
        users.Remove(item);
    }

    public User GetOne(int id)
    {
        return users.SingleOrDefault(user => user.Id.Equals(id));
    }

    public void Post(User item)
    {
        if (item is null)
            return;
        var pass = item.Password.Encoder(item.Salt);
        item.Password = pass;
        users.Add(item);
    }

    public User GetData(string email, string password)
    {
        var user = users.SingleOrDefault(user => user.Email.Equals(email));
        if (user is null)
            return null;

        if (user.Password.Equals(password.Encoder(user.Salt)))
            return user;
        return null;
    }
}
