using EmployeeApp.Models;

// Worker 
Worker worker1 = new Worker();
System.Console.WriteLine(worker1.AtCreatedDate);

Worker worker2 = new Worker(10, "Ahmet", "Tandoğan");
System.Console.WriteLine(worker2.AtCreatedDate);
worker1.Work();
worker2.Work();

// Manager
Manager manager1 = new Manager();
manager1.Id = 501;
manager1.FirstName = "Nisa";
manager1.LastName = "Polat";
System.Console.WriteLine("Manager created date:" + manager1.AtCreatedDate);
System.Console.WriteLine(manager1.FullName);
manager1.Work();

// Manager manager2 = new Manager(20, "Ali", "Şimşek");
// System.Console.WriteLine(manager2.FullName);
// manager2.Work();

// //Assistance
// Assistance assistance1 = new Assistance()
// {
//     Id = 101,
//     FirstName = "Metehan",
//     LastName = "Güzel"
// };
// System.Console.WriteLine(assistance1);
// assistance1.Work();

// // Student

// Student student1 = new Student()
// {
//     Id = 15,
//     FirstName = "Hafsa",
//     LastName = "Çataklı"
// };
// student1.Work();
// student1.DoIntern();

static void EmployeeExample()
{
    Employee emp1 = new Employee();
    emp1.Id = 1;
    emp1.FirstName = "Enes";
    emp1.LastName = "Şahin";
    // emp1.FullName = "Metehan Güzel";
    System.Console.WriteLine(emp1.FullName);
    System.Console.WriteLine(emp1.AtCreatedDate);

    Employee emp2 = new Employee(5, "Bahar", "Erol");
    System.Console.WriteLine(emp2.FullName);
    System.Console.WriteLine(emp2.AtCreatedDate);

    Employee emp3 = new Employee("Hamza", "Çarıkcı");
    System.Console.WriteLine(emp3.FullName);
    System.Console.WriteLine(emp3.AtCreatedDate);
}