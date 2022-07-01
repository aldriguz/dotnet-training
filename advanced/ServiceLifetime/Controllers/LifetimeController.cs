using Microsoft.AspNetCore.Mvc;
using ServiceLifetime.Interfaces;
using System.Text;

namespace ServiceLifetime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LifetimeController : ControllerBase
    {
        private readonly IScopedService _scoped;
        private readonly ITransientService _transient;
        private readonly ISingletonService _singleton;

        public LifetimeController(IScopedService scoped, ITransientService transient, ISingletonService singleton)
        {
            _scoped = scoped;
            _transient = transient;
            _singleton = singleton;
        }

        public IActionResult Index()
        {
            var scoped_ticks = HttpContext.Items["scoped-ticks"];
            var transient_ticks = HttpContext.Items["transient-ticks"];
            var singleton_ticks = HttpContext.Items["singleton-ticks"];

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Dependency: {_scoped.GetTimeTicks()} vs Middleware: {scoped_ticks} (both are the same on every refresh)");
            result.AppendLine($"Dependency: {_transient.GetTimeTicks()} vs Middleware: {transient_ticks} (changes on every refresh, both different)");
            result.AppendLine($"Dependency: {_singleton.GetTimeTicks()} vs Middleware: {singleton_ticks} (always the same value during runtime)");

            return Ok(result.ToString());
        }
    }
}
