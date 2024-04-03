public class Running : Activity
{
    private double _distance; // in km
    public Running(DateTime dateTime, int minutes, double distance) : base(dateTime, minutes)
    {
        _distance = distance;
    }
    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return Math.Round((_distance / _minutes) * 60, 2);
    }
}