using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Intel";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Developer";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Jace Bright";
        myResume._jobs = [job1, job2];

        myResume.Display();
    }
}