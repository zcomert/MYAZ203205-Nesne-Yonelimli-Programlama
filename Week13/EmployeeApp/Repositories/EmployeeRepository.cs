using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;

namespace Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private RepositoryContext context;

    public EmployeeRepository(RepositoryContext context)
    {
        this.context = context;
    }

    // Create
    public void CreateEmployee(Employee employee)
    {
        if (employee.FirstName is null || employee.LastName is null || employee.Salary <= 0)
            throw new Exception("Required field is null!");

        context.Employees.Add(employee);
        context.SaveChanges();
    }

    // Delete
    public Employee DeleteOneEmployee(int id)
    {
        var emp = GetOneEmployee(id);
        context.Employees.Remove(emp);
        context.SaveChanges();
        return emp;
    }

    public List<Employee> GetAllEmployee()
    {
        return context.Employees.ToList();
    }

    public Employee GetOneEmployee(int id)
    {
        return context.Employees
        .Include(c => c.Company)
        .SingleOrDefault(emp => emp.Id.Equals(id));
    }

    public void UpdateEmployee(int id, Employee employee)
    {
        if (employee.FirstName is null || employee.LastName is null || employee.Salary <= 0)
            throw new Exception("Required field is null!");

        var emp = GetOneEmployee(id);
        
        emp.FirstName = employee.FirstName;
        emp.LastName = employee.LastName;
        emp.Salary = employee.Salary;

        // context.Employees.Update(employee);
        context.SaveChanges();
    }
}