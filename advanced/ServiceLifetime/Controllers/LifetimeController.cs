using Microsoft.AspNetCore.Mvc;

namespace ServiceLifetime.Controllers
{
    public class LifetimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
