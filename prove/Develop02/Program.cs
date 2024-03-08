using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //create instance of PromptGenerator 
        PromptGenerator prompts = new PromptGenerator();
        //add prompts to list
        prompts.CompilePrompts();

        string userChoice = "";
        //create instance of Journal
        Journal theJournal = new Journal();

        //stay in menu loop until user selects to exit
        while (userChoice != "5")
        {
            //display menu and read user selection    
            Console.WriteLine("\nWelcome to the journal app.");
            Console.WriteLine("Please select an action from the following options:");
            Console.WriteLine("1. Write \n2. Display journal entries \n3. Display gratitude journal \n4. Load\n5. Save\n6. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            //if select 'write', generate/display a prompt and store entry attributes
            if (userChoice == "1")
            {
                Entry newEntry = new Entry();
                newEntry._date = newEntry.GetDate();
                newEntry._promptText = prompts.GetRandomPrompt();
                Console.Write($"{newEntry._promptText}\n> ");
                newEntry._entryText = Console.ReadLine();
                theJournal.AddEntry(newEntry);
                Console.Write("Name one thing you're grateful for: ");
                newEntry._gratitudeText = Console.ReadLine();

            }
            else if (userChoice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                theJournal.DisplayAllGratitude();
            }
            else if (userChoice == "4")
            {
                theJournal._entries = theJournal.LoadFromFile();
            }
            else if (userChoice == "5")
            {
                theJournal.SaveToFile();
            }
            else
            {
                Console.WriteLine("Great job journaling today!");
                break;
            }
        }
    }
}