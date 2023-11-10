using System;

class Program
{
    static void Main(string[] args)
    {
        //create a list to hold shapes (Hint: The data type should be List<Shape>).
        List<Shape> shapes = new List<Shape>();
        //Add a square, rectangle, and circle to this list.
        shapes.Add(new Square("blue", 10));
        shapes.Add(new Rectangle("red", 10, 20));
        shapes.Add(new Circle("green", 10));
        //Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()}");
        }
    }
}