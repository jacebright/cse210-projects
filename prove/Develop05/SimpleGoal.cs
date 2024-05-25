using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, string points) : base(name, description, points){}
    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override int RecordEvent()
    {
        // Record a goal event by marking it completed
        _isComplete = true;
        return GetPoints();
    }
    public override bool IsComplete()
    {
        // Check if a goal is completed
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
}