using System;

class Program
{
    static void Main(string[] args)
    {
        string title1 = "Is AI Going to Take Your Job?";
        string desc1 = "Come listen to an argument for why you need to level up your skills in the new world of AI. Find out what kind of skills will never be replaced by artificial intelligence.";
        DateTime dateAndTime1 = new DateTime(2024,04,15,10,00,00);
        Address add1 = new Address("75 North Ceder St", "Sioux Falls", "SD", "USA");

        string title2 = "Samantha and Derek";
        string desc2 = "Celebrate the marriage of Samantha Anderson and Derek Riggs with an open-house style reception at the gardens of the Jeff Shortz Memorial Building.";
        DateTime dateAndTime2 = new DateTime(2025,02,18,18,00,00);
        Address add2 = new Address("1875 Patriot Ave", "Boston", "MA", "USA");

        string title3 = "Free Movie at the Park";
        string desc3 = "Join us for a free movie night at James Donlon Park! We will be watching The Incredibles. Bring your own chairs, blankets, and snacks!";
        DateTime dateAndTime3 = new DateTime(2024,07,06,20,30,00);
        Address add3 = new Address("300 Cherry Blossom Ln", "Ceder Hills", "TN", "USA");
        string weather = "Cloudy with slight wind and 68°F";

        List<Event> events = [];
        events.Add(new Lecture(title1, desc1, dateAndTime1, add1, "James McConnel", 55));
        events.Add(new Reception(title2, desc2, dateAndTime2, add2, "SamAndDerekForever@hotmail.com"));
        events.Add(new OutdoorGathering(title3, desc3, dateAndTime3, add3, weather));
        
        foreach (Event e in events)
        {
            Console.WriteLine($"\n{e.GetShortDescription()}");
            Console.WriteLine($"\n{e.GetStandardDetails()}");
            Console.WriteLine($"\n{e.GetFullDetails()}");
        }
    }
}