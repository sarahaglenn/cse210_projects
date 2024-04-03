public class SwimmingLaps : Activity
{
    private double _lapCount;
    public SwimmingLaps(DateTime dateTime, int minutes, double lapCount) : base(dateTime, minutes)
    {
        _lapCount = lapCount;
    }
    public override double GetPace()
    {
        return Math.Round(_minutes / GetDistance(), 2);
    }
    public override double GetDistance()
    {
        return Math.Round(_lapCount * 50 / 1000, 2);
    }
    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / _minutes * 60, 2);
    }
}