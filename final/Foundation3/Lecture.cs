public class Lecture : Event
{
    private string _SpeakerName;
    private int _Capacity;
    //constructor
    public Lecture(string title, string description, DateTime date, string time, string location, string speakerName, int capacity) : base(title, description, date, time, location)
    {
        _SpeakerName = speakerName;
        _Capacity = capacity;
    }
    //getters
    public string GetSpeakerName()
    {
        return _SpeakerName;
    }
    public int GetCapacity()
    {
        return _Capacity;
    }
    //setters
    public void SetSpeakerName(string speakerName)
    {
        _SpeakerName = speakerName;
    }
    public void SetCapacity(int capacity)
    {
        _Capacity = capacity;
    }
    //return string with full details of the event
    public string GetFullDetails()
    {
        return base.GetSimpleDetails() + "\nSpeaker: " + _SpeakerName + "\nCapacity: " + _Capacity;
    }
}