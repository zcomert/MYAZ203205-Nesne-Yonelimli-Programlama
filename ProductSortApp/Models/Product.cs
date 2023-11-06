namespace ProductSortApp.Models;

public class Product : IComparable, ICloneable
{
    #region
    public Product()
    {

    }
    public Product(string? name, double price)
    {
        Name = name;
        Price = price;
    }

    public String? Name { get; set; }
    public double Price { get; set; }



    public override string ToString()
    {
        return $"{Name,-10} {Price,-10}";
    }
    #endregion
    public int CompareTo(object? obj)
    {
        // var k = -1;
        Product other = (Product)obj;
        // return this.Name.CompareTo(other.Name);

        if (this.Price < other.Price)
            return -1;
        else if (this.Price == other.Price)
            return 0;
        else
            return 1;
    }

    public object Clone()
    {
        return new Product()
        {
            Name = this.Name,
            Price = this.Price
        };
    }
}
