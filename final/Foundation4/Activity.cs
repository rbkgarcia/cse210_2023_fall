public abstract class Activity
{
    //Attributes including Date and Length
    protected string _Date;
    protected int _Length;
    //constructor
    public Activity(string date, int length)
    {
        _Date = date;
        _Length = length;
    }
    //getters
    public string GetDate()
    {
        return _Date;
    }
    public int GetLength()
    {
        return _Length;
    }
    //setters
    public void SetDate(string date)
    {
        _Date = date;
    }
    public void SetLength(int length)
    {
        _Length = length;
    }
    //abstract method to return distance 
    public abstract double GetDistance();
    //abstract method to return speed
    public abstract double GetSpeed();
    //abstract method to return pace
    public abstract double GetPace();
    //Abstract method to display summary
    public abstract void DisplaySummary();
}    