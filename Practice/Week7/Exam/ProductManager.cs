public class ProductManager
{
    private List<Product> products;
    public int Count { get => products.Count; }

    public ProductManager()
    {
        products = new List<Product>();
    }

    public ProductManager(List<Product> products)
    : this()
    {
        foreach (var item in products)
        {
            Add(item);
        }
    }

    public void Add(Product item)
    {
        products.Add(item);
    }

    public Product Get(int id)
    {
        return products.Where(prd => prd.Id.Equals(id)).FirstOrDefault();
    }

    public List<Product> GetAll()
    {
        return products;
    }

    public void Update(int id, Product product)
    {
        for (int i = 0; i < Count; i++)
        {
            if (products[i].Id.Equals(id))
            {
                products[i] = product;
                return;
            }
        }
    }

    public void Delete(int id)
    {
        var prd = Get(id);
        products.Remove(prd);
    }

}