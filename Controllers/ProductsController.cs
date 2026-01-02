using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace oms.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[]
            {
                new { Id = 1, Name = "Laptop", Price = 78999, Stock = 20 },
                new { Id = 2, Name = "Mobile", Price = 32999, Stock = 24 },
                new { Id = 3, Name = "Monitor", Price = 10999, Stock = 43 },
            });
        }
    }
}
