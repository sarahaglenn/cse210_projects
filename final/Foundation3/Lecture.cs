public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, DateTime dateAndTime, Address address, string speaker, int capacity) : base (title, description, dateAndTime, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return $"{GetType()}\n{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}