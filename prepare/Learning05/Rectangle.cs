//class that inherits from the shape class.
public class Rectangle : Shape
{
    private double _width;
    private double _length;

    //constructor that accepts the color and the width and length, and then call the base constructor with the color.
    public Rectangle(string color, double width, double length) : base(color)
    {
        this._width = width;
        this._length = length;
    }
    //Override the GetArea() method from the base class and fill in the body of this function to return the area.
    public override double GetArea()
    {
        return _width * _length;
    }
}
