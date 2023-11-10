//this class inherits from the base class.
public class Square : Shape
{
 // Add properties and methods relevant to a DerivedClass here
 // Add the side member variable and a.SetSide() method
 private readonly double _Side;

    // constructor that accepts the color and the side, and then call the base constructor with the color.
    public Square(string color, double side) : base(color)
    {
        this._Side = side;
    }
    //Override the GetArea() method from the base class and fill in the body of this function to return the area.
    public override double GetArea()
    {
        return _Side * _Side;
    }
}