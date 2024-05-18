public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description){}
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());

        while (currentTime < futureTime)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nNow Breathe out...");
            ShowCountDown(6);

            currentTime = DateTime.Now;
        }

        Console.WriteLine("Well done!!");
        ShowSpinner(4);

        DisplayEndingMessage();
        ShowSpinner(4);              
    }                    
}