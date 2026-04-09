// base class for all shapes
public class Shape
{
    private string _color;

    // constructor
    public Shape(string color)
    {
        _color = color;
    }

    // get the color
    public string GetColor()
    {
        return _color;
    }

    // set the color
    public void SetColor(string color)
    {
        _color = color;
    }

    // method to get area (will be different in other classes)
    public virtual double GetArea()
    {
        return 0;
    }
}