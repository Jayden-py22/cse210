using System;

public class ChecklistGoal : BaseGoal
{
    private int _targetCount;
    private int _bonus;
    private int _timesCompleted;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _timesCompleted++;
            int totalPoints = _points;
            if (_timesCompleted >= _targetCount)
            {
                _isCompleted = true;
                totalPoints += _bonus;
            }
            return totalPoints;
        }
        return 0;
    }

    public override string GetDetails()
    {
        string status = _isCompleted ? "[X]" : "[ ]";
        return $"{status} Checklist Goal: {_name} ({_description}) - Each time: {_points} points, Bonus: {_bonus} points - Progress: {_timesCompleted}/{_targetCount}";
    }

    public override string Serialize()
    {
        // Format: ChecklistGoal|name|description|points|isCompleted|targetCount|bonus|timesCompleted
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_isCompleted}|{_targetCount}|{_bonus}|{_timesCompleted}";
    }

    public static ChecklistGoal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        if (parts.Length == 8)
        {
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool isCompleted = bool.Parse(parts[4]);
            int targetCount = int.Parse(parts[5]);
            int bonus = int.Parse(parts[6]);
            int timesCompleted = int.Parse(parts[7]);
            ChecklistGoal goal = new ChecklistGoal(name, description, points, targetCount, bonus);
            goal._isCompleted = isCompleted;
            goal._timesCompleted = timesCompleted;
            return goal;
        }
        throw new Exception("Invalid ChecklistGoal data");
    }
}