using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace oms.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[]
            {
                new { Id = 1, UserId=1, ProductId=1, Quantity=2, TotalPrice=78999, Date="2026-01-01"},
                new { Id = 2, UserId=3, ProductId=2, Quantity=3, TotalPrice=65998, Date="2026-01-01"},
                new { Id = 3, UserId=2, ProductId=2, Quantity=1, TotalPrice=65998, Date="2026-01-02"},
                new { Id = 4, UserId=1, ProductId=2, Quantity=2, TotalPrice=65998, Date="2026-01-02"},
                new { Id = 5, UserId=2, ProductId=3, Quantity=1, TotalPrice=32997, Date="2026-01-02"},
                new { Id = 6, UserId=3, ProductId=3, Quantity=2, TotalPrice=32997, Date="2026-01-03"},
            });
        }
    }
}
