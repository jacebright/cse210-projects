using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double Area()
    {
        return _length * _width;
    }
}
