using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by guiding you through slow breathing. Focus on your breath.")
    { }

    public void Run()
    {
        StartActivity();

        int timeLeft = _duration;
        while (timeLeft > 0)
        {
            Console.WriteLine("Breathe in...");
            Countdown(4);
            timeLeft -= 4;

            Console.WriteLine("Breathe out...");
            Countdown(4);
            timeLeft -= 4;
        }

        EndActivity();
    }
}