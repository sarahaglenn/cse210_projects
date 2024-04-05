using System.Net.Sockets;
using System.Reflection;

public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _dateAndTime;
    private Address _address;
    public Event(string title, string description, DateTime dateAndTime, Address address)
    {
        _title = title;
        _description = description;
        _address = address;
        _dateAndTime = dateAndTime;
    }
    public abstract string GetFullDetails();
    public string GetStandardDetails()
    {
        return $"{_title}\n{_description}\n{_dateAndTime.ToShortDateString()}, {_dateAndTime.ToShortTimeString()}\nLocation:\n{_address.GetAddressString()}";
    }
    public string GetShortDescription()
    {
        return $"{GetType()}\n{_title}\n{_dateAndTime.ToShortDateString()}";
    }
}