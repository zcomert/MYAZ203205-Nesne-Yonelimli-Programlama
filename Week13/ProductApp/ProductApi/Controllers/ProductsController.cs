using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace ProductApi.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly ProductRepository repository;

    public ProductsController(ProductRepository repository)
    {
        this.repository = repository;

        // _context = new RepositoryContext(new DbContextOptionsBuilder<RepositoryContext>().Options);
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        return Ok(repository.GetAllProduct());
    }

    [HttpGet("{id}")]
    public IActionResult GetOneProducts(int id)
    {
        return Ok(repository.GetOneProduct(id));
    }

    [HttpPost]
    public IActionResult CreateProduct(string ProductName, decimal Price)
    {
        var prd = new Product(){
            ProductName = ProductName,
            Price = Price
        };
        repository.CreateProduct(prd);
        return Created("Product is created!", prd);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, string ProductName, decimal Price)
    {
        var prd = new Product(){
            ProductName = ProductName,
            Price = Price
        };
        repository.UpdateProduct(id, prd);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteOneProduct(int id)
    {
        return Ok(repository.DeleteOneProduct(id));
    }
}