// I extended the project by creating a dictionary of scriptures 
// that the program randomly chooses from. If more scriptures are 
// added to the dictionary, no other code needs to be changed.
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create dictionary to store scripture objects
        Dictionary<int, Scripture> scriptureDictionary = new Dictionary<int, Scripture>();
        Reference reference0 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture0 = new Scripture(reference0, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all they ways acknowledge him, and he shall direct they paths.");
        scriptureDictionary.Add(0, scripture0);

        Reference reference1 = new Reference("John", 14, 15);
        Scripture scripture1 = new Scripture(reference1, "If ye love me, keep my commandments.");
        scriptureDictionary.Add(1, scripture1);

        Reference reference2 = new Reference("D&C", 18, 10);
        Scripture scripture2 = new Scripture(reference2, "Remember the worth of souls is great in the sight of God.");
        scriptureDictionary.Add(2, scripture2);

        Reference reference3 = new Reference("Mosiah", 4, 9);
        Scripture scripture3 = new Scripture(reference3, "Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend.");
        scriptureDictionary.Add(3, scripture3);        

        // Choose a random scripture from the dictionary
        Random num = new Random();
        int key = num.Next(scriptureDictionary.Count());
        Scripture todayScripture = scriptureDictionary.ElementAt(key).Value;

        do
        {
            Console.Clear();
            Console.WriteLine($"{todayScripture.GetDisplayText()}\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish. ");
            string userChoice = Console.ReadLine();
            if (userChoice == "quit")
            {
                break;
            }
            else
            {
                todayScripture.HideRandomWords(3);
            }
        } while (!todayScripture.IsCompletelyHidden());
        Console.Clear();
        Console.WriteLine($"{todayScripture.GetDisplayText()}\n");
    }
}