//Comment class
public class Comment
{
    //Attributes of the class
    private string _Name;
    private string _TextComment;
    //constructor method
    public Comment(string name, string textComment)
    {
        _Name = name;
        _TextComment = textComment;
    }

    //Getters of the class
    public string GetName()
    {
        return _Name;
    }

    public string GetTextComment()
    {
        return _TextComment;
    }
    //Setters of the class
    public void SetName(string name){
        _Name = name;
    }
    public void SetTextComment(string textComment){
        _TextComment = textComment;
    }
    //display comment
    public void DisplayComment()
    {
        Console.WriteLine($"\t{_Name}: {_TextComment}");
    }
}
