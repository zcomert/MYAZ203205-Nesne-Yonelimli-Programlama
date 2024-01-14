using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;

namespace Repositories;
public class ProductRepository : IProductRepository
{
    private RepositoryContext context;

    public ProductRepository(RepositoryContext context)
    {
        this.context = context;
    }

    public void CreateProduct(Product product)
    {
        if (product.Price <= 0)
            throw new Exception("Required field value is wrong!");

        context.Products.Add(product);

        try
        {
            context.SaveChanges();
        }
        catch (Exception e)
        {
            throw new Exception($"Something go wrong!: {e.Message}");
        }
    }

    public Product DeleteOneProduct(int id)
    {
        var prd = GetOneProduct(id);
        context.Products.Remove(prd);
        try
        {
            context.SaveChanges();
            return prd;
        }
        catch (Exception e)
        {
            throw new Exception($"Something go wrong!: {e.Message}");
        }
    }

    public List<Product> GetAllProduct()
    {
        return context.Products.Include(c => c.Comments).ToList();
    }

    public Product GetOneProduct(int id)
    {
        var prd = context
        .Products
        .Where(prd => prd.ProductId.Equals(id))
        .Include(c => c.Comments)
        .SingleOrDefault();
        if (prd is null)
            throw new Exception("Product not found!");
        return prd;
    }

    public void UpdateProduct(int id, Product product)
    {
        if (product.Price <= 0)
            throw new Exception("Required field value is wrong!");

        var prd = GetOneProduct(id);

        prd.Price = product.Price;
        prd.ProductName = product.ProductName;
        
        try
        {
            context.SaveChanges();
        }
        catch (Exception e)
        {
            throw new Exception($"Something go wrong!: {e.Message}");
        }
    }
}
