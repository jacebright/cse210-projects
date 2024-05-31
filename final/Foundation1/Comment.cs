public class Comment
{
    private string _comment;
    private string _commenter;
    public Comment(string comment, string commenter)
    {
        _comment = comment;
        _commenter = commenter;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"\t{_commenter} - {_comment}");
    }
}