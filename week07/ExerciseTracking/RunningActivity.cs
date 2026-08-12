public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
        _name = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return Math.Round(_distance / _minutes * 60);
    }
    public override double GetPace()
    {
        return Math.Round(_minutes / _distance);
    }
}