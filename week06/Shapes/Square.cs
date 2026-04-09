// square class
public class Square : Shape
{
    private double _side;

    // constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // calculate area of square
    public override double GetArea()
    {
        return _side * _side;
    }
}