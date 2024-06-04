public class SwimmingActivity : Activity
{
    private double _laps;
    public SwimmingActivity(string date, double length, int laps) : base (date, length)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override string GetAct()
    {
        return "Swimming";
    }
}