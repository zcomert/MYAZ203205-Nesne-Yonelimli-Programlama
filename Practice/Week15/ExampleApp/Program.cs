using Entities;
using ExampleApp.Repositories;

// 0: Incomplete, 1: Complete, 2: Expired
var task = new Tasks(1, "Posta yollama", 0, 1, 0);
var task1 = new Tasks(2, "Excell oluşturulması", 0, 2, 0);
var task2 = new Tasks(3, "Sitenin güncellenmesi", 0, 2, 1);

EmployeeRepository.AddEmployee(new Employee()
{
    FirstName = "Ali",
    LastName = "Melek",
});

EmployeeRepository.AddTask(0, task);
EmployeeRepository.AddTask(0, task1);
EmployeeRepository.AddTask(0, task2);

Console.WriteLine(EmployeeRepository.GetOneEmployee(0).ToString());

Console.ReadKey();