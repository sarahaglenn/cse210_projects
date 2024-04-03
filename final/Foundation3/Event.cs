using System.Net.Sockets;
using System.Reflection;

public abstract class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _dateAndTime;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(string title, string description, DateTime dateAndTime, Address address)
    {
        _title = title;
        _description = description;
        _date = dateAndTime.ToShortDateString();
        _time = dateAndTime.ToShortTimeString();
        _address = address;
    }
    public abstract string GetFullDetails();
    public string GetStandardDetails()
    {
        return $"{_title}\n{_description}\n{_date}, {_time}\nLocation:\n{_address.GetAddressString()}";
    }
    public string GetShortDescription()
    {
        return $"{GetType()}\n{_title}\n{_date}";
    }
}