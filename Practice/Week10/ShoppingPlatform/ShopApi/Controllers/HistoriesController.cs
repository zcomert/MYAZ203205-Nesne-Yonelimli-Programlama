using Microsoft.AspNetCore.Mvc;
using ShopEntities.Models;
using ShopRepositories.Repositories;

namespace ShopApi.Controller;

[ApiController]
[Route("api/histories")]
public class HistoriesController : ControllerBase
{
    private HistoriesRepository repository;

    public HistoriesController(HistoriesRepository repository)
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
    public List<Histories> GetAll()
    {
        return repository.GetAll();
    }

    [HttpGet("{id:int}")]
    public Histories GetOne(int id)
    {
        return repository.GetOne(id);
    }

    [HttpPost]
    public void Post(Histories item)
    {
        repository.Post(item);
    }

    [HttpPut("{id:int}")]
    public void Update(int id, Histories item)
    {
        repository.Update(id, item);
    }
}