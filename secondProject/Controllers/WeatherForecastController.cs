using Microsoft.AspNetCore.Mvc;

namespace secondProject.Controllers;

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

        [HttpGet("strings")]
        public ActionResult<IEnumerable<string>> GetStrings()
        {
            List<string> stringList = new List<string>
            {
                "Hello",
                "World",
                "How",
                "Are",
                "You"
            };

            return Ok(stringList);
        }
}
