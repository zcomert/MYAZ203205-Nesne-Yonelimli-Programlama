using ProductApp.Models;

var phone1 = new Phone()
{
    Name = "Galaxy Note 7",
    Price = 13_000
};
System.Console.WriteLine(phone1.AtCreatedDate);

phone1.Sale();

var phone2 = new Phone("iPhone 14 Pro 128 GB", 72_000);
phone2.Sale();

var car1 = new Car()
{
    Color = "blue",
    NumberofWheels = 4
};

car1.Drive ();
car1.Stop ();
car1.Sale();

SporCar sportCar1 = new SporCar();
sportCar1.Drive();
sportCar1.OpenTurbo();
sportCar1.Stop();
sportCar1.Sale();

static void ProductExample()
{
    Product prd1 = new Product();
    prd1.Id = 5;
    prd1.Name = "Computer";
    prd1.Price = 40_000;
    prd1.Quantity = 2;

    System.Console.WriteLine(prd1.NameWithPrice);
    prd1.Name = "HP Z8 G4 Workstation";
    System.Console.WriteLine(prd1.NameWithPrice);
    System.Console.WriteLine(prd1.AtCreatedDate);

    var prd2 = new Product(3, "AirPods", 6_000, 2);
    System.Console.WriteLine(prd2.NameWithPrice);
    System.Console.WriteLine(prd2.AtCreatedDate);

    var prd3 = new Product("iPhone", 52_000);
}