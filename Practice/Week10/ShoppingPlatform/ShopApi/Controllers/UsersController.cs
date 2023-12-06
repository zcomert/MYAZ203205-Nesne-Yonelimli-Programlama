using Microsoft.AspNetCore.Mvc;
using ShopEntities.Models;
using ShopRepositories.Repositories;

namespace ShopApi.Controller;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private UsersRepository repository;

    public UsersController(UsersRepository repository)
    {
        this.repository = repository;
    }

    [HttpDelete]
    public void Delete()
    {
        repository.Delete();
    }

    [HttpDelete("{id:int}")]
    public void DeleteOne(int id)
    {
        repository.DeleteOne(id);
    }

    [HttpGet]
    public List<Users> GetAll()
    {
        return repository.GetAll();
    }

    [HttpGet("{id:int}")]
    public Users GetOne(int id)
    {
        return repository.GetOne(id);
    }

    [HttpPost]
    public void Post(Users item)
    {
        repository.Post(item);
    }

    [HttpPut("{id:int}")]
    public void Update(int id, Users item)
    {
        repository.Update(id, item);
    }
}