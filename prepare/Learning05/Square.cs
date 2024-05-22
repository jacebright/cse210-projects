using System.ComponentModel.DataAnnotations;

public class Square : Shape
{
    private double _lengthSide;
    public Square(double length, string color) : base(color)
    {
        _lengthSide = length;
    }

    public override double Area()
    {
        return _lengthSide * _lengthSide;
    }
}
