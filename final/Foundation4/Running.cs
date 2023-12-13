public class Running : Activity
{
    private int _Distance;
    //constructor
    public Running(DateTime date, int length, int distance) : base(date, length)
    {
        _Distance = distance;
    }
    //overrided get distance method
    public override double GetDistance()
    {
        return Convert.ToDouble(_Distance);
    }
    //setters
    public void SetDistance(int distance)
    {
        _Distance = distance;
    }
    //overrided get speed method
    public override double GetSpeed()
    {
        return (_Distance / Convert.ToDouble(_Length)) * 60;
    }
    //overrided get pace method
    public override double GetPace()
    {
        return Convert.ToDouble(_Length) / _Distance;
    }
    //overrided DisplaySummary method
    public override void DisplaySummary()
    {
        Console.WriteLine($"{_Date.ToString("dd MMM yyyy")} Running ({_Length} min) - Distance: {GetDistance().ToString("0.##")} km, Speed: {GetSpeed().ToString("0.##")} km/h, Pace: {GetPace().ToString("0.##")} min per km");
    }
}