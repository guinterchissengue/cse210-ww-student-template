using System;

// circle class
public class Circle : Shape
{
    private double _radius;

    // constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // calculate area of circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}