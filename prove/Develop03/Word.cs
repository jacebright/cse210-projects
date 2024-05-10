public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        string word = _text;
        _text = "";
        foreach (char letter in word)
        {
            _text = _text + "_";
        }
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }

}