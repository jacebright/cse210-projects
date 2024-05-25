using System.ComponentModel;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int completed, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = completed;
        _target = target;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        // Record a goal event by marking it completed
        _amountCompleted += 1;
        int points = GetPoints();
        if (IsComplete())
        {
            points += _bonus;
            Console.WriteLine($"Congratulations on completing your {GetName()} goal!");
        }
        return points;
    }
    public override bool IsComplete()
    {
        // Check if a goal is completed
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {GetName()} ({GetDescription()} -- Currently completed: {_amountCompleted}/{_target})";
        }
        else
        {
            return $"[ ] {GetName()} ({GetDescription()} -- Currently completed: {_amountCompleted}/{_target})";
        }
    }
}