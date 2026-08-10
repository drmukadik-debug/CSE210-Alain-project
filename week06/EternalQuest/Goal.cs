// This is the base class. It contains the common properties and methods that all goals will share.
public abstract class Goal
{
    // Private member variables demonstrating encapsulation
    private string _name;
    private string _description;
    private int _points;

    // Constructor for the Goal class
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Getter for the name of the goal
    public string GetName()
    {
        return _name;
    }

    // Getter for the description of the goal
    public string GetDescription()
    {
        return _description;
    }

    // Getter for the points associated with the goal
    public int GetPoints()
    {
        return _points;
    }
    // This method returns whether the goal is complete or not.
    // It is abstract, meaning that each class can provide its own implementation.
    public abstract bool IsComplete();

    // This method records an event  and returns the points earned for that event.
    //Each type og goals overrides this method.
    public abstract int RecordEvent();

    // This method converts the goal's data into a string format for saving to a file.
    public abstract string GetStringRepresentation();

}