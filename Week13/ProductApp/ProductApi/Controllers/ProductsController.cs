using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace ProductApi.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly RepositoryContext _context;

    public ProductsController(RepositoryContext context)
    {
        _context = context;
        // _context = new RepositoryContext(new DbContextOptionsBuilder<RepositoryContext>().Options);
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var model = _context.Products
        .Include(p => p.Comments);
        
        return Ok(model);
    }
}