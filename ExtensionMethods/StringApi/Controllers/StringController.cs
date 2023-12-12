using Microsoft.AspNetCore.Mvc;
using StringApi.Models;
using StringLib;

namespace StringApi.Controllers;

[ApiController]
[Route("api")]
public class StringController : ControllerBase
{
    [HttpPost]
    public IActionResult NumberOfSpace([FromBody] String input)
    {
        // StringOperation so = new StringOperation();
        // var result = StringOperation.NumberOfSpaces(input);

        return Ok(new Output
        {
            NumberOfSpace = input.NumberOfSpaces()
        });
    }
}