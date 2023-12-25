namespace Entities.Models;
public class Employee
{
   private int id;
   public int Id
   {
    get { return id; }
    set { id = value; }
   }
   
    // Auto-implemented property
    public String? FirstName { get; set; } = string.Empty;
    public String? LastName { get; set; } = string.Empty;
    public decimal Salary { get; set; }

    public int? CompanyId { get; set; }
    public Company? Company { get; set; } 
}
