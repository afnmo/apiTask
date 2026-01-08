using Microsoft.AspNetCore.Mvc;

namespace apiTask.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllProducts()
    {
        return Ok(new[] { "Laptop", "Phone", "Tablet" });
    }
    
    [HttpGet("{id}")]
    public IActionResult GetProductById(int id)
    {
        return Ok($"Product with ID = {id}");
    }
    
    [HttpPost]
    public IActionResult AddProduct(string productName)
    {
        return Ok($"Product {productName} added");
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        return Ok($"Product with ID = {id} deleted");
    }

}