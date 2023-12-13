public class Outdoor : Event
{
    private string _WeatherForecast;
    private Address address;

    //constructor
    public Outdoor(string title, string description, DateTime date, string time, Address location, string weatherForecast) : base(title, description, date, time, location)
    {
        _WeatherForecast = weatherForecast;
    }

    //setters
    public void SetWeatherForecast(string weatherForecast)
    {
        _WeatherForecast = weatherForecast;
    }
    //getters
    public string GetWeatherForecast()
    {
        return _WeatherForecast;
    }
    //return string with full details of the event
    public string GetFullDetails()
    {
        return base.GetSimpleDetails() + $"\nWeather Forecast: {_WeatherForecast}"+ "\n";
    }
}