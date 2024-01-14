using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace LibraryApi.Controllers;

[ApiController]
[Route("api/books")]
public class BooksController : ControllerBase
{
    private BookRepository repository { get; set; }

    public BooksController(BookRepository repository)
    {
        this.repository = repository;
    }

    [HttpGet("{id}")]
    public IActionResult GetOne(int id)
    {
        var item = repository.BookInfo(id);
        if (item is null)
            return NotFound($"With {id} id book not found!");
        return Ok(item);
    }

    [HttpPost]
    public IActionResult Post(Books book)
    {
        repository.AddBook(new Books()
        {
            Title = book.Title,
            PublishDate = book.PublishDate,
            Quantity = book.Quantity
        });

        return Created("Book added in library!", book);
    }

    [HttpPut("borrow/{id}")]
    public IActionResult PutBorrow([FromRoute] int id)
    {
        repository.Borrow(id);
        return NoContent();
    }

    [HttpPut("return/{id}")]
    public IActionResult PutReturn([FromRoute] int id)
    {
        repository.Return(id);
        return NoContent();
    }
}