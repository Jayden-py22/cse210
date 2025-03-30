using System;

public class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override string GetDetails()
    {
        string status = _isCompleted ? "[X]" : "[ ]";
        return $"{status} Simple Goal: {_name} ({_description}) - Points: {_points}";
    }

    public override string Serialize()
    {
        // Format: SimpleGoal|name|description|points|isCompleted
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_isCompleted}";
    }

    public static SimpleGoal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        if (parts.Length == 5)
        {
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool isCompleted = bool.Parse(parts[4]);
            SimpleGoal goal = new SimpleGoal(name, description, points);
            goal._isCompleted = isCompleted;
            return goal;
        }
        throw new Exception("Invalid SimpleGoal data");
    }
}