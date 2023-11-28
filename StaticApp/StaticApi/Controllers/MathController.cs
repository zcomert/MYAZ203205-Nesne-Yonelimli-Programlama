using Microsoft.AspNetCore.Mvc;
using StaticApi.Models;
namespace StaticApi.Controllers;
[ApiController]
[Route("api/math")]
public class MathController : ControllerBase
{
    [HttpPost("add")]
    public IActionResult Add(Input input){
        var output=new Output();
        output.Result=MathLib.MathHelper.Add(input.X,input.Y);
        return Ok(output);
    }
    [HttpGet("sub")]
    public IActionResult Sub(int a ,int b){
        return Ok(MathLib.MathHelper.Sub(a,b));
    }
    [HttpGet("Mul")]
    public IActionResult Mul(int a ,int b){
        return Ok(MathLib.MathHelper.Mul(a,b));
    }
    [HttpGet("div")]
    public IActionResult Div(int a ,int b){
        return Ok(MathLib.MathHelper.Div(a,b));
    }
}