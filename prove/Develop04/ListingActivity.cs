public class ListingActivity : Activity
{
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What reasons do you have to smile right now?",
        "What do you like about your best friend?",
        "What makes you feel special?"

    ];
    private List<Phrase> _promptPhrases = [];
    private int _count = 0;
    
    public ListingActivity(string name, string description) : base(name, description)
    {
        foreach (string prompt in _prompts)
            {
                Phrase phrase = new Phrase(prompt);
                _promptPhrases.Add(phrase);
            }
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("\n");

        List<string> answers = GetListFromUser();
        _count = answers.Count;
        Console.WriteLine($"You listed {_count} items!\n");


        Console.WriteLine("Well done!!");
        ShowSpinner(4);

        DisplayEndingMessage();
        ShowSpinner(4);              
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count());
        return _prompts[index];
    }
    private List<string> GetListFromUser()
    {
        List<string> answers = [];
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());

        while (currentTime < futureTime)
        {
            Console.Write(">");
            string answer = Console.ReadLine();
            answers.Add(answer);

            currentTime = DateTime.Now;
        }
        return answers;
    }   
    public bool IsCompletelyHidden(List<Phrase> phrases)
        {
        bool hidden = true;
        foreach (Phrase phrase in phrases)
        {
            if (phrase.IsHidden())
            {
                continue;
            }
            else
            {
                hidden = false;
                break;
            }
        }
        return hidden;
    }
}