using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Default values
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        //local variable that will be recomputed when called method
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // local variable that will be recomputed when called method
        return (double)_top / (double)_bottom;
    }
}