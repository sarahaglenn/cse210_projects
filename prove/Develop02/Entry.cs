using System.Collections.Generic;


public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public string _gratitudeText = "";
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

    public void DisplayGratitude()
    {
        Console.WriteLine(_gratitudeText);
    }
    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        return _date;
    }
}