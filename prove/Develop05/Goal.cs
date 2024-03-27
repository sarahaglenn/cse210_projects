using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    // do whatever necessary for each goal type- mark goal complete, add to number of times a 
    // checklist goal has been completed. Return point value associated with recording the event (may contain a bonus in some cases if a checklist goal was just finished.)
    public abstract bool IsComplete();
    // return true if goal is completed (different for each type of goal)
    public virtual string GetDetailsString()
    {
        // returns checkbox, shortname, and description
        return $"[ ] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
    // provides all of the details of a goal in a way that is easy to save to a file, and also to load
}