// This class represent a goals that can be completed repeatedly and never permanently complete.

public class EternalGoal : Goal
{
    // Constructor for EternalGoal.
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        
    }

    // Eternal goals are never considered complete.
    public override bool IsComplete()
    {
        return false;
    }

    // Each time this goal are recorded, the user receive the specified number of points.
    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override string GetDisplayString()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    // Converts the object into a string for saving.

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}