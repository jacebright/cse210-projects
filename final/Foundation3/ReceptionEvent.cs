public class ReceptionEvent : Event
{
    // Receptions, which require people to RSVP, or register, beforehand.
    private string _rsvp;
    public ReceptionEvent(string title, string description, string date, string time, Address address, string rsvp) : base (title, description, date, time, address)
    {
        _rsvp = rsvp;
    }
    public override string FullDetails()
    {
        return $"Type: Reception\n{StandardDetails()}\nRSVP to {_rsvp}";
    }
    public override string ShortDescription()
    {
        return $"Type: Reception\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }
}