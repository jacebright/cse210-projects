public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        if (_endVerse != 0)
        {
            string reference_string = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
            return reference_string;
        }
        else
        {
            string reference_string = $"{_book} {_chapter}:{_startVerse}";
            return reference_string;
        }
    }
}
