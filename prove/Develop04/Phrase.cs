public class Phrase
{
    private string _text;
    private bool _isHidden = false;

    public Phrase(string text)
    {
        _text = text;
    }
    public void Hide()
    {
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
    public void Show()
    {
        _isHidden = false;
    }

}