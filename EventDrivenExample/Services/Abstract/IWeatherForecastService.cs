using EventDrivenExample.Events;

namespace EventDrivenExample.Services.Abstract
{
    public interface IWeatherForecastService
    {
        event EventHandler<WeatherForecastEventArgs> OnWeatherTransactionProcessed;

        IEnumerable<WeatherForecast> GetWeatherForecast(int days);
    }
}