using Microsoft.AspNetCore.Mvc;
using raylinder.API.Domains;
using raylinder.Models;

namespace raylinder.API.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly IWeatherForecastManager _weatherForecastManager;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(IWeatherForecastManager weatherForecastManager, ILogger<WeatherForecastController> logger)
    {
        _weatherForecastManager = weatherForecastManager;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return _weatherForecastManager.Get();
    }
}
