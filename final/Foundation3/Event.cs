public abstract class Event
{
    // Regardless of the type, all events need to have an Event Title, 
    // Description, Date, Time, and Address.Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public Event(string title, string description, string date, string time, Address address)
    {
        // main constructor for this base class
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string StandardDetails()
    {
        return $"Event: {_title}\n{_description}\n{_date} at {_time}\nLocation: {_address}";
    }
    public abstract string FullDetails();
    public abstract string ShortDescription();
    public string GetTitle()
    {
        return _title;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public string GetDescription()
    {
        return _description;
    }
}