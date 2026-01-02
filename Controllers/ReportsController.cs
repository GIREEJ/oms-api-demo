using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace oms.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[]
            {
                new { Id = 1, ProductId=1, TotalSold=2, TotalRevenue=157998 },
                new { Id = 2, ProductId=2, TotalSold=2, TotalRevenue=395988},
                new { Id = 3, ProductId=3, TotalSold=2, TotalRevenue=98991}
            });
        }
    }
}
