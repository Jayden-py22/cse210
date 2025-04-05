using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            // Create a Running activity: date, duration, distance (miles)
            activities.Add(new Running(new DateTime(2025, 04, 03), 30, 3.0));

            // Create a Cycling activity: date, duration, speed (mph)
            activities.Add(new Cycling(new DateTime(2025, 04, 03), 45, 12.0));

            // Create a Swimming activity: date, duration, laps
            activities.Add(new Swimming(new DateTime(2025, 04, 03), 40, 30));

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}