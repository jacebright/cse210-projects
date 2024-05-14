using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new 
        MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");

        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new 
        WritingAssignment("Mary Waters", "European History", 
        "The Causes of World War II");

        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}