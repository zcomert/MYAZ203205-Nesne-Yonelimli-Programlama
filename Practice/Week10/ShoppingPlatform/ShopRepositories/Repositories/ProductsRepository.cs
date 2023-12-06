using ShopEntities.Models;

namespace ShopRepositories.Repositories;

public class ProductsRepository : IRepository<Products>
{
    private List<Products> products;

    public ProductsRepository(List<Products> products)
    {
        this.products = products;
    }

    public void Delete()
    {
        products.Clear();
    }

    public void DeleteOne(int id)
    {
        var item = GetOne(id);
        if (item == null)
            return;
        products.Remove(item);
    }

    public List<Products> GetAll()
    {
        return products;
    }

    public Products GetOne(int id)
    {
        return products
        .Where(prd => prd.Id.Equals(id))
        .SingleOrDefault();
    }

    public void Post(Products item)
    {
        if (item == null)
            return;
        products.Add(item);
    }

    public void Update(int id, Products item)
    {
        if (item == null || id == null)
            return;

        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].Id.Equals(id))
            {
                products[i] = item;
                return;
            }
        }
    }
}