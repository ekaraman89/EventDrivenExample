using EventDrivenExample.Events;
using EventDrivenExample.Services.Abstract;

namespace EventDrivenExample.Services.Concrete
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public event EventHandler<WeatherForecastEventArgs> OnWeatherTransactionProcessed;

        private static readonly string[] _summaries = new[]
        { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

        public IEnumerable<WeatherForecast> GetWeatherForecast(int days)
        {
            WeatherForecast[] weatherForecasts = Enumerable.Range(1, days).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = _summaries[Random.Shared.Next(_summaries.Length)]
            }).ToArray();

            OnWeatherTransactionProcessed(this, new WeatherForecastEventArgs(days));

            return weatherForecasts;
        }
    }
}