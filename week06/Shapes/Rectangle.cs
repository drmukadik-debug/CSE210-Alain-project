// The Rectangle class inherits from the Shape class and represents a rectangle shape.
using System;
public class Rectangle : Shape
{
    // Store the length and width of the rectangle.
    private double _length;
    private double _width;

    // Constructor that receives the color, length, and width of the rectangle as parameters.
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override the GetArea method to calculate the area of the rectangle.
    public override double GetArea()
    {
        return _length * _width;
    }
}