using SortApp.Models;

var employees = new List<Employee>();
employees.Add(new Employee(){FirstName="ismail",LastName="bülbül",Salary=20_000});
employees.Add(new Employee(){FirstName="ayşe",LastName="kaya",Salary=15_000});
employees.Add(new Employee(){FirstName="yuşa",LastName="sdsd",Salary=45_000});
employees.Add(new Employee(){FirstName="ahmet",LastName="büdssdül",Salary=10_000});


Console.WriteLine($"Size of list :{employees.Count}");
foreach (var employee in employees)
{
    System.Console.WriteLine(employee);
}

employees.Sort();

System.Console.WriteLine(new String('-',5));
foreach (var number in employees)
{
    System.Console.WriteLine(number);
}

System.Console.WriteLine(new String('-',5));

var clonedEmployee = employees[0].Clone();
System.Console.WriteLine(((Employee)clonedEmployee).FirstName);
