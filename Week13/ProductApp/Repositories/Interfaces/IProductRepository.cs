using Entities.Models;

namespace Repositories.Interfaces;

public interface IProductRepository
{
    // CRUD

    public void CreateProduct(Product product);

    public Product GetOneProduct(int id);
    public List<Product> GetAllProduct();

    public void UpdateProduct(int id, Product product);

    public Product DeleteOneProduct(int id);
}