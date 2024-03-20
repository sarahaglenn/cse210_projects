public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
        Console.Write("\nBreathe in...");
        ShowCountdown(4);
        Console.Write("\nNow breathe out...");
        ShowCountdown(8);
        Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}