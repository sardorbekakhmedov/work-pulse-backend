using Microsoft.AspNetCore.Mvc;

namespace WorkPulse.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Test is working!!!  :)");
    }
}