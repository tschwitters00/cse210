public abstract class Activity
{
    protected string _date;
    protected int _minutes;
    protected string _name;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace:{GetPace()} min per mile";
    }
}