using Entities;
using Repositories.Interfaces;

namespace Repositories;

public class ItemRepository : IRepository<Items>
{
    private List<Items> items;

    public ItemRepository(List<Items> items)
    {
        this.items = items;
    }

    public void Delete(int id)
    {
        var item = GetOne(id);
        items.Remove(item);
    }

    public Items GetOne(int id)
    {
        return items.SingleOrDefault(cat => cat.Id.Equals(id));
    }

    public List<Items> GetAll()
    {
        return items;
    }

    public void Post(Items item)
    {
        items.Add(item);
    }
}