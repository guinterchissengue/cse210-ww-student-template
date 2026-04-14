using System;

// Running activity class
public class Running : Activity
{
    // Distance is directly stored in miles
    private double _distance;

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    // Return distance
    public override double GetDistance()
    {
        return _distance;
    }

    // Speed = (distance / minutes) * 60
    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    // Pace = minutes / distance
    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}