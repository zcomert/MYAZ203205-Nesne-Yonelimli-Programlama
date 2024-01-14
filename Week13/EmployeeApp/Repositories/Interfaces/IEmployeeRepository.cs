using Entities.Models;

namespace Repositories.Interfaces;

public interface IEmployeeRepository
{
    public Employee GetOneEmployee(int id);
    public List<Employee> GetAllEmployee();
    // public List<Employee> GetAllEmployeeByCompany(int companyId);
    public void CreateEmployee(Employee employee);
    public void UpdateEmployee(int id, Employee employee);
    public Employee DeleteOneEmployee(int id);
}