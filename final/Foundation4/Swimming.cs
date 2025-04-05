namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(DateTime date, int duration, int laps)
            : base(date, duration)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            double km = _laps * 50.0 / 1000.0;
            return km * 0.621371;
        }

        public override double GetSpeed()
        {
            double distance = GetDistance();
            return distance / (_duration / 60.0);
        }

        public override double GetPace()
        {
            double distance = GetDistance();
            return distance > 0 ? _duration / distance : 0;
        }
    }
}