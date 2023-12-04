public class Swimming : Activity
{
    private int _Laps;
    //constructor
    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _Laps = laps;
    }
    //overrided get distance method
    public override double GetDistance()
    {
        return _Laps* 50/ 1000;
    }

    //overrided get speed method
    public override double GetSpeed()
    {
        // Add your code here to calculate the speed
        // based on the swimming laps and length
    }

    //overrided get speed method
  
    //overrided get pace method
  
    //overrided DisplaySummary method

}