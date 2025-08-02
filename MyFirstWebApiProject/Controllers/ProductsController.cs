using Microsoft.AspNetCore.Mvc;
using MyFirstWebApiProject.Models;

namespace MyFirstWebApiProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private static List<Product> _products =
    [
        new Product { Id = 1, Name = "Laptop", Price = 1000.00m, Category = "Electronics" },
        new Product { Id = 2, Name = "Desktop", Price = 2000.00m, Category = "Electronics" },
        new Product { Id = 3, Name = "Mobile", Price = 300.00m, Category = "Electronics" }
    ];

    [HttpGet()]
    public ActionResult<IEnumerable<Product>> GetProductAll()
    {
        return Ok(_products);
    }

    [HttpGet("{id}")]
    public ActionResult<Product> GetProduct(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound(new { message = "Product Not Found" });
        }
        return Ok(product);
    }

    [HttpPost]
    public ActionResult<Product> PostProduct([FromBody] Product product)
    {
        product.Id = _products.Max(p => p.Id) + 1;
        _products.Add(product);
        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public ActionResult<Product> PutProduct(int id, [FromBody] Product product)
    {
        var productToUpdate = _products.FirstOrDefault(p => p.Id == id);
        if (productToUpdate == null)
        {
            return NotFound(new { message = "Product Not Found" });
        }
        productToUpdate.Name = product.Name;
        productToUpdate.Price = product.Price;
        productToUpdate.Category = product.Category;
        
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult<Product> DeleteProduct(int id)
    {
        var productToDelete = _products.FirstOrDefault(p => p.Id == id);
        if (productToDelete == null)
        {
            return NotFound(new { message = "Product Not Found" });
        }
        _products.Remove(productToDelete);
        return NoContent();
    }
}