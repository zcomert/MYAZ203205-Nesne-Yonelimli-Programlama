using demo1.Models;
using demo1.Repository;
using Microsoft.EntityFrameworkCore;
var phone = Phone.CreatePhone()
.SetModel("Venüs")
.SetSize(4)
.SetPrice(20000)
.SetColor("Mavi");
phone.Company = new Company()
{
    Name="Vestel",
    Country="Türkiye"
};

var context = new RepositoryContext();

context.Phones.Add(phone);
context.SaveChanges();
GetAllCompanies();
GetAllPhones();

static void GetAllCompanies()
{
    var context = new RepositoryContext();

    var companies = context.Companies.ToList();

    foreach (var company in companies)
    {
        Console.WriteLine(company);
    }

    Console.ReadKey();
}

static void GetAllPhones()
{
    var context = new RepositoryContext();

    context
        .Phones
        .ToList()
        .ForEach(p => System.Console.WriteLine(p));

    Console.ReadLine();
}

static void GetAllPhonesWithCompanies()
{
    var context = new RepositoryContext();
    var phones = context
        .Phones
        .Include(p => p.Company)
        .ToList();

    foreach (var phone in phones)
    {
        System.Console.WriteLine(phone);
    }

    Console.ReadLine();
}




























// var phone2 = new Phone()
// {
//     Model="iPhone",
//     Size=10.2,
//     Price=1000,
//     Id=1,
//     Color="Red",
//     CompanyId=1,
//     Company=new Company()
//     {
//         CompanyId=1,
//         Name="Apple",
//         Country="USA"
//     }
// };


// var phone = Phone
//         .CreatePhone()
//         .SetModel("iPhone")
//         .SetSize(6.1)
//         .SetId(1)
//         .SetColor("Siyah")
//         .SetPrice(30000);

// System.Console.WriteLine(phone2);


