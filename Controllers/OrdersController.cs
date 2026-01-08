using Microsoft.AspNetCore.Mvc;

namespace apiTask.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllOrders()
    {
        return Ok(new[] { "Order#1", "Order#2" });
    }
    
    [HttpGet("{id}")]
    public IActionResult GetOrderById(int id)
    {
        return Ok($"Order with ID = {id}");
    }
    
    [HttpPost]
    public IActionResult CreateOrder(string orderName)
    {
        return Ok($"Order {orderName} created");
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteOrder(int id)
    {
        return Ok($"Order with ID = {id} deleted");
    }

}