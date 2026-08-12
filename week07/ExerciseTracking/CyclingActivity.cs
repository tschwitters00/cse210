public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
        _name = "Cycling";
    }

    public override double GetDistance()
    {
        return Math.Round(_minutes / 60 * _speed);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
}