using Microsoft.AspNetCore.Mvc;
using ServiceLifetime.Interfaces;

namespace ServiceLifetime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LifetimeController : ControllerBase
    {
        private readonly IScopedService _scopedService;
        public LifetimeController(IScopedService scopedService)
        {
            _scopedService = scopedService;
        }

        public IActionResult Index()
        {
            return Ok(_scopedService.GetTimeTicks());
        }
    }
}
