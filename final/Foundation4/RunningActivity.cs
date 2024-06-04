using System.Security.Cryptography.X509Certificates;

public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, double length, double distance) : base (date, length)
    {
        _distance = distance;
    }
    public override double Distance()
    {
        return _distance;
    }
    public override string GetAct()
    {
        return "Running";
    }
}