public class StationaryBike : Activity
{
    private double _speed; // in kph
    public StationaryBike(DateTime dateTime, int minutes, double speed) : base(dateTime, minutes)
    {
        _speed = speed;
    }
    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
    public override double GetDistance()
    {
        return Math.Round(_speed * _minutes / 60, 2);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}