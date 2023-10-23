// 
using System.Data;

Product prd1 = new Product();
prd1.Name = "Süt";
prd1.Price = 25F;
prd1.Quantity = 4;
prd1.GeneratedDate = DateTime.Now;

var prd2 = new Product()
{
    Name = "Su",
    Price = 17.5f
};

System.Console.WriteLine(prd2.Name);

System.Console.WriteLine(prd1.Name);
System.Console.WriteLine(prd1.Quantity);
System.Console.WriteLine(prd1.GeneratedDate);
System.Console.WriteLine(prd1.Price);
System.Console.WriteLine(prd1.GetTotalPrice());



static void CarModel()
{
    // instance 
    Car car1 = new Car();
    int a = 5;
    string name1 = "Eren";
    string name2 = new string("Can");
    car1.model = "TOGG";
    car1.year = 2013;
    System.Console.WriteLine(car1.model);
    System.Console.WriteLine(car1.year);
    System.Console.WriteLine(car1.GetAvaregeConsume(825.25f));
}
