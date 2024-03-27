public class GoalManager
{
    private int _score;
    private List<Goal> _goals;
    public GoalManager()
    {
        _score = 0;
        _goals = [];
    }
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"\nYou have {_score} points.\n");

        string actionChoice = "";
        while (actionChoice != "6")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            actionChoice = Console.ReadLine();

            if (actionChoice == "1")
            {
                Console.WriteLine("\nThe types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("What type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                Console.Write("\nWhat is the name of your goal?");
                string name = Console.ReadLine();
                Console.Write("What is a short description of your goal?");
                string description = Console.ReadLine();
                Console.Write("How many points would you like this goal to be worth?");
                int points = int.Parse(Console.ReadLine());
                
                if (goalType == "1")
                {
                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (goalType == "2")
                {
                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (goalType == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus?");
                    int timesUntilBonus = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal goal = new ChecklistGoal(name, description, points, timesUntilBonus, bonus);
                    _goals.Add(goal);
                }
            }
            else if (actionChoice == "2")
            {
                // Display goals
                int i = 1;
                foreach (Goal g in _goals)
                {
                    //
                    Console.WriteLine($"{i}. {g.GetDetailsString()}");
                }
            }
            else if (actionChoice == "3")
            {
                // Save goals in txt. prompt for file name
                Console.WriteLine("What is the filename for the goals file?");
                string filename = Console.ReadLine();
                //first save number of points, then save goal for each goal in list
            }
            else if (actionChoice == "4")
            {
                // Use goal.
                // read from file. prompt for file name
                Console.WriteLine("What is the filename for the goals file?");
                string filename = Console.ReadLine();
                //parse out each piece of goal and save
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split("~~");
                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (goalType == "SimpleGoal")
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        SimpleGoal goal = new SimpleGoal(name, description, points);
                        //update simplegoal class to allow passing in boolean here
                    }
                    else if (goalType == "EternalGoal")
                    {

                    }
                    else if (goalType == "ChecklistGoal")
                    {

                    }
                }
            }
            else if (actionChoice == "5")
            {
                // goal.RecordEvent();
                // First display shorthand list of goals (ex: 1. name 2. name, etc)
                Console.WriteLine("Which goal did you accomplish? ");
                string goalAccomplished = Console.ReadLine();
                // Now use class methods to produce:
                // "Congratulations! You have earned __ points!
                // "You now have __ points!" as well as update/store relevant information
                // Then back to menu
            }
            else
            {
                break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        // Displays the player's current score
    }
    public void ListGoalNames()
    {
        // Lists the names of each of the goals
    }
    public void ListGoalDetails()
    {
        //Lists the details of each goal (including the checkbox of whether it is complete)
    }
    public void CreateGoal()
    {
        // Asks the user for the information about a new goal, then creates the goal and adds it to the list
    }
    public void RecordEvent()
    {
        // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal
    }
    public void SaveGoals()
    {
        // Saves the list of goals to a file
    }
    public void LoadGoals()
    {
        // Loads the list of goals from a file
    }
}