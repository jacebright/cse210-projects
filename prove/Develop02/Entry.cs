// This class stores the prompt, date, and what the user inputted
// as a journal entry for the day

public class Entry
{
    public string _promptText;
    public string _date;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}");
    }
}