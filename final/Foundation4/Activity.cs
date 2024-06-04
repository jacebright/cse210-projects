public abstract class Activity
{
    private string _date;
    private double _length;
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }
    public virtual double Distance()
    {
        return Math.Round((Speed() / 60) * _length, 2);
    }
    public virtual double Speed()
    {
        return Math.Round((Distance() / _length) * 60, 2);
    }
    public virtual double Pace()
    {
        return Math.Round(_length / Distance(), 2);
    }
    public abstract string GetAct();
    public string GetSummary()
    {
        return $"{_date} {GetAct()} ({_length} min) - Distance {Distance()} miles, Speed {Speed()} mph, Pace: {Pace()} min per mile";
    }
}