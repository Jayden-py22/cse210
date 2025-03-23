using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
        "How can you apply this lesson in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity",
        "This activity helps you reflect on times you've shown strength and resilience.")
    { }

    public void Run()
    {
        StartActivity();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");

        int timeLeft = _duration;
        while (timeLeft > 0)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine($"Question: {question}");
            ShowSpinner(10);
            timeLeft -= 10;
        }

        EndActivity();
    }
}