using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Fraction six = new Fraction(5);
        Fraction third = new Fraction(3, 4);

        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine(six.GetFractionString());
        Console.WriteLine(six.GetDecimalValue());
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

        one.SetBottom(3);
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
    }
}