// ChecklistGoal represents a goal that must be completed a specific number of times.
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class ChecklistGoal : Goal
{
    private int _targetCount;

    private int _amountCompleted;

    private int _bonus;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetCount,
        int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _amountCompleted = 0;
        _bonus = bonus;
    }

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetCount,
        int amountCompleted,
        int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _amountCompleted = amountCompleted;
        _bonus = bonus;

    }

    //The goal is complete when the target number of events has been reached.
    public override bool IsComplete()
    {
        return _amountCompleted >= _targetCount;
    }

    public override int RecordEvent()
    {
        // prevent for the user to earn point once the checklist is already complete.

        if (IsComplete())
        {
            return 0;
        }

        _amountCompleted++;

        int earnedPoints = GetPoints();

        // add the bonus points if the event completes the entire checklist.
        if (_amountCompleted == _targetCount)
        {
            earnedPoints += _bonus;
        }

        return earnedPoints;
    }

    // Display the progress of the checklist goal.
    public override string GetDisplayString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";

        return $"{checkbox} {GetName()}" +
               $"({GetDescription()})" +
               $"-- Completed {_amountCompleted}/{_targetCount} times";
    }

    // Converts the object into a string for saving.
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|" +
               $"{GetPoints()}|{_targetCount}|{_amountCompleted}|{_bonus}";
               
    }
}
