using System.Runtime.CompilerServices;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddressString()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
    public bool IsInUSA()
    {
        List<string> usaStrings = ["USA", "US", "United States", "U.S.A.", "United States of America", "America"];
        if (usaStrings.Contains(_country))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}