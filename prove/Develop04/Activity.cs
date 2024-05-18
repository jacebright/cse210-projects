using System.Reflection.PortableExecutable;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"\n{_description}\n");
        SetDuration();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
    public void ShowSpinner(int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(seconds);

        while (currentTime < futureTime)
        {
            List<string> characters = ["\\", "|", "/", "-", "\\", "|", "/", "-"];
            foreach (string character in characters)
            {
                Console.Write(character);
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
        }
    }
    public void ShowCountDown(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds = seconds - 1;
        }
    }
    protected int GetDuration()
    {
        return _duration;
    }
    protected string GetDescription()
    {
        return _description;
    }
    private void SetDuration()
    {
        Console.Write("How long, in seconds, would you like your session? ");
        string duration = Console.ReadLine();
        _duration = Int32.Parse(duration);
    }
}