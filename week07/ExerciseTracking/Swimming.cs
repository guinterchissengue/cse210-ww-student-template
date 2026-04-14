using System;

// Swimming activity class
public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    // Convert laps to miles
    // 1 lap = 50 meters
    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62;
    }

    // Speed = (distance / minutes) * 60
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    // Pace = minutes / distance
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}