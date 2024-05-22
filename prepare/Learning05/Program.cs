using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square(4, "Blue");
        Square s2 = new Square(13.2, "Purple");
        Rectangle r1 = new Rectangle(12, 3, "Red");
        Rectangle r2 = new Rectangle(4.98, 23, "Black");
        Circle c1 = new Circle(12, "Rainbow");
        Circle c2 = new Circle(9.2, "Orange");
        Circle c3 = new Circle(34, "Pink");

        List<Shape> Shapes = [s1, c1, r1, s2, r2, c2, c3];

        foreach (Shape shape in Shapes)
        {
            Console.WriteLine($"The shape on the {shape.GetColor()} piece of paper has an area of {shape.Area()}.");
        }
    }
}