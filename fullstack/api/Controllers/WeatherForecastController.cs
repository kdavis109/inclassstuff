using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

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
    public List<string>  Get()
    {
    List<string> myBooks = new List<string>();
         myBooks.Add("Mistborn");
         myBooks.Add("Oathbringer");
        return myBooks;
        //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
       // {
        //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
       //     TemperatureC = Random.Shared.Next(-20, 55),
      //      Summary = Summaries[Random.Shared.Next(Summaries.Length)]
       // })
      //  .ToArray();
    }
}
