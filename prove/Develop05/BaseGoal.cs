using System;

public abstract class BaseGoal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public BaseGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool IsCompleted()
    {
        return _isCompleted;
    }

    // Records an event for the goal and returns the earned points.
    public abstract int RecordEvent();

    // Returns a string with the goal's details.
    public abstract string GetDetails();

    // Serializes the goal for saving.
    public abstract string Serialize();
}