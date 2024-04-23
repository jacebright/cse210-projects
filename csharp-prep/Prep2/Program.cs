using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);
        string letterGrade = "";
        bool pass = false;

        if (grade >= 90)
        {
            letterGrade = "A";
            pass = true;
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            pass = true;
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            pass = true;
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (grade <= 95 && grade >=60)
        {
            // create a variable for the one's place of a value
            int sign = grade % 10;
            if (sign >= 7)
            {
                letterGrade = letterGrade + "+";
            }
            else if (sign <= 3)
            {
                letterGrade = letterGrade + "-";
            }
        }


        Console.WriteLine($"You received an {letterGrade}");

        if (pass)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Would you like to enroll for next semester?");
        }
    }
}