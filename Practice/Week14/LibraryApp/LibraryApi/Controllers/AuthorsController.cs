using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace LibraryApi.Controllers;

[ApiController]
[Route("api/authors")]
public class AuthorsController : ControllerBase
{
    private AuthorRepository repository { get; set; }

    public AuthorsController(AuthorRepository repository)
    {
        this.repository = repository;
    }

    [HttpGet("{id}")]
    public IActionResult GetOne(int id)
    {
        var item = repository.AuthorInfo(id);
        if (item is null)
            return NotFound($"With {id} id book not found!");
        return Ok(item);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Authors author)
    {
        repository.AddAuthor(new Authors()
        {
            FirstName = author.FirstName,
            MiddleName = author.MiddleName,
            LastName = author.LastName
        });
        return Created("Author added database!", author);
    }
}