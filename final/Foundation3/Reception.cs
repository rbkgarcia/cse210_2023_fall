public class Reception : Event
{
    private string _RSVP;
    //constructor
    public Reception(string title, string description, DateTime date, string time, Address location, string RSVP) : base(title, description, date, time, location)
    {
        _RSVP = RSVP;
    }
    //setters
    public void SetRSVP(string RSVP)
    {
        _RSVP = RSVP;
    }
    //getters
    public string GetRSVP()
    {
        return _RSVP;
    }
    //return string with full details of the event
    public string GetFullDetails()
    {
        return base.GetSimpleDetails() + $"\nRSVP: {_RSVP}"+ "\n";
    }
}