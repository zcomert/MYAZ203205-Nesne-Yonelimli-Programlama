using ProductSortApp.Models;

var products = new List<Product>();

products.Add(new Product("Computer",30000));
products.Add(new Product(){Name =  "Airpods",Price = 5678});
products.Add(new Product(){Name =  "Car",Price = 1000000});
products.Add(new Product(){Name =  "Mouse",Price = 1234});
products.Add(new Product(){Name =  "Hoparlör",Price = 3456});



foreach (var product in products)
{
    Console.WriteLine(product);
}

products.Sort();

Console.WriteLine(new String('-',20));

foreach (var number in products)
{
    Console.WriteLine(number);
}

// listedeki ilk elemanın bir klonunu oluştur!
var item = products[0].Clone();
// klonladığın elemanın fiyatı ve adını yazdır. 
System.Console.WriteLine(item.GetType());
System.Console.WriteLine(item);
Console.ReadLine();
