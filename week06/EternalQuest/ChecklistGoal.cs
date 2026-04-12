using System;

// This goal needs to be completed multiple times
public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    // Constructor used when loading saved data
    public ChecklistGoal(string name, string description, int points, int target, int count, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _count = count;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _count++;

        if (_count == _target)
        {
            return _points + _bonus;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return _count >= _target;
    }

    public override string GetStatus()
    {
        return $"[{(_count >= _target ? "X" : " ")}] Completed {_count}/{_target}";
    }

    public override string GetSaveString()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_target}|{_count}|{_bonus}";
    }
}