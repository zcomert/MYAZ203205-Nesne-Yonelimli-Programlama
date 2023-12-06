using ShopEntities.Models;

namespace ShopRepositories.Repositories;

public class HistoriesRepository : IRepository<Histories>
{
    private List<Histories> histories;

    public HistoriesRepository(List<Histories> histories)
    {
        this.histories = histories;
    }

    public void Delete()
    {
        histories.Clear();
    }

    public void DeleteOne(int id)
    {
        var item = GetOne(id);
        if (item == null)
            return;
        histories.Remove(item);
    }

    public List<Histories> GetAll()
    {
        return histories;
    }

    public Histories GetOne(int id)
    {
        return histories
        .Where(history => history.Id.Equals(id))
        .SingleOrDefault();
    }

    public void Post(Histories item)
    {
        if (item == null)
            return;
        histories.Add(item);
    }

    public void Update(int id, Histories item)
    {
        if (item == null || id == null)
            return;

        for (int i = 0; i < histories.Count; i++)
        {
            if (histories[i].Id.Equals(id))
            {
                histories[i] = item;
                return;
            }
        }
    }
}