Product prd1 = new Product();
prd1.Id = 5;
prd1.Name = "Computer";
prd1.Price = 40_000;
prd1.Quantity = 2;

System.Console.WriteLine(prd1.NameWithPrice);
prd1.Name = "HP Z8 G4 Workstation";
System.Console.WriteLine(prd1.NameWithPrice);
System.Console.WriteLine(prd1.AtCreatedDate);

var prd2 = new Product(3,"AirPods",6_000,2);
System.Console.WriteLine(prd2.NameWithPrice);
System.Console.WriteLine(prd2.AtCreatedDate);

var prd3 = new Product("iPhone",52_000);