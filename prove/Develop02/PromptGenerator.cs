// This class generates a random journal prompt from the prompts available
// the output is a string containing the prompt

public class PromptGenerator
{
    public List<string> _prompts = [
        "Who was the most uplifting person I interacted with today?",
        "Who did I serve today?",
        "What reminds me of my worth in God's eyes from today?",
        "If I had one thing I could do over today, what would it be?",
        "What was my most meaningful tender mercy from God today?",
        "What made me smile today?",
        "What made today worth living?"
    ];

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0,(_prompts.Count - 1));
        string prompt = _prompts[index];

        return prompt;
    }

    
}