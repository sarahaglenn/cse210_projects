public class OutdoorGathering : Event
{
    private string _weather;
     public OutdoorGathering(string title, string description, DateTime dateAndTime, Address address, string weather) : base (title, description, dateAndTime, address)
    {
        _weather = weather;
    }
    public override string GetFullDetails()
    {
        return $"{GetType()}\n{GetStandardDetails()}\nExpected weather: {_weather}";
    }
    public void UpdateWeather(string weather)
    {
        _weather = weather;
    }
}