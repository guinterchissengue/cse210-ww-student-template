using System;

// Cycling activity class
public class Cycling : Activity
{
    // Speed is stored in mph
    private double _speed;

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    // Distance = speed * time
    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    // Return stored speed
    public override double GetSpeed()
    {
        return _speed;
    }

    // Pace = 60 / speed
    public override double GetPace()
    {
        return 60 / _speed;
    }
}