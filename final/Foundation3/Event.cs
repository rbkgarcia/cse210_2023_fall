//Event class

public class Event
{
    //private data members
    private string _Title;
    private string _Description;
    private DateTime _Date;
    private string _Time;
    private Address _Location;

    //constructor
    public Event(string title, string description, DateTime date, string time, Address location)
    {
        _Title = title;
        _Description = description;
        _Date = date;
        _Time = time;
        _Location = location;
    }
    //setters

    public void SetTitle(string title)
    {
        _Title = title;
    }
    public void SetDescription(string description)
    {
        _Description = description;
    }
    public void SetDate(DateTime date)
    {
        _Date = date;
    }
    public void SetTime(string time)
    {
        _Time = time;
    }
    public void SetLocation(string location)
    {
        _Location = location;
    }

    //getters
    public string GetTitle()
    {
        return _Title;
    }
    public string GetDescription()
    {
        return _Description;
    }
    public DateTime GetDate()
    {
        return _Date;
    }
    public string GetTime()
    {
        return _Time;
    }
    public string GetLocation()
    {
        return _Location;
    }
    //return a string with simple details of the event
    public string GetSimpleDetails()
    {
        return $"{_Title}\n{_Description}\n{_Date.ToString("d")}\n{_Time}\n{_Location}";
    }
    //Display details of the event

    public static void DisplayFullDetails(string Details)
    {
        Console.WriteLine(Details);
    }
}