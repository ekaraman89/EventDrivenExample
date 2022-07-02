namespace EventDrivenExample.Services.Abstract
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForecast(int days);
    }
}