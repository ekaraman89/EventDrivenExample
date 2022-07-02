using EventDrivenExample.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EventDrivenExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly IAuditService _auditService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService, IAuditService auditService)
        {
            _weatherForecastService = weatherForecastService;
            _auditService = auditService;
            _auditService.Subscribe(_weatherForecastService);
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get(int days)
        {
            IEnumerable<WeatherForecast> weatherForecasts = _weatherForecastService.GetWeatherForecast(days);

            return weatherForecasts;
        }
    }
}