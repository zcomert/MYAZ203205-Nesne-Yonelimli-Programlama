using System.Security.Cryptography.X509Certificates;

namespace demo1.Models;

public class Phone
{
    public Phone()
    {
        
    }

    public int Id { get; set; }
    public String? Model { get; set; }
    public double Size { get; set; }
    public decimal Price { get; set; }
    public String? Color { get; set; }
    public int CompanyId { get; set; }
    public Company Company {get;set;}

    public Phone SetModel(string value)
    {
        this.Model = value;
        return this;
    }
    public Phone SetSize(double value)
    {
        this.Size = value;
        return this;
    }
    public Phone SetPrice(decimal value){
        Price = value;
        return this;
    }
    public Phone SetId(int id){
        Id=id;
        return this;
    }
    public Phone SetColor(string value){
        Color=value;
        return this;
    }

    public static Phone CreatePhone() =>new Phone();

    public override string ToString()
    {
        return $"{Id} {Color} {Model} {Size} {Price} {Company}";
    }
    
    
    
}