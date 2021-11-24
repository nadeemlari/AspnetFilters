using Microsoft.AspNetCore.Mvc;

namespace AspnetFilters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [MySampleAsyncActionFilter("Controller")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"};

        

        [HttpGet]
        [MySampleActionFilter("Action",-10)]
        public IEnumerable<WeatherForecast> Get()
        {
            Console.WriteLine("In WeatherForecastController - Get Action");
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public string Get()
        {
            Console.WriteLine("In UserController - Get Action");
            return "hello  world";
        }
    }
}