using System.IO;
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
        string actionChoice = "";
        while (actionChoice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
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
                CreateGoal();
            }
            else if (actionChoice == "2")
            {
                // Display goals
                Console.WriteLine("\nThe goals are: ");
                ListGoalDetails();    
            }
            else if (actionChoice == "3")
            {
                // Save goals in txt. prompt for file name
                SaveGoals();
            }
            else if (actionChoice == "4")
            {
                // Load goals from given filename
                LoadGoals();
            }
            else if (actionChoice == "5")
            {
                // record event
                RecordEvent();
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                break;
            }
        }
    }
    private void DisplayPlayerInfo()
    {
        // Displays the player's current score
        Console.WriteLine($"\nYou have {_score} points.");
    }
    private void ListGoalNames()
    {
        // Lists the names of each of the goals
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"  {i}. {g.GetName()}");
            i++;
        }
    }
    private void ListGoalDetails()
    {
        //Lists the details of each goal (including the checkbox of whether it is complete)
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetDetailsString()}");
            i++;
        }
        Console.WriteLine();
    }
    private void CreateGoal()
    {
        // Asks the user for the information about a new goal, then creates the goal and adds it to the list
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("How many points would you like this goal to be worth? ");
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
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int timesUntilBonus = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(name, description, points, timesUntilBonus, bonus);
            _goals.Add(goal);
        }
    }
    private void RecordEvent()
    {
        // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal
        // First display shorthand list of goals (ex: 1. name 2. name, etc)
        Console.WriteLine("\nThe goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalAccomplished = int.Parse(Console.ReadLine());
        int goalIndex = goalAccomplished - 1;
        Goal goalJustDone = _goals[goalIndex];
        int pointsToAdd = goalJustDone.RecordEvent();
        _score += pointsToAdd;
        if (goalJustDone.IsComplete())
        {
            goalJustDone.ShowAnimation();
        }

        Console.WriteLine($"Congratulations! You have earned {pointsToAdd} points!");
        Console.WriteLine($"You now have {_score} points.");
    }
    private void SaveGoals()
    {
        // Saves the list of goals to a file
        Console.Write("What is the filename for the goals file? ");
        string filename = Console.ReadLine();
        //first save number of points, then save goal for each goal in list
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            outputfile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputfile.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    private void LoadGoals()
    {
        // Loads score and a list of goals from a file
        Console.Write("What is the filename for the goals file? ");
        string filename = Console.ReadLine();
        //parse out each piece of goal and save
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string goalDetails = parts[1];
            BuildGoal(goalType, goalDetails);
        }
    }
    private void BuildGoal(string goalType, string goalDetails)
    {
        string[] parts = goalDetails.Split("~~");
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);

        if (goalType == "SimpleGoal")
        {
            bool isComplete = bool.Parse(parts[3]);
            SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
            _goals.Add(goal);
        }
        else if (goalType == "EternalGoal")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (goalType == "ChecklistGoal")
        {
            int bonus = int.Parse(parts[3]);
            int target = int.Parse(parts[4]);
            int timesCompleted = int.Parse(parts[5]);
            ChecklistGoal goal = new ChecklistGoal(name, description, points, bonus, target, timesCompleted);
            _goals.Add(goal);
        }
    }
}