using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many people you appreciate as you can.",
        "List your personal strengths.",
        "List people you've helped this week.",
        "List times you felt the Holy Ghost this month."
    };

    public ListingActivity() : base("Listing Activity",
        "This activity helps you reflect on positive things in your life by listing as many as you can.")
    { }

    public void Run()
    {
        StartActivity();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("You have a few seconds to prepare...");
        ShowSpinner(3);

        Console.WriteLine("Start listing!");
        int timeLeft = _duration;
        List<string> items = new List<string>();

        while (timeLeft > 0)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
            timeLeft -= 3;
        }

        Console.WriteLine($"You listed {items.Count} items!");
        EndActivity();
    }
}