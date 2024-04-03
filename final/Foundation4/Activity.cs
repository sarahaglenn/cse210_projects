public abstract class Activity
{
    protected DateTime _dateTime;
    protected int _minutes; // length of activity
    public Activity(DateTime dateTime, int minutes)
    {
        _dateTime = dateTime;
        _minutes = minutes;
    }
    public abstract double GetPace();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public string GetSummary()
    {
        return $"{_dateTime.ToString("dd MMM yyyy")} {GetType()} ({_minutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}