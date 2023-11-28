using CircleApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CircleApi.Controllers;
[ApiController]
[Route("api/circle")]
public class CircleController : ControllerBase
{
    [HttpPost("circum")]
    public IActionResult CalculateCircumference(Input input)
    {
        var result = Circle.Circle.CalculateCircumference(input.R);
        Output output = new Output(){
            Result = result
        };
        return Ok(output);
    }

    [HttpGet("area")]
    public IActionResult CalculateArea(double r)
    {
        var result = Circle.Circle.CalculateArea(r);
        return Ok(result);
    }
    [HttpPost]
    public IActionResult Calculate(Input i){
        return Ok(new {
            alan = Circle.Circle.CalculateArea(i.R),
            çevre = Circle.Circle.CalculateCircumference(i.R)
        });
    }
}
