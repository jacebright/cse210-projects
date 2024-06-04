public class BicycleActivity : Activity
{
    private double _speed;
    public BicycleActivity(string date, double length, double speed) : base (date, length)
    {
        _speed = speed;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override string GetAct()
    {
        return "Cycling";
    }
}