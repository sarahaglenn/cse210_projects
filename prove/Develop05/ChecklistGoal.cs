using System.Security.Cryptography.X509Certificates;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
        public ChecklistGoal(string name, string description, int points, int bonus, int target, int timesCompleted) : base (name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
        _amountCompleted = timesCompleted;
    }
    public override int RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {    
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {    
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (IsComplete())
        {
            checkbox = $"[X]";
        }
        return checkbox + $" {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()}~~{GetDescription()}~~{_points}~~{_bonus}~~{_target}~~{_amountCompleted}";
    }
    public override void ShowAnimation()
    {
        int i = 0;
        while (i < 5)
        {
            Console.Clear();
            Console.WriteLine("Congratulations on completing your goal!!");
            Console.WriteLine("(._.)/");
            Console.WriteLine("<) )");
            Console.WriteLine(" / \\");
            Thread.Sleep(400);

            Console.Clear();
            Console.WriteLine("Congratulations on completing your goal!!");
            Console.WriteLine("\\(._.)");
            Console.WriteLine(" ( (>");
            Console.WriteLine(" / \\");
            Thread.Sleep(400);
            i++;
        }
    }

}