public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {

    }
    public void RunActivity()
    {
        StartActivity();

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
        DisplayEndMessage();
    }
}