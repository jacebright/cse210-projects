using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a sample version of each type of activity
        RunningActivity running = new RunningActivity("01 JUN 2024", 57.06, 5);
        BicycleActivity cycling = new BicycleActivity("02 JUN 2024", 64, 16);
        SwimmingActivity swimming = new SwimmingActivity("03 JUN 2024", 36, 25);
        // Add each activity to a list
        List<Activity> activities = [running, cycling, swimming];
        // Iterate through the list and display the desired information
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}