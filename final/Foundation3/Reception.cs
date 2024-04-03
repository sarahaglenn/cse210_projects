public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, DateTime dateAndTime, Address address, string email) : base (title, description, dateAndTime, address)
    {
        _email = email;
    }
    public override string GetFullDetails()
    {
        return $"{GetType()}\n{GetStandardDetails()}\nRSVP at {_email}";
    }
}