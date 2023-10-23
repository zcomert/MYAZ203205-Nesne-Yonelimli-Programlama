public class Product
{
    public int Id { get; set; }
    public String Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public String NameWithPrice
    {
        get
        {
            return string.Concat(Name, " ", Price);
        }
    }

    public DateTime AtCreatedDate { get; private set; }
    public Product()
    {
        System.Console.WriteLine("An instance has been derived from Product class");
        AtCreatedDate = DateTime.Now;
    }

    public Product(string name, decimal price)
        : this()
    { 
        Name = name;
        Price = price;     
    }

    public Product(int id, string name, decimal price, int quantity)
        : this(name, price)
    {
        Id = id;
        Quantity = quantity;
    }


}