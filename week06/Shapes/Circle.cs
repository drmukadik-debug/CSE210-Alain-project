// The Circle class inherits from the Shape class and represents a circle shape.
using System;

public class Circle : Shape
{
    // Store the radius of the circle.
    private double _radius;

    // Constructor that receives the color and radius of the circle as parameters.
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override the GetArea method to calculate the area of the circle.
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}