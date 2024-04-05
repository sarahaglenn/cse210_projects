public abstract class Activity
{
    private DateTime _dateTime;
    protected int _minutes; // length of activity
    public Activity(DateTime dateTime, int minutes)
    {
        _dateTime = dateTime;
        _minutes = minutes;
    }
    public virtual double GetPace()
    {
        return GetPace();
    }
    public virtual double GetDistance()
    {
        return GetDistance();
    }
    public virtual double GetSpeed()
    {
        return GetSpeed();
    }
    public string GetSummary()
    {
        return $"{_dateTime.ToString("dd MMM yyyy")} {GetType()} ({_minutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}