//circle class that inherits from the shape class.
public class Circle : Shape
{
    private double _Radius;
    //constructor that accepts the color and the radius, and then call the base constructor with the color.
    public Circle(string color, double radius) : base(color)
    {
        this._Radius = radius;
    }
    //Override the GetArea() method from the base class and fill in the body of this function to return the area.
    public override double GetArea()
    {
        return Math.PI * _Radius * _Radius;
    }
}