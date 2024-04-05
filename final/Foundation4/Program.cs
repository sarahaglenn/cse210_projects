using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [];
        
        activities.Add(new StationaryBike(new DateTime(2024,03,31,06,00,00), 60, 20));
        activities.Add(new SwimmingLaps(new DateTime(2024,04,02,06,30,00), 25, 24));
        activities.Add(new Running(DateTime.Now, 30, 4.8));

        Console.Clear();
        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}