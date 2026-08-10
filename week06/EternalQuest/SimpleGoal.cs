// SimpleGoal represents a basic goal that can be completed once.
public class SimpleGoal : Goal
{
    // Private member variable to track if the goal is complete
    private bool _isComplete;

    // Constructor for the SimpleGoal class
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false; // Initialize the goal as not complete
    }

    // This constructor is useful when Loading a saved goal.
    public SimpleGoal(
        string name,
        string description,
        int points,
        bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // return true if the goal has been completed.

    public override bool IsComplete()
    {
        return _isComplete;
    }

    // records the goal as complete and returns the points.
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }

        return 0;
    }

    // Displays the goal with[X] when completed and [] when it is not completed.

    public override string GetDisplayString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";

        return $"{checkbox} {GetName()} ({GetDescription()})";
    }

    // Converts the object to a form that can be saved.
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}