using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list that can store Shape objects.
        // that inherit from the Shape class.
        List<Shape> shapes = new List<Shape>();

        // Create a Square object and add it to the list.
        shapes.Add(new Square("red", 5));

        // Create a Rectangle object and add it to the list.
        shapes.Add(new Rectangle("blue", 4, 6));

        // Create a Circle object and add it to the list.
        shapes.Add(new Circle("green", 3));

        //Loop through the list of shapes and display their color and area.
        foreach (Shape shape in shapes) 
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea():F2}");

            Console.WriteLine(); // Add an empty line for better readability.
        }
    }
}