using Microsoft.AspNetCore.Mvc;

namespace WorkPulseApi.Controllers;

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