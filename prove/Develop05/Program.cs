using System;

// Added a spinner to be used when saving and loading a file. Saving and loading
// files may be nearly instantaneous, but giving the spinner as a visual feedback
// to the user gives a better user experience.
// Additionally added code to clear the screen when performing the create a goal
// saving and loading the file, and recording an event. This is so the screen
// does not become overwhelming and the user can focus on their current choices.

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalManager = new GoalManager(0);
        goalManager.Start();
    }
}