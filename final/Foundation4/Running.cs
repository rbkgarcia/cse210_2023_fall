public class Running : Activity
{
    private int _Distance;
    //constructor
    public Running(string date, int length, int distance) : base(date, length)
    {
        _Distance = distance;
    }
    //overrided get distance method
    public override double GetDistance()
    {
        return _Distance;
    }
    //setters
    public void SetDistance(int distance)
    {
        _Distance = distance;
    }
    //overrided get speed method
    public override double GetSpeed()
    {
        return _Distance / _Length;
    }
    //overrided get pace method
    public override double GetPace()
    {
        return _Length / _Distance;
    }
    //overrided DisplaySummary method
    public override void DisplaySummary()
    {
        Console.WriteLine($"{_Date} Running ({_Length} min) - Distance: {_Distance} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min per km");
    }
}