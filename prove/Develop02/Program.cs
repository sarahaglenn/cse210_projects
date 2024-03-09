//I added to the program by prompting the user for one thing they are grateful for after each time 
//they write an entry. These are stored as attributes of the entries, but are not displayed with the journal. 
//Instead, the user can choose to display the list of everything they are grateful for. I added class methods
//and attributes, and altered some of the existing methods to make this change.
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //instantiate PromptGenerator 
        PromptGenerator prompts = new PromptGenerator();
        //add prompts to list
        prompts.CompilePrompts();

        //instantiate Journal
        Journal theJournal = new Journal();

        //stay in menu loop until user selects to exit
        string userChoice = "";
        while (userChoice != "6")
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
            //if 'display journal', display entries with dates and prompts
            else if (userChoice == "2")
            {
                theJournal.DisplayAll();
            }
            //if 'display gratitude', display list of gratitudes
            else if (userChoice == "3")
            {
                theJournal.DisplayAllGratitude();
            }
            //if 'load', extract data from file chosen, and save as entries(with attributes) in a list
            else if (userChoice == "4")
            {
                theJournal._entries = theJournal.LoadFromFile();
            }
            //if 'save', store each entry(and attributes)
            else if (userChoice == "5")
            {
                theJournal.SaveToFile();
            }
            //if any other keys are entered, exit the program
            else
            {
                Console.WriteLine("Great job journaling today!");
                break;
            }
        }
    }
}