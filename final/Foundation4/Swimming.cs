public class Swimming : Activity
{
    private readonly int _Laps;
    //constructor
    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _Laps = laps;
    }
    //overrided get distance method
    public override double GetDistance()
    {
        return Convert.ToDouble(_Laps)* 50/ 1000;
    }

    //overrided get speed method
    public override double GetSpeed()
    {
        return (GetDistance() /Convert.ToDouble(_Length))*60;
    }
  
    //overrided get pace method
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
  
    //overrided DisplaySummary method
    public override void DisplaySummary()
    {
        Console.WriteLine($"{_Date.ToString("dd MMM yyyy")} Swimming ({_Length} min) - Distance: {GetDistance().ToString("0.##")} km, Speed: {GetSpeed().ToString("0.##")} km/h, Pace: {GetPace().ToString("0.##")} min per km");
    }

}