using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace RestaurantApi.Controller;

[ApiController]
[Route("api/items")]
public class ItemsController : ControllerBase
{
    private ItemRepository repository;

    public ItemsController(ItemRepository repository)
    {
        this.repository = repository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(repository.GetAll());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetOne(int id)
    {
        var item = repository.GetOne(id);
        if (item is null)
            throw new Exception("");
        return Ok(item);
    }

    [HttpPost]
    public IActionResult Post(Items item)
    {
        if (item is null)
            return BadRequest();
        repository.Post(item);
        return Created("Item added!", item);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        repository.Delete(id);
        return NoContent();
    }

}