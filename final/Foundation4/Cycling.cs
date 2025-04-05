namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double _speedInput; // mph

        public Cycling(DateTime date, int duration, double speedInput)
            : base(date, duration)
        {
            _speedInput = speedInput;
        }

        public override double GetDistance()
        {
            return _speedInput * (_duration / 60.0);
        }

        public override double GetSpeed()
        {
            return _speedInput;
        }

        public override double GetPace()
        {
            return _speedInput > 0 ? 60 / _speedInput : 0;
        }
    }
}