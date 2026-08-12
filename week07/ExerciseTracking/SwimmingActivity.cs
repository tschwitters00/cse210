public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
        _name = "Swimming";
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000 * 0.62);
    }
    public override double GetSpeed()
    {
        return Math.Round(60 / GetPace());
    }
    public override double GetPace()
    {
        return Math.Round(_minutes / GetDistance(), 2);
    }

    public override string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace:{GetPace()} min per mile, Laps:{_laps}";
    }
}