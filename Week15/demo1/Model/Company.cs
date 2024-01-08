
namespace demo1.Models;
public class Company
{
    public int CompanyId { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public override string ToString()
    {
        return $"{CompanyId} {Name} {Country}";
    }
}