public class Cycling : Activity
{
    private double _Speed;
    //constructor
    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _Speed = speed;
    }
    //overrided get distance method
    public override double GetDistance()
    {
        return _Speed * _Length / 60;
    }

    //overrided get speed method
    public override double GetSpeed()
    {
        return _Speed;
    }

    //overrided get pace method
    public override double GetPace()
    {
        return _Length / _Speed;
    }
  
    //overrided DisplaySummary method
    public override void DisplaySummary()
    {
        Console.WriteLine($"Speed: {_Speed}");
    }

}