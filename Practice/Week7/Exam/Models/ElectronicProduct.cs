public class ElectronicProduct : Product
{
    private bool isWireless;
    private int warrantyPeriod;

    public bool IsWireless
    {
        get { return isWireless; }
        set { isWireless = value; }
    }

    public int WarrantyPeriod
    {
        get { return warrantyPeriod; }
        set
        {
            if (value < 12)
                warrantyPeriod = 12;
            else
                warrantyPeriod = value;
        }
    }



    public ElectronicProduct(int id, string productName, double price, bool ısWireless, int warrantyPeriod)
    : base(id, productName, price)
    {
        IsWireless = ısWireless;
        WarrantyPeriod = warrantyPeriod;
    }
}