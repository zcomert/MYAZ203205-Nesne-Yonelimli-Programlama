public abstract class Product : IComparable
{
    // Fields
    protected int id;
    protected string productName;
    protected double price;
    protected DateTime atCreatedDate;

    // Property
    public int Id { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public DateTime AtCreatedDate { get => DateTime.Now; } // Readonly

    public Product(int id, string productName, double price)
    {
        this.id = id;
        this.productName = productName;
        this.price = price;
    }

    public virtual int CompareTo(object? obj)
    {
        var other = obj as Product;
        return Price.CompareTo(other.Price);
    }
}