using Microsoft.AspNetCore.Mvc;
using MyFirstWebApiProject.Data;
using MyFirstWebApiProject.Models;

namespace MyFirstWebApiProject.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    public ActionResult<Employee> GetAllEmployees()
    {
        var employee =  EmployeeData.Employees.ToList();
        return Ok(employee);
    }

    [HttpGet("{id}")]
    public ActionResult<Employee> GetEmployeeById(int id)
    {
        var employee = EmployeeData.Employees.FirstOrDefault(e => e.Id == id);
        if(employee == null)
            return NotFound("Employee with ID {id} not Found");
        
        return Ok(employee);
    }
}