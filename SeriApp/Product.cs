class Product
{
    private string? name;
    public string Name
    {
        // accessor
        get { return name + " " + price.ToString(); }
        set
        {
            if (value.Length > 2)
                name = value;
            else
                name = "Geçersiz ürün adı";
        }
    }

    private float price;
    public float Price
    {
        get { return price; }
        set
        {
            if (value < 10 || value > 1000)
            {
                throw new Exception("Geçersiz fiyat aralığı");
            }
            price = value;
        }
    }

    public DateTime GeneratedDate { get; set; }
    public int Quantity { get; set; }
    private float taxRate = .18f;

    public float GetTotalPrice()
    {
        return (price * Quantity) + CalculateTax();
    }

    private float CalculateTax()
    {
        return price * Quantity * taxRate;
    }

}