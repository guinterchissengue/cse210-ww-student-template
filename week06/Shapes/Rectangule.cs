// rectangle class
public class Rectangle : Shape
{
    private double _width;
    private double _height;

    // constructor
    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    // calculate area of rectangle
    public override double GetArea()
    {
        return _width * _height;
    }
}