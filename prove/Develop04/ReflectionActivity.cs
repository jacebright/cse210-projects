public class ReflectionActivity : Activity
{
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you made someone smile."
    ];
    private List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"

    ];
    private List<Phrase> _promptPhrases = [];
    private List<Phrase> _questionPhrases = [];
    
    public ReflectionActivity(string name, string description) :
        base(name, description)
        {
            foreach (string prompt in _prompts)
            {
                Phrase phrase = new Phrase(prompt);
                _promptPhrases.Add(phrase);
            }
            foreach (string question in _questions)
            {
                Phrase phrase = new Phrase(question);
                _questionPhrases.Add(phrase);
            }
        }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        DisplayPrompt();
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());

        while (currentTime < futureTime)
        {
            DisplayQuestions();
            ShowSpinner(6);
            currentTime = DateTime.Now;
        }

        Console.WriteLine("Well done!!");
        ShowSpinner(4);

        DisplayEndingMessage();
        ShowSpinner(4);              
    }
    private string GetRandomPrompt()
    {
        // First check if there are any prompts that have not been used. If 
        // there aren't, then unhide (or show) them all
        if (IsCompletelyHidden(_promptPhrases))
        {
            foreach (Phrase phrase in _promptPhrases)
            {
                phrase.Show();
            }
        }
        Random random = new Random();
        int index = random.Next(0, _promptPhrases.Count());
        _promptPhrases[index].Hide();
        return _promptPhrases[index].GetDisplayText();
    }   
    private string GetRandomQuestion()
    {
        // First check if there are any questions that have not been used. If 
        // there aren't, then unhide (or show) them all
        if (IsCompletelyHidden(_questionPhrases))
        {
            foreach (Phrase phrase in _questionPhrases)
            {
                phrase.Show();
            }
        }
        Random random = new Random();
        int index = random.Next(0, _questionPhrases.Count());
        _questionPhrases[index].Hide();
        return _questionPhrases[index].GetDisplayText();
    }  
    private void DisplayPrompt()
    {
        Console.WriteLine($"----{GetRandomPrompt()}----");
    }
    private void DisplayQuestions()
    {
        Console.WriteLine($">{GetRandomQuestion()}");
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