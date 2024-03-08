using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }

    public void DisplayAllGratitude()
    {
        Console.WriteLine("You are grateful for: ");
        foreach (Entry e in _entries)
        {
            e.DisplayGratitude();
        }
    }
    public void SaveToFile()
    {
        Console.Write("What would you like the file name to be? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}~~{e._promptText}~~{e._entryText}~~{e._gratitudeText}");
            }
        }
    }
    public List<Entry> LoadFromFile()
    {
        Console.Write("What file would you like to load? ");
        string fileName = Console.ReadLine();
        List<Entry> loadEntries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            Entry loadEntry = new Entry();
            loadEntry._date = parts[0];
            loadEntry._promptText = parts[1];
            loadEntry._entryText = parts[2];
            loadEntry._gratitudeText = parts[3];
            loadEntries.Add(loadEntry);
        }
        return loadEntries;
    }
}