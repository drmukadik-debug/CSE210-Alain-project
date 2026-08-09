// The Square class inherits from the Shape class and represents a square shape.
using System;

public class Square : Shape
{
    // Store the length of the side of the square.
    private double _side;

    // Constructor that receives the color and side length of the square as parameters.
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    //Override the GetArea method to calculate the area of the square.
    public override double GetArea()
    {
        return _side * _side;
    }
}