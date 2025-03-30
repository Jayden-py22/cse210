using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<BaseGoal> _goals;
    private int _score;
    private int _level;

    public GoalManager()
    {
        _goals = new List<BaseGoal>();
        _score = 0;
        _level = 1;
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter option: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    public void RecordGoal()
    {
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
        Console.Write("Enter goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            GainPoints(earned);
            Console.WriteLine($"Event recorded. You earned {earned} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nCurrent Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
        Console.WriteLine($"\nTotal Score: {_score}");
        Console.WriteLine($"Current Level: {_level}");
    }

    public void GainPoints(int points)
    {
        _score += points;
        CheckLevelUp();
    }

    // Level up every 1000 points.
    public void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"Congratulations! You've reached level {_level}.");
        }
    }

    public void SaveData(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_level);
            writer.WriteLine(_goals.Count);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Data saved successfully.");
    }

    public void LoadData(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _level = int.Parse(reader.ReadLine());
                int goalCount = int.Parse(reader.ReadLine());
                _goals.Clear();
                for (int i = 0; i < goalCount; i++)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    BaseGoal goal = null;
                    if (type == "SimpleGoal")
                    {
                        goal = SimpleGoal.Deserialize(line);
                    }
                    else if (type == "EternalGoal")
                    {
                        goal = EternalGoal.Deserialize(line);
                    }
                    else if (type == "ChecklistGoal")
                    {
                        goal = ChecklistGoal.Deserialize(line);
                    }
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Data loaded successfully.");
        }
        else
        {
            Console.WriteLine("Save file not found.");
        }
    }
}