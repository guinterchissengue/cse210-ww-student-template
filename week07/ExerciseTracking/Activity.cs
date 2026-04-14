using System;

// Base abstract class for all activities
public abstract class Activity
{
    // Private fields 
    private string _date;
    private int _minutes;

    // Constructor
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Getter for date
    public string GetDate()
    {
        return _date;
    }

    // Getter for minutes
    public int GetMinutes()
    {
        return _minutes;
    }

    // Abstract methods 
    public abstract double GetDistance(); // in miles
    public abstract double GetSpeed();    // in mph
    public abstract double GetPace();     // minutes per mile

    // Common method to display summary
    public virtual string GetSummary()
    {
        // Calls polymorphic methods
        return $"{_date} {this.GetType().Name} ({_minutes} min) - " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.00} min per mile";
    }
}