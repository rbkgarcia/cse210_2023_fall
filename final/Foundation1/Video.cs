//video class
public class Video
{
    //attributes of the class
    private string _Title;
    private string _Author;
    private int _Length;
    private List<Comment> _Comments = new();
    //constructor of the class
    public Video(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;
    }
    //getters
    public string GetTitle()
    {
        return _Title;
    }
    public string GetAuthor()
    {
        return _Author;
    }
    public int GetLength()
    {
        return _Length;
    }
    //setters
    public void SetTitle(string title)
    {
        _Title = title;
    }
    public void SetAuthor(string author)
    {
        _Author = author;
    }
    public void SetLength(int length)
    {
        _Length = length;
    }
    //methods
    public void AddComment(Comment comment)
    {
        _Comments.Add(comment);
    }
    //display video info
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video Title: {GetTitle()}");
        Console.WriteLine($"Author of video: {GetAuthor()}");
        Console.WriteLine($"Length of video: {GetLength()} minutes");
        //display comments
        Console.WriteLine($"\t Comments of {GetAuthor()}'s Video");
        foreach (Comment comment in _Comments)
        {
            comment.DisplayComment();
        }
    }
}