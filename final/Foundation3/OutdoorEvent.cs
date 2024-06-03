public class OutdoorEvent : Event
{
    // Outdoor gatherings, which do not have a limit on attendees, but need to 
    // track the weather forecast.
    private string _weather;
    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base (title, description, date, time, address)
    {
        _weather = weather;
    }
    public override string FullDetails()
    {
        return $"Type: Outdoor Gathering\n{StandardDetails()}\nWeather Forecast: {_weather}";
    }
    public override string ShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }
}