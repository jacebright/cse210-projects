using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalManager = new GoalManager(0);
        goalManager.Start();
    }
}