using System.Collections.Generic;


public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        return _date;
    }
}