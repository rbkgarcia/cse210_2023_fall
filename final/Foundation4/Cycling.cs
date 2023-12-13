public class Cycling : Activity
{
    private readonly double _Speed;
    //constructor
    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _Speed = speed;
    }
    //overrided get distance method
    public override double GetDistance()
    {
        return _Speed * Convert.ToDouble(_Length) / 60;
    }

    //overrided get speed method
    public override double GetSpeed()
    {
        return _Speed;
    }

    //overrided get pace method
    public override double GetPace()
    {
        return Convert.ToDouble(_Length) / _Speed;
    }
  
    //overrided DisplaySummary method
    public override void DisplaySummary()
    {
        Console.WriteLine($"{_Date.ToString("dd MMM yyyy")} Cycling ({_Length} min) - Distance: {GetDistance().ToString("0.##")} km, Speed: {GetSpeed().ToString("0.##")} km/h, Pace: {GetPace().ToString("0.##")} min per km");
    }

}