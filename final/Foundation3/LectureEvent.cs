public class LectureEvent : Event
{
    // Lectures, which have a speaker and have a limited capacity.
    private string _speaker;
    private int _capacity;
    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string FullDetails()
    {
        return $"Type: Lecture\n{StandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
    public override string ShortDescription()
    {
        return $"Type: Lecture\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }
}