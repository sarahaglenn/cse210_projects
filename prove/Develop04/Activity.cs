using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    private string CreateWelcome()
    {
        string welcomeMessage = $"Welcome to the {_name}. \n\n{_description}\n";
        return welcomeMessage;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine(CreateWelcome());
        SetDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine(); 
    }
    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public int GetDuration()
    {
        return _duration;
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
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Great Job!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou've completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }
    //Could add a GetEndTime function here that returns DateTime endTime to compare with

}