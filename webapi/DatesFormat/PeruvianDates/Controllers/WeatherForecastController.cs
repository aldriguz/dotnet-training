using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace PeruvianDates.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            CultureInfo culture = new CultureInfo("es-PE");

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.UtcNow,
                DateString = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture),
                LocalDate = DateTime.UtcNow.ToLocalTime(),
                LocalDateString = DateTime.UtcNow.ToLocalTime().ToString("f", culture),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                Culture = CultureInfo.CurrentCulture.Name
            })
            .ToArray();
        }
    }
}