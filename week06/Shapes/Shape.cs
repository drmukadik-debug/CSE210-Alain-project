// The base class for all shapes
using System;

public class Shape
{
    // Store the color of the shape.
    private string _color;

    // Constructor that receives the color of the shape as a parameter.
    public Shape(string color)
    {
        _color = color;
    }

    // Returns the color of the shape.
    public string GetColor()
    {
        return _color;
    }

    // Changes the color of the shape.
    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method to calculate the area of the shape. This method can be overridden by derived classes.
    public virtual double GetArea()
    {
        return 0; // Default implementation returns 0 for the area.
    }
}