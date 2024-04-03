public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;

    public Address(string streetAddress, string city, string state)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
    }

    public string GetAddressString()
    {
        return $"{_streetAddress}\n{_city}, {_state}";
    }
}