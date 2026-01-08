using Microsoft.AspNetCore.Mvc;

namespace apiTask.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllUsers()
    {
        return Ok(new[] { "Afnan", "Sara", "Ali" });
    }
    
    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        return Ok($"User with ID = {id}");
    }
    
    [HttpPost]
    public IActionResult CreateUser(string name)
    {
        return Ok($"User {name} created successfully");
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id)
    {
        return Ok($"User with ID = {id} deleted");
    }

}
