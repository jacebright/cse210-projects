using System.Linq;
using System.Runtime.CompilerServices;
public class Scripture
{
    Reference _reference;
    List<Word> _words = [];
    public Scripture(Reference reference, string text)
    {
        List<string> listText = text.Split(" ").ToList();
        foreach (string item in listText)
        {
            Word word = new Word(item);
            _words.Add(word);
        }
        _reference = reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();

        // Perform a do/while loop to hide a word that is not already hidden
        // Nest this inside of a for loop to hide a set number of words
        for (int i = 0; i < numberToHide; i++)
        {
            Word currentWord = _words[0];
            do
            {
                int index = randomGenerator.Next(0,_words.Count);
                currentWord = _words[index];
                // Break from the while loop if there are no more shown words
                if (IsCompletelyHidden())
                {
                    break;
                }
            } 
            while (currentWord.IsHidden());

            currentWord.Hide();
        }
    }
    public string GetDisplayText()
    {
        string verse = $"{_reference.GetDisplayText()} ";
        foreach (Word word in _words)
        {
            verse = verse + word.GetDisplayText() + " ";
        }

        return verse;
    }
    public bool IsCompletelyHidden()
        {
        bool hidden = true;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
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