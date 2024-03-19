using System.ComponentModel;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }
    private string CreateWelcome()
    {
        string welcomeMessage = $"Welcome to the {_activityName}. \n\n{_activityDescription}\n";
        return welcomeMessage;
    }
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine(CreateWelcome());
        SetDuration();

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine(); 
    }
    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
    }
    public int GetDuration()
    {
        return _activityDuration;
    }
    public void ShowSpinner(int seconds)
    {
        //compile characters needed for animated spinner
        List<string> spinnerStrings = new List<string>();
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            if (i % spinnerStrings.Count == 0)
            {
                i = 0;
            }
        }
    }
    public void ShowCountdown(int startingNumber)
    {
        for (int i = startingNumber; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Great Job!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou've completed another {_activityDuration} seconds of the {_activityName}.");
        ShowSpinner(5);
    }
    //Could add a GetEndTime function here that returns DateTime endTime to compare with

}