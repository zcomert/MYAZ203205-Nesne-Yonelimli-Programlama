using IntLib;
using Microsoft.AspNetCore.Mvc;

namespace IntApi.Controllers;

[ApiController]
[Route("api")]
public class IntegerController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetUntilNumber(int id)
    {
        return Ok(id.UntilNumber());
    }
}