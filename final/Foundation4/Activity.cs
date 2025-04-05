using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        protected DateTime _date;
        protected int _duration; // in minutes

        public Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            string summary = $"{_date:dd MMM yyyy} {this.GetType().Name} ({_duration} min) - ";
            summary += $"Distance: {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F1}";
            return summary;
        }
    }
}