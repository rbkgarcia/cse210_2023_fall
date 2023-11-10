using System;

//Shape class
public abstract class Shape
{
    // Add properties and methods relevant to a Shape here
    //Add the color member variable and a .
    private string _Color;

    
    public void SetColor(string value)
    {
        _Color = value;
    }
    public string GetColor()
    {
        return _Color;
    }   
    
    //Create a constructor that accepts the color and set its
    public Shape(string color)
    {
        this._Color = color;
    }
    //Create a virtual method for GetArea().
    public virtual double GetArea()
    {
        // This is a placeholder. Replace with actual implementation in the derived class.
        throw new NotImplementedException();
    }
}
