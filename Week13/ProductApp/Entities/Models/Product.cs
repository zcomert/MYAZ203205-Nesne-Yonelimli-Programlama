namespace Entities.Models;

public class Product
{
    // full prop
    private int productId;
    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public String? ProductName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public ICollection<Comment> Comments {get; set;}
    
}