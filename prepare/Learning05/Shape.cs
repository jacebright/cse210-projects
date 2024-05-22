using System.Drawing;

public abstract class Shape
{
    private string _color;
    public string GetColor()
    {
        return _color;
    }
    public Shape(string color)
    {
        _color = color;
    }
    public abstract double Area();
}