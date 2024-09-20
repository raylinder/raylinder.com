using raylinder.Models;

namespace raylinder.API.Domains;

public interface IWeatherForecastManager
{
    public IEnumerable<WeatherForecast> Get();
}