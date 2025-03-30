using System;

public class EternalGoal : BaseGoal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return _points;
    }

    public override string GetDetails()
    {
        return $"[∞] Eternal Goal: {_name} ({_description}) - Each time: {_points} points - Completed: {_timesCompleted} times";
    }

    public override string Serialize()
    {
        // Format: EternalGoal|name|description|points|timesCompleted
        return $"EternalGoal|{_name}|{_description}|{_points}|{_timesCompleted}";
    }

    public static EternalGoal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        if (parts.Length == 5)
        {
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            int timesCompleted = int.Parse(parts[4]);
            EternalGoal goal = new EternalGoal(name, description, points);
            goal._timesCompleted = timesCompleted;
            return goal;
        }
        throw new Exception("Invalid EternalGoal data");
    }
}