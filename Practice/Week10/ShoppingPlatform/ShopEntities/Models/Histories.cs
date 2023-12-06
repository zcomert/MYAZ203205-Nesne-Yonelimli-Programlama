namespace ShopEntities.Models;

public class Histories
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime PurchaseDate { get; set; }
    public List<Products> PurchaseList { get; set; }
}