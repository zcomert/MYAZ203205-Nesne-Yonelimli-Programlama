using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EmployeeWebApi.Controllers;

[ApiController]
[Route("api/employees")]
public class EmployeeController : ControllerBase
{
    private EmployeeRepository repository;

    public EmployeeController(EmployeeRepository repository)
    {
        this.repository = repository;
    }

    [HttpGet]
    public IActionResult GetAllEmployee()
    {
        return Ok(repository.GetAllEmployee());
    }

    [HttpGet("{id}")]
    public IActionResult GetOneEmployee(int id)
    {
        return Ok(repository.GetOneEmployee(id));
    }

    [HttpPost]
    public IActionResult CreateEmployee(string FirstName, string LastName, decimal Salary, int CompanyId)
    {
        var emp = new Employee()
        {
            FirstName = FirstName,
            LastName = LastName,
            Salary = Salary,
            CompanyId = CompanyId
        };
        repository.CreateEmployee(emp);
        return Created("Employee successfully created!", emp);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateOneEmployee(int id, string FirstName, string LastName, decimal Salary, int CompanyId)
    {
        repository.UpdateEmployee(id, new Employee()
        {
            Id = id,
            FirstName = FirstName,
            LastName = LastName,
            Salary = Salary,
            CompanyId = CompanyId
        });
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteOneEmployee(int id)
    {
        return Ok(repository.DeleteOneEmployee(id));
    }
}