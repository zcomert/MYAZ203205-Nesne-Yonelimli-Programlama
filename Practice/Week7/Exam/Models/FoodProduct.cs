public class FoodProduct : Product
{
    private DateTime expirationDate;
    private bool isPerishable;
    private double storageTemperature;

    public DateTime ExpirationDate
    {
        get => expirationDate;
        set => expirationDate = value;
    }

    public bool IsPerishable
    {
        get { return isPerishable; }
        set { isPerishable = value; }
    }


    public double StorageTemperature
    {
        get { return storageTemperature; }
        set { storageTemperature = value; }
    }

    public FoodProduct(int id, string productName, double price, DateTime expirationDate, bool ısPerishable, double storageTemperature)
    : base(id, productName, price)
    {
        ExpirationDate = expirationDate;
        IsPerishable = ısPerishable;
        StorageTemperature = storageTemperature;
    }
}