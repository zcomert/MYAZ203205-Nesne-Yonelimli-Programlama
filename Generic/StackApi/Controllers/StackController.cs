using Microsoft.AspNetCore.Mvc;
using Stack.Contracts;
using StackApi.Models;

namespace StackApi.Controllers;
[ApiController]
[Route("api/employee")]
public class StackController:ControllerBase
{
    private IStack<Employee> _stack;

    public StackController()
    {
        _stack = new Stack.Stack<Employee>();
        _stack.Push(new Employee(){Id=1,FirstName="Mohammed",LastName="Almashhor"});
        _stack.Push(new Employee(){Id=2,FirstName="Ali",LastName="Daa"});
        _stack.Push(new Employee(){Id=3,FirstName="Ahemt",LastName="ALi"});
    }
    [HttpGet]
    public IActionResult Peek(){
        return Ok(_stack.Peek());
    }
}