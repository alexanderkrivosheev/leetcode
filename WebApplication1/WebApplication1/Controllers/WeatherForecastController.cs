using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<Guid> _current= new List<Guid>();
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _current.Add(Guid.NewGuid());
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var test = _current.GroupBy(x => x);
            foreach (var item in test)
            {
                if (item.Count() > 1) 
                { 
                }
            }

            return Enumerable.Range(1, 1).Select(index => new WeatherForecast
            {               
                Summary = _current.ToString()
            })
            .ToArray();

       

        }
    }
}