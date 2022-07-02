namespace EventDrivenExample.Events
{
    public class WeatherForecastEventArgs : EventArgs
    {
        public int Days { get; set; }

        public WeatherForecastEventArgs(int days)
        {
            Days = days;
        }
    }
}