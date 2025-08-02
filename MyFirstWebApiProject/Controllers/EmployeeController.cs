using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApiProject.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Returning From EmployeeController";
    }
}