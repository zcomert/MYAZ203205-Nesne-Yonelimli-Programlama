public class GroceriesItem : TodoItem
{
    public int Quentity { get; set; }

    public GroceriesItem(int Quentity)
    {
        this.Quentity = Quentity;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {Quentity}";
    }
}