using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine(_description);
        Console.Write("Enter duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Good job! You've completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}